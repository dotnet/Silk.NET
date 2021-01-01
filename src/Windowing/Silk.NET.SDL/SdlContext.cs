// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;
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
                _sdl.GLSetAttribute(attribute, value);
                _sdl.ThrowError();
            }

            _ctx = _sdl.GLCreateContext(Window);
            _sdl.ThrowError();
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
            AssertCreated();
            _sdl.GLDeleteContext(_ctx);
            _ctx = null;
        }

        /// <inheritdoc cref="IGLContext" />
        public nint GetProcAddress(string proc, int? slot = default)
        {
            AssertCreated();
            return (nint) _sdl.GLGetProcAddress(proc);
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
