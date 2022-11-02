// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;

namespace WebGPUTest;

public static unsafe class Program
{
    public static Adapter* adapter;
    public static Device* device;
    public static void Main(string[] args)
    {
        uint[] numbers = { 1, 2, 3, 4 };
        var numbersSize = (uint) numbers.Length * sizeof(uint);
        var numbersLength = (uint) numbers.Length;

        var wgpu = WebGPU.GetApi();

        var requestAdapterOptions = new RequestAdapterOptions();
        wgpu.InstanceRequestAdapter(null, &requestAdapterOptions, new PfnRequestAdapterCallback(RequestAdapterCallback), null);

        var deviceDescriptor = new DeviceDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Device"), //TODO: free this
            DefaultQueue = new QueueDescriptor(),
        };
        var requiredLimits = stackalloc RequiredLimits[1];
        requiredLimits[0] = new RequiredLimits
        {
            Limits = new Limits
            {
                MaxBindGroups = 1
            }
        };
        deviceDescriptor.RequiredLimits = requiredLimits;

        wgpu.AdapterRequestDevice(adapter, &deviceDescriptor, new PfnRequestDeviceCallback(RequestDeviceCallback), null);

        SetErrorCallback(wgpu);

        // ReSharper disable once InconsistentNaming
        var shaderModuleWGSLDescriptor = new ShaderModuleWGSLDescriptor();
        shaderModuleWGSLDescriptor.Chain.SType = SType.ShaderModuleWgsldescriptor;
        shaderModuleWGSLDescriptor.Chain.Next = null;
        shaderModuleWGSLDescriptor.Code = (byte*) SilkMarshal.StringToPtr
        (
            @"@group(0)
@binding(0)
var<storage, read_write> v_indices: array<u32>; // this is used as both input and output for convenience

// The Collatz Conjecture states that for any integer n:
// If n is even, n = n/2
// If n is odd, n = 3n+1
// And repeat this process for each new n, you will always eventually reach 1.
// Though the conjecture has not been proven, no counterexample has ever been found.
// This function returns how many times this recurrence needs to be applied to reach 1.
fn collatz_iterations(n_base: u32) -> u32{
    var n: u32 = n_base;
    var i: u32 = 0u;
    loop {
        if (n <= 1u) {
            break;
        }
        if (n % 2u == 0u) {
            n = n / 2u;
        }
        else {
            // Overflow? (i.e. 3*n + 1 > 0xffffffffu?)
            if (n >= 1431655765u) {   // 0x55555555u
                return 4294967295u;   // 0xffffffffu
            }

            n = 3u * n + 1u;
        }
        i = i + 1u;
    }
    return i;
}

@compute
@workgroup_size(1)
fn main(@builtin(global_invocation_id) global_id: vec3<u32>) {
    v_indices[global_id.x] = collatz_iterations(v_indices[global_id.x]);
}"
        ); //TODO: free this

        var shaderModuleDescriptor = new ShaderModuleDescriptor
        {
            NextInChain = (ChainedStruct*) (&shaderModuleWGSLDescriptor),
            Label = (byte*) SilkMarshal.StringToPtr("Test Compute Shader") //TODO: free this
        };

        var shader = wgpu.DeviceCreateShaderModule(device, ref shaderModuleDescriptor);

