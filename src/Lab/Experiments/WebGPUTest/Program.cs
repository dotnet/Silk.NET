// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;
using Silk.NET.WebGPU;
using Silk.NET.WebGPU.Extensions.WGPU;
using Silk.NET.Windowing;

namespace WebGPUTest;

public static unsafe class Program
{
    public static Instance* instance;
    public static Adapter* adapter;
    public static Device* device;

    public static void Main(string[] args)
    {
        uint[] numbers = { 1, 2, 3, 4 };
        var numbersSize = (uint) numbers.Length * sizeof(uint);
        var numbersLength = (uint) numbers.Length;

        var webGpu = WebGPU.GetApi();

        if (!webGpu.TryGetDeviceExtension(null, out Wgpu wgpuSpecific))
        {
            throw new Exception("This code only runs on wgpu-native! Please PR in support for Dawn if you know how to get it working there!");
        }

        InstanceDescriptor instanceDescriptor = new InstanceDescriptor();
        instance = webGpu.CreateInstance(&instanceDescriptor);

        var requestAdapterOptions = new RequestAdapterOptions();
        webGpu.InstanceRequestAdapter(instance, &requestAdapterOptions, new PfnRequestAdapterCallback(RequestAdapterCallback), null);

        webGpu.AdapterRequestDevice(adapter, null, new PfnRequestDeviceCallback(RequestDeviceCallback), null);

        SetErrorCallback(webGpu);

        // ReSharper disable once InconsistentNaming
        var shaderModuleWGSLDescriptor = new ShaderModuleWGSLDescriptor();
        shaderModuleWGSLDescriptor.Chain.SType = SType.ShaderModuleWgslDescriptor;
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

        var shader = webGpu.DeviceCreateShaderModule(device, shaderModuleDescriptor);

        var stagingBufferDescription = new BufferDescriptor
        {
            Label            = (byte*) SilkMarshal.StringToPtr("Staging Buffer"), //TODO: free this
            Usage            = BufferUsage.MapRead | BufferUsage.CopyDst, 
            Size             = numbersSize,
            MappedAtCreation = false
        };
        var stagingBuffer = webGpu.DeviceCreateBuffer(device, stagingBufferDescription);

        var storageBufferDescription = new BufferDescriptor
        {
            Label            = (byte*) SilkMarshal.StringToPtr("Storage Buffer"), //TODO: free this
            Usage            = BufferUsage.Storage | BufferUsage.CopyDst | BufferUsage.CopySrc,
            Size             = numbersSize,
            MappedAtCreation = false
        };
        var storageBuffer = webGpu.DeviceCreateBuffer(device, storageBufferDescription);

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
        var computePipeline = webGpu.DeviceCreateComputePipeline(device, computePipelineDescriptor);

        var bindGroupLayout = webGpu.ComputePipelineGetBindGroupLayout(computePipeline, 0);

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

        var bindGroup = webGpu.DeviceCreateBindGroup(device, bindGroupDescriptor);

        var commandEncoderDescriptor = new CommandEncoderDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Command Encoder") //TODO: free this 
        };
        var encoder = webGpu.DeviceCreateCommandEncoder(device, commandEncoderDescriptor);

        var computePassDescriptor = new ComputePassDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Compute Pass") //TODO: free this  
        };
        var computePass = webGpu.CommandEncoderBeginComputePass(encoder, computePassDescriptor);

        webGpu.ComputePassEncoderSetPipeline(computePass, computePipeline);
        webGpu.ComputePassEncoderSetBindGroup(computePass, 0, bindGroup, 0, null);
        webGpu.ComputePassEncoderDispatchWorkgroups(computePass, numbersLength, 1, 1);
        webGpu.ComputePassEncoderEnd(computePass);
        webGpu.CommandEncoderCopyBufferToBuffer
        (
            encoder, storageBuffer, 0, stagingBuffer,
            0, numbersSize
        );

        var queue = webGpu.DeviceGetQueue(device);
        var commandBufferDescriptor = new CommandBufferDescriptor
        {
            Label = (byte*) SilkMarshal.StringToPtr("Command Buffer") //TODO: free this  
        };
        var cmdBuffer = webGpu.CommandEncoderFinish(encoder, commandBufferDescriptor);

        fixed (uint* numberPtr = numbers)
            webGpu.QueueWriteBuffer(queue, storageBuffer, 0, numberPtr, numbersSize);

        webGpu.QueueSubmit(queue, 1, &cmdBuffer);

        webGpu.BufferMapAsync(stagingBuffer, MapMode.Read, 0, numbersSize, new PfnBufferMapCallback(
                                (arg0, data) =>
                                {
                                    if(arg0 != BufferMapAsyncStatus.Success)
                                    {
                                        throw new Exception($"Unable to map buffer! status: {arg0}");
                                    }

                                    var times = (uint*) webGpu.BufferGetMappedRange(stagingBuffer, 0, numbersSize); ;

                                    Console.WriteLine($"Times: [{times[0]}, {times[1]}, {times[2]}, {times[3]}]");
                                }), null);

        wgpuSpecific.DevicePoll(device, true, null);
        webGpu.BufferUnmap(stagingBuffer);
    }

    private static void ReadBufferMap(BufferMapAsyncStatus arg0, void* arg1)
    {

    }

    private static void RequestDeviceCallback(RequestDeviceStatus arg0, Device* received, byte* arg2, void* arg3)
    {
        if(arg0 != RequestDeviceStatus.Success)
        {
            throw new Exception($"Unable to get WebGPU Device! status: {arg0} message: {SilkMarshal.PtrToString((nint)arg2)}");
        }
        device = received;
    }

    private static unsafe void RequestAdapterCallback(RequestAdapterStatus arg0, Adapter* received, byte* arg2, void* userdata)
    {
        if(arg0 != RequestAdapterStatus.Success)
        {
            throw new Exception($"Unable to get WebGPU Adapter! status: {arg0} message: {SilkMarshal.PtrToString((nint)arg2)}");
        }

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
