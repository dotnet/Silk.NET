using System;
using System.Linq;
using System.Numerics;
using Silk.NET.DXGI;
using Silk.NET.Windowing;

namespace D3D12Triangle
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var opts = WindowOptions.Default;
            opts.API = GraphicsAPI.None;
            using var window = Window.Create(opts);
            var pSample = new HelloTriangle("Hello Triangle on D3D12");
            window.Load += () =>
            {
                pSample.OnInit
                (
                    Format.FormatUnknown, Vector4.Zero, Format.FormatUnknown, 1, 2, window,
                    args.Any(y => y.Equals("--use-warp-device", StringComparison.OrdinalIgnoreCase))
                );
            };
            window.Closing += pSample.OnDestroy;
            window.Render += _ => pSample.OnRender();
            window.Update += _ => pSample.OnUpdate();
            window.Resize += pSample.OnWindowSizeChanged;
            window.Run();
        }
    }
}