        var stagingBufferDescription = new BufferDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Staging Buffer"),  //TODO: free this
            Usage = (uint) (BufferUsage.MapRead | BufferUsage.CopyDst), //TODO: make this the proper enum
            Size = numbersSize,
            MappedAtCreation = false
        };
        var stagingBuffer = wgpu.DeviceCreateBuffer(device, ref stagingBufferDescription);

        var storageBufferDescription = new BufferDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Storage Buffer"),                        //TODO: free this
            Usage = (uint) (BufferUsage.Storage | BufferUsage.CopyDst | BufferUsage.CopySrc), //TODO: make this the proper enum
            Size = numbersSize,
            MappedAtCreation = false
        };
        var storageBuffer = wgpu.DeviceCreateBuffer(device, ref storageBufferDescription);

        var computePipelineDescriptor = new ComputePipelineDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Compute Pipeline"), //TODO: free this
            Layout = null,
            Compute = new ProgrammableStageDescriptor
            {
                Module = shader,
                EntryPoint = (byte*) SilkMarshal.StringToPtr("main") //TODO: free this
            }
        };
        var computePipeline = wgpu.DeviceCreateComputePipeline(device, ref computePipelineDescriptor);

        var bindGroupLayout = wgpu.ComputePipelineGetBindGroupLayout(computePipeline, 0);

        var bindGroupDescriptor = new BindGroupDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Bind Group"), //TODO: free this
            Layout = bindGroupLayout
        };

        var entries = stackalloc BindGroupEntry[1];
        entries->Binding = 0;
        entries->Buffer = storageBuffer;
        entries->Offset = 0;
        entries->Size = numbersSize;

        bindGroupDescriptor.Entries = entries;
        bindGroupDescriptor.EntryCount = 1;

        var bindGroup = wgpu.DeviceCreateBindGroup(device, ref bindGroupDescriptor);

        var commandEncoderDescriptor = new CommandEncoderDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Command Encoder") //TODO: free this 
        };
        var encoder = wgpu.DeviceCreateCommandEncoder(device, ref commandEncoderDescriptor);

        var computePassDescriptor = new ComputePassDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Compute Pass") //TODO: free this  
        };
        var computePass = wgpu.CommandEncoderBeginComputePass(encoder, ref computePassDescriptor);

        wgpu.ComputePassEncoderSetPipeline(computePass, computePipeline);
        wgpu.ComputePassEncoderSetBindGroup(computePass, 0, bindGroup, 0, null);
        wgpu.ComputePassEncoderDispatchWorkgroups(computePass, numbersLength, 1, 1);
        wgpu.ComputePassEncoderEnd(computePass);
        wgpu.CommandEncoderCopyBufferToBuffer
        (
            encoder, storageBuffer, 0, stagingBuffer,
            0, numbersSize
        );

        var queue = wgpu.DeviceGetQueue(device);
        var commandBufferDescriptor = new CommandBufferDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Command Buffer") //TODO: free this  
        };
        var cmdBuffer = wgpu.CommandEncoderFinish(encoder, ref commandBufferDescriptor);

        fixed (uint* numberPtr = numbers)
            wgpu.QueueWriteBuffer(queue, storageBuffer, 0, numberPtr, numbersSize);

        wgpu.QueueSubmit(queue, 1, ref cmdBuffer);

        var wait = true;
        wgpu.BufferMapAsync(stagingBuffer, (uint) MapMode.Read, 0, numbersSize, new PfnBufferMapCallback(
                                (arg0, data) =>
                                {
                                    Console.WriteLine($"status: {arg0}");

                                    var times = (uint*) wgpu.BufferGetMappedRange(stagingBuffer, 0, numbersSize); ;

                                    Console.WriteLine($"Times: [{times[0]}, {times[1]}, {times[2]}, {times[3]}]");

                                    wait = false;
                                }), null);

        //Wait for the buffer to be mapped
        while (wait)
        {
            Thread.Sleep(10000);
        }

        wgpu.BufferUnmap(stagingBuffer);

        ;
    }

    private static void ReadBufferMap(BufferMapAsyncStatus arg0, void* arg1)
    {

    }

    private static void RequestDeviceCallback(RequestDeviceStatus arg0, Device* received, byte* arg2, void* arg3)
    {
        device = received;
    }

    private static unsafe void RequestAdapterCallback(RequestAdapterStatus arg0, Adapter* received, byte* arg2, void* userdata)
    {
        adapter = received;
    }

    private static void SetErrorCallback(WebGPU wgpu)
    {
        wgpu.DeviceSetUncapturedErrorCallback
        (
            device, new PfnErrorCallback
            (
                (arg0, b, @void) =>
                {
                    Console.WriteLine($"Error: {arg0} Message: {SilkMarshal.PtrToString((nint) b)}");
                }
            ), null
        );
    }
}
