// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.EGL;

namespace Silk.NET.Jupyter
{
    internal sealed unsafe class JupyterGLContext : IGLContext
    {
        private readonly int _width;
        private readonly int _height;
        public EGL.EGL EGL { get; }
        public nint Display { get; }
        public nint Context { get; }
        public nint Surface { get; }

        public JupyterGLContext(IGLContextSource? source, int width, int height)
        {
            _width = width;
            _height = height;
            Source = source;
            EGL = NET.EGL.EGL.GetApi();
            Display = EGL.GetDisplay((nint) EGLEnum.DefaultDisplay);
            if (!EGL.Initialize(Display, null, null))
                throw new Exception("Cannot initialize EGL");

            if (!EGL.BindApi(EGLEnum.OpenglApi))
                throw new Exception("Cannot Bind OpenGL API");

            var configAttributes = stackalloc int[]
            {
                (int)EGLEnum.RedSize, 8,
                (int)EGLEnum.GreenSize, 8,
                (int)EGLEnum.BlueSize, 8,
                (int)EGLEnum.None
            };

            if (!EGL.ChooseConfig(Display, configAttributes, out var config, 1, out var numConfig))
                throw new Exception("Could not choose config");

            Context = EGL.CreateContext(Display, config, (nint) EGLEnum.NoContext, null);

            var surfaceAttributes = stackalloc int[]
            {
                (int)EGLEnum.Height, _height,
                (int)EGLEnum.Width, _width,
                (int)EGLEnum.None
            };
            
            Surface = EGL.CreatePbufferSurface(Display, config, surfaceAttributes);
            MakeCurrent();
        }

        public void Dispose()
        {
            EGL.DestroySurface(Display, Surface);
            EGL.DestroyContext(Display, Context);
        }

        public nint GetProcAddress(string proc, int? slot = default)
        {
            return (nint) EGL.GetProcAddress(proc);
        }

        public nint Handle => throw new NotImplementedException();
        public IGLContextSource? Source { get; }
        public bool IsCurrent => throw new NotImplementedException();
        public void SwapInterval(int interval)
        {
            EGL.SwapInterval(Display, interval);
        }

        public void SwapBuffers()
        {
            EGL.SwapBuffers(Display, Surface);
        }

        public void MakeCurrent()
        {
            EGL.MakeCurrent(Display, Surface, Surface, Surface);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
