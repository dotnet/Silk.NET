// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.Core.Contexts;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl
{
    internal unsafe class SdlGLContext : IGLContext
    {
        private readonly SdlView _view;
        private void* _ctx;

        public SdlGLContext(SdlView view)
        {
            _view = view;
        }

        public Size FramebufferSize
        {
            get
            {
                var ret = stackalloc int[2];
                _view.Sdl.GLGetDrawableSize(_view.SdlWindow, ret, &ret[1]);
                _view.Sdl.ThrowError();
                return *(Size*) ret;
            }
        }

        public void Create(params (GLattr Attribute, int Value)[] attributes)
        {
            foreach (var (attribute, value) in attributes)
            {
                _view.Sdl.GLSetAttribute(attribute, value);
                _view.Sdl.ThrowError();
            }

            _ctx = _view.Sdl.GLCreateContext(_view.SdlWindow);
        }

        public void Dispose() => _view.Sdl.GLDeleteContext(_ctx);
        public IntPtr GetProcAddress(string proc, int? slot = default) => (IntPtr) _view.Sdl.GLGetProcAddress(proc);
        public IntPtr Handle => (IntPtr) _ctx;
        public bool IsCurrent => _view.Sdl.GLGetCurrentContext() == _ctx;
        public void SwapInterval(int interval) => _view.Sdl.GLSetSwapInterval(interval);
        public void SwapBuffers() => _view.Sdl.GLSwapWindow(_view.SdlWindow);
        public void MakeCurrent() => _view.Sdl.GLMakeCurrent(_view.SdlWindow, _ctx);

        public void Clear()
        {
            if (IsCurrent)
            {
                _view.Sdl.GLMakeCurrent(_view.SdlWindow, null);
            }
        }
    }
}
