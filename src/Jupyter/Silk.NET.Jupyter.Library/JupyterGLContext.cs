// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.EGL;
using Silk.NET.Windowing;

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

        public JupyterGLContext(IGLContextSource? source, int width, int height, GraphicsAPI graphicsAPI)
        {
            _width = width;
            _height = height;
            Source = source;
            EGL = NET.EGL.EGL.GetApi();

            var bit = graphicsAPI.API switch
            {
                ContextAPI.OpenGL => EGLEnum.OpenglBit,
                ContextAPI.OpenGLES => graphicsAPI.Version.MajorVersion switch
                {
                    2 => EGLEnum.OpenglES2Bit,
                    3 => EGLEnum.OpenglES3Bit,
                    _ => EGLEnum.OpenglESBit
                }
            };

            var api = graphicsAPI.API switch
            {
                ContextAPI.OpenGL => EGLEnum.OpenglApi,
                ContextAPI.OpenGLES => EGLEnum.OpenglESApi
            };
            
            Display = EGL.GetDisplay((nint) EGLEnum.DefaultDisplay);
            
            if (EGL.Initialize(Display, null, null) == 0)
                throw new Exception("Cannot initialize EGL");

            var configAttribs = stackalloc int[]
            {
                (int) EGLEnum.SurfaceType, (int)EGLEnum.PbufferBit,
                (int) EGLEnum.RenderableType, (int) bit,
                (int) EGLEnum.Conformant, (int) bit,
                (int) EGLEnum.ColorBufferType, (int)EGLEnum.RgbBuffer,
                (int) EGLEnum.LuminanceSize, 0,
                (int) EGLEnum.RedSize, 8,
                (int) EGLEnum.GreenSize, 8,
                (int) EGLEnum.BlueSize, 8,
                (int) EGLEnum.AlphaSize, 8,
                (int) EGLEnum.DepthSize, 8,
                (int) EGLEnum.Level, 0,
                (int) EGLEnum.BufferSize, 24,
                (int) EGLEnum.None
            };
            if (EGL.ChooseConfig(Display, configAttribs, out var config, 1, out var numConfig) == 0)
                throw new Exception("Could not choose config");
            
            var surfaceAttributes = stackalloc int[]
            {
                (int)EGLEnum.Height, _height,
                (int)EGLEnum.Width, _width,
                (int)EGLEnum.None
            };
            
            Surface = EGL.CreatePbufferSurface(Display, config, surfaceAttributes);

            if (EGL.BindApi(api) == 0)
                throw new Exception("Cannot Bind OpenGL API");

            var contextAttributes = stackalloc int[]
            {
                (int) EGLEnum.ContextClientVersion, graphicsAPI.Version.MajorVersion,
                (int) EGLEnum.None
            };
            Context = EGL.CreateContext(Display, config, (nint) EGLEnum.NoContext, contextAttributes);
        }

        public void Dispose()
        {
            EGL.DestroySurface(Display, Surface);
            EGL.DestroyContext(Display, Context);
            EGL.Terminate(Display);
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
            EGL.MakeCurrent(Display, Surface, Surface, Context);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
