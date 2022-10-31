using Silk.NET.Core.Native;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;
using Buffer = Silk.NET.WebGPU.Buffer;

public static unsafe class Program
{
    public static Adapter* adapter;
    public static Device*  device;
    public static void Main(string[] args)
    {
        var window = Window.Create(WindowOptions.Default);

        uint[] numbers       = { 1, 2, 3, 4 };
        var    numbersSize   = (uint) numbers.Length * sizeof(uint);
        var    numbersLength = (uint) numbers.Length;

        var wgpu = WebGPU.GetApi();

        var requestAdapterOptions = new RequestAdapterOptions();
        wgpu.InstanceRequestAdapter(null, &requestAdapterOptions, new PfnRequestAdapterCallback(RequestAdapterCallback), null);

        var deviceDescriptor = new DeviceDescriptor
        {
            Label        = (byte*) SilkMarshal.StringToPtr("Device"), //TODO: free this
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
        shaderModuleWGSLDescriptor.Chain.Next  = null;
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
            Label       = (byte*) SilkMarshal.StringToPtr("Test Compute Shader") //TODO: free this
        };

        var shader = wgpu.DeviceCreateShaderModule(device, ref shaderModuleDescriptor);

        var stagingBufferDescription = new BufferDescriptor
        {
            Label            = (byte*) SilkMarshal.StringToPtr("Staging Buffer"),  //TODO: free this
            Usage            = (uint) (BufferUsage.MapRead | BufferUsage.CopyDst), //TODO: make this the proper enum
            Size             = numbersSize,
            MappedAtCreation = false
        };
        var stagingBuffer = wgpu.DeviceCreateBuffer(device, ref stagingBufferDescription);

        var storageBufferDescription = new BufferDescriptor
        {
            Label            = (byte*) SilkMarshal.StringToPtr("Storage Buffer"),                        //TODO: free this
            Usage            = (uint) (BufferUsage.Storage | BufferUsage.CopyDst | BufferUsage.CopySrc), //TODO: make this the proper enum
            Size             = numbersSize,
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

        window.Load   += () => {};
        window.Update += _ => {};
        window.Render += _ => {};
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
