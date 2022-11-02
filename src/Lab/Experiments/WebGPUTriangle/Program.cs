using System.Diagnostics;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Extensions.WebGPU;

namespace WebGPUTriangle;

public static unsafe class Program
{
    private static WebGPU   wgpu;
    private static Surface* surface;
    
    public static void Main()
    {
        //Create window
        var options = WindowOptions.Default;
        options.API = GraphicsAPI.None;

        var window = Window.Create(WindowOptions.Default);

        window.Load   += WindowOnLoad;
        window.Update += WindowOnUpdate;
        window.Render += WindowOnRender;

        window.Run();

        void WindowOnLoad()
        {
            wgpu = WebGPU.GetApi();

            surface = WebGPUWindow.CreateSurface(wgpu, window);
        }

        void WindowOnUpdate(double delta)
        {
    
        }

        void WindowOnRender(double delta)
        {
    
        }

    }
}
