using Silk.NET.Core.Native;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;

public static class Program
{
    public static unsafe void Main(string[] args)
    {
        var window = Window.Create(WindowOptions.Default);

        WebGPU wgpu = WebGPU.GetApi();
        
        var instanceDescriptor = new InstanceDescriptor();
        var instance           = wgpu.CreateInstance(ref instanceDescriptor);

        var      requestAdapterOptions = new RequestAdapterOptions();
        Adapter* adapter               = null;
        wgpu.InstanceRequestAdapter
        (
            instance, ref requestAdapterOptions, new
            (
                (arg0, adapter1, _, _) =>
                {
                    adapter = adapter1;
                }
            ), null
        );

        var limits  = new SupportedLimits();
        var success = wgpu.AdapterGetLimits(adapter, &limits);

        var deviceDescriptor = new DeviceDescriptor();

        RequiredLimits* requiredLimits = stackalloc RequiredLimits[1];
        requiredLimits->Limits               = new Limits();
        requiredLimits->Limits.MaxBindGroups = 1;

        deviceDescriptor.RequiredLimits = requiredLimits;

        Device* device = null;
        wgpu.AdapterRequestDevice
        (
            adapter,
            ref deviceDescriptor,
            new PfnRequestDeviceCallback
            (
                (arg0, device1, b, arg3) =>
                {
                    device = device1;
                }
            ),
            null
        );

        wgpu.DeviceSetUncapturedErrorCallback(device, new PfnErrorCallback(
                                                  (arg0, b, @void) =>
                                                  {
                                                      Console.WriteLine($"Error: {arg0} Message: {SilkMarshal.PtrToString((nint) b)}");
                                                  }), null);

        var wgslDescriptor = new ShaderModuleWGSLDescriptor
        {
            Code = (byte*) SilkMarshal.StringToPtr
            (
                @"@workgroup_size(64)
fn main() {
  // Pointless!
}"
            ),
            Chain = new ChainedStruct
            {
                SType = SType.ShaderModuleWgsldescriptor
            }
        };

        var shaderModuleDescriptor = new ShaderModuleDescriptor
        {
            NextInChain = &wgslDescriptor.Chain
        };

        var shader = wgpu.DeviceCreateShaderModule(device, ref shaderModuleDescriptor);
        //TODO: get this to work
        // wgpu.ShaderModuleGetCompilationInfo(shader, new PfnCompilationInfoCallback(
        //                                         (arg0, info, @void) =>
        //                                         {
        //                                             Console.WriteLine($"Status: {arg0}");
        //                                             Console.WriteLine($"MessageCount: {info->MessageCount}");
        //                                             for (int i = 0; i < info->MessageCount; i++)
        //                                             {
        //                                                 var message = info->Messages[i];
        //                                                 Console.WriteLine($"Message: {SilkMarshal.PtrToString((nint) message.Message)}");
        //                                             }
        //                                         }), null);

        window.Load   += () => {};
        window.Update += _ => {};
        window.Render += _ => {};
    }
}
