// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// A IGLContext using GLFW and a window handle.
    /// </summary>
    public class GlfwContext : IGLContext
    {
        private readonly Glfw _glfw;
        private readonly unsafe WindowHandle* _window;

        /// <summary>
        /// Creates a GlfwContext using the given API instance and window handle.
        /// </summary>
        /// <param name="glfw">The GLFW API instance to use.</param>
        /// <param name="window">The window handle to source context info from.</param>
        public unsafe GlfwContext(Glfw glfw, WindowHandle* window)
        {
            _window = window;
            _glfw = glfw;
        }

        /// <inheritdoc />
        public IntPtr GetProcAddress(string proc) => _glfw.GetProcAddress(proc);

        /// <inheritdoc />
        public unsafe IntPtr Handle => (IntPtr)_window;

        /// <inheritdoc />
        public unsafe bool IsCurrent => _glfw.GetCurrentContext() == _window;

        /// <inheritdoc />
        public void SwapInterval(int interval) => _glfw.SwapInterval(interval);

        /// <inheritdoc />
        public unsafe void SwapBuffers() => _glfw.SwapBuffers(_window);

        /// <inheritdoc />
        public unsafe void MakeCurrent() => _glfw.MakeContextCurrent(_window);

        /// <inheritdoc />
        public unsafe void Clear()
        {
            if (IsCurrent)
            {
                _glfw.MakeContextCurrent(null);
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}
