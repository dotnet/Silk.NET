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
                    Format.FormatUnknown, new Vector4(0.0f, 0.2f, 0.4f, 1.0f), Format.FormatUnknown, 1, 2, window,
                    args.Any(y => y.Equals("--use-warp-device", StringComparison.OrdinalIgnoreCase))
                );
            };
            window.Closing += () => { pSample.OnDestroy(); };
            window.Run();
        }
    }
}
