using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using Silk.NET.Core.Native;
using Silk.NET.EGL;
using Silk.NET.Jupyter;
using Silk.NET.OpenGLES;
using Silk.NET.Windowing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace JupyterTest
{
    class Program
    {
        
        static unsafe void Main(string[] args)
        {

            using var view = JupyterView.Create(100, 100, new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Core, ContextFlags.Default, new APIVersion(3, 0)));
            view.Initialize();
            view.MakeCurrent();
            var Gl = view.CreateOpenGLES();

            void Assert()
            {
                var err = Gl.GetError();
                Debug.Assert(err == 0);
            }

            Gl.ClearColor(0.9f, 0.8f, 0.5f, 1.0f);
            Gl.Clear((uint)GLEnum.ColorBufferBit);
            Gl.Finish();

            var arr = new Rgba32[100 * 100];
            fixed (Rgba32* p = arr)
                Gl.ReadPixels(0, 0, 100, 100, PixelFormat.Rgba, PixelType.UnsignedByte, p);
            Assert();
            Gl.Finish();
            Assert();

            var img = Image<Rgba32>.WrapMemory(arr.AsMemory(), 100, 100);
            
            img.SaveAsPngAsync("./output.png").GetAwaiter().GetResult();
        }
    }
}
