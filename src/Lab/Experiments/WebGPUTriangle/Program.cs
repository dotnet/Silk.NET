using System.Diagnostics;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Extensions.WebGPU;

namespace WebGPUTriangle;

public static unsafe class Program
{
    private static WebGPU   wgpu;
    private static Surface* surface;
    private static IWindow  window;

    private static Adapter* adapter;
    private static Device*  device;

    public static void Main()
    {
        //Create window
        var options = WindowOptions.Default;
        options.API              = GraphicsAPI.None;
        options.Size             = new Vector2D<int>(800, 600);
        options.FramesPerSecond  = 60;
        options.UpdatesPerSecond = 60;
        options.Position         = new Vector2D<int>(0, 0);
        options.Title            = "WebGPU Triangle";
        options.IsVisible        = true;

        window = Window.Create(WindowOptions.Default);

        window.Load   += WindowOnLoad;
        window.Update += WindowOnUpdate;
        window.Render += WindowOnRender;

        window.Run();
    }

    private static void WindowOnLoad()
    {
        wgpu = WebGPU.GetApi();

        surface = WebGPUWindow.CreateSurface(wgpu, window);

        { //Get adapter
            var requestAdapterOptions = new RequestAdapterOptions
            {
                CompatibleSurface = surface
            };

            wgpu.InstanceRequestAdapter
            (
                null,
                ref requestAdapterOptions,
                new PfnRequestAdapterCallback((_, adapter1, _, _) => adapter = adapter1),
                null
            );
        } //Get adapter

        { //Get device
            var requiredLimits = stackalloc RequiredLimits[1];
            requiredLimits->Limits.MaxBindGroups = 1;
            
            var deviceDescriptor = new DeviceDescriptor
            {
                RequiredLimits = requiredLimits,
                DefaultQueue = new QueueDescriptor()
            };

            wgpu.AdapterRequestDevice
            (
                adapter,
                ref deviceDescriptor,
                new PfnRequestDeviceCallback((_, device1, _, _) => device = device1),
                null
            );
        } //Get device
        
        wgpu.DeviceSetUncapturedErrorCallback(device, new PfnErrorCallback(UncapturedError), null);
        
        PrintAdapterFeatures();
    }
    
    private static void UncapturedError(ErrorType arg0, byte* arg1, void* arg2)
    {
        Console.WriteLine($"{arg0}: {SilkMarshal.PtrToString((nint) arg1)}");
    }

    private static void WindowOnUpdate(double delta) {}

    private static void WindowOnRender(double delta) {}
    
    private static void PrintAdapterFeatures()
    {
        var count = (int)wgpu.AdapterEnumerateFeatures(adapter, null);
        
        var features = stackalloc FeatureName[count];

        wgpu.AdapterEnumerateFeatures(adapter, features);
        
        Console.WriteLine("Adapter features:");
        
        for (var i = 0; i < count; i++)
        {
            Console.WriteLine($"\t{features[i]}");
        }
    }
}
