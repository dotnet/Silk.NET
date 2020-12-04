// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

[assembly: InternalsVisibleTo("Silk.NET.Input.Desktop")]

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A GLFW-based backend.
    /// </summary>
    public class GlfwPlatform : IWindowPlatform
    {
        private GlfwPlatform()
        {
        }

        /// <summary>
        /// Gets this instance of the windowing platform.
        /// </summary>
        public static GlfwPlatform Instance { get; } = new GlfwPlatform();

        /// <inheritdoc />
        public bool IsViewOnly { get; } = false;

        /// <inheritdoc />
        public bool IsApplicable
        {
            get
            {
                try
                {
                    Glfw.GetApi(); // activate the class so we can determine if we can activate the class
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }

        /// <inheritdoc />
        public IWindow CreateWindow(WindowOptions options) => new GlfwWindow(options, null, null);

        /// <inheritdoc />
        public IView GetView(ViewOptions? opts = null) => CreateWindow(new WindowOptions(opts ?? ViewOptions.Default));

        /// <inheritdoc />
        public unsafe void ClearContexts() => GlfwProvider.GLFW.Value.MakeContextCurrent(null);

        /// <inheritdoc />
        public IEnumerable<IMonitor> GetMonitors() => new GlfwMonitorEnumerable();

        /// <inheritdoc />
        public unsafe IMonitor GetMainMonitor() => new GlfwMonitor(GlfwProvider.GLFW.Value.GetPrimaryMonitor(), 0);
    }
}
