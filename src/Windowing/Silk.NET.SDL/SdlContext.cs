// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Text;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.SDL
{
    public unsafe class SdlContext : IGLContext
    {
        private readonly Sdl _sdl;
        private void* _ctx;
        private Window* _window;

        /// <summary>
        /// Creates a <see cref="SdlContext"/> from a native window using the given native interface.
        /// </summary>
        /// <param name="sdl">The native interface to use.</param>
        /// <param name="window">The native window to associate this context for.</param>
        /// <param name="source">The <see cref="IGLContextSource" /> to associate this context to, if any.</param>
        /// <param name="attributes">The attributes to eagerly pass to <see cref="Create"/>.</param>
        public SdlContext(Sdl sdl,
            Window* window,
            IGLContextSource? source = null,
            params (GLattr Attribute, int Value)[] attributes)
        {
            _sdl = sdl;
            Window = window;
            Source = source;
            if (attributes is not null && attributes.Length > 0)
            {
                Create(attributes);
            }
        }

        /// <summary>
        /// The native window to create a context for.
        /// </summary>
        public Window* Window
        {
            get => _window;
            set
            {
                AssertNotCreated();
                _window = value;
            }
        }

        /// <inheritdoc cref="IGLContext" />
        public Vector2D<int> FramebufferSize
        {
            get
            {
                AssertCreated();
                var ret = stackalloc int[2];
                _sdl.GLGetDrawableSize(Window, ret, &ret[1]);
                _sdl.ThrowError();
                return *(Vector2D<int>*) ret;
            }
        }

        /// <inheritdoc cref="IGLContext" />
        public void Create(params (GLattr Attribute, int Value)[] attributes)
        {
            foreach (var (attribute, value) in attributes)
            {
                if (_sdl.GLSetAttribute(attribute, value) != 0)
                {
                    _sdl.ThrowError();
                }
            }

            _ctx = _sdl.GLCreateContext(Window);
            if (_ctx == null)
            {
                _sdl.ThrowError();
            }
        }

        private void AssertCreated()
        {
            if (_ctx == null)
            {
                throw new InvalidOperationException("Context not created.");
            }
        }

        private void AssertNotCreated()
        {
            if (_ctx != null)
            {
                throw new InvalidOperationException("Context created already.");
            }
        }

        /// <inheritdoc cref="IGLContext" />
        public void Dispose()
        {
            if (_ctx != null)
            {
                _sdl.GLDeleteContext(_ctx);
                _ctx = null;
            }
        }

        /// <inheritdoc cref="IGLContext" />
        public nint GetProcAddress(string proc, int? slot = default)
        {
            AssertCreated();
            _sdl.ClearError();
            nint ret;
            fixed (byte* procPtr = Encoding.UTF8.GetBytes(proc))
            {
                ret = (nint) _sdl.GLGetProcAddress(procPtr);
            }

            _sdl.ThrowError();
            if (ret == 0)
            {
                Throw(proc);
                return 0;
            }

            return ret;
            static void Throw(string proc) => throw new SymbolLoadingException(proc);
        }

        public bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
        {
            addr = 0;
            _sdl.ClearError();
            if (_ctx is null)
            {
                return false;
            }
            
            nint ret;
            fixed (byte* procPtr = Encoding.UTF8.GetBytes(proc))
            {
                ret = (nint) _sdl.GLGetProcAddress(procPtr);
            }

            if (!string.IsNullOrWhiteSpace(SilkMarshal.PtrToString((nint) _sdl.GetError())))
            {
                _sdl.ClearError();
                return false;
            }

            return (addr = ret) != 0;
        }

        /// <inheritdoc cref="IGLContext" />
        public nint Handle
        {
            get
            {
                AssertCreated();
                return (nint) _ctx;
            }
        }

        /// <inheritdoc cref="IGLContext" />
        public IGLContextSource? Source { get; }

        /// <inheritdoc cref="IGLContext" />
        public bool IsCurrent
        {
            get
            {
                AssertCreated();
                return _sdl.GLGetCurrentContext() == _ctx;
            }
        }

        /// <inheritdoc cref="IGLContext" />
        public void SwapInterval(int interval)
        {
            AssertCreated();
            _sdl.GLSetSwapInterval(interval);
        }

        /// <inheritdoc cref="IGLContext" />
        public void SwapBuffers()
        {
            AssertCreated();
            _sdl.GLSwapWindow(Window);
        }

        /// <inheritdoc cref="IGLContext" />
        public void MakeCurrent()
        {
            AssertCreated();
            _sdl.GLMakeCurrent(Window, _ctx);
        }

        /// <inheritdoc cref="IGLContext" />
        public void Clear()
        {
            AssertCreated();
            if (IsCurrent)
            {
                _sdl.GLMakeCurrent(Window, null);
            }
        }
    }
}
