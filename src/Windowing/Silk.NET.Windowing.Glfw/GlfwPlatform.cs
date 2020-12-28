// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Silk.NET.GLFW;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;

[assembly: WindowPlatform(typeof(GlfwPlatform))]

namespace Silk.NET.Windowing.Glfw
{
    /// <summary>
    /// A GLFW-based backend.
    /// </summary>
    internal class GlfwPlatform : IWindowPlatform
    {
        private IWindow? _lastCreatedWindow;
        
        /// <inheritdoc />
        public bool IsViewOnly { get; } = false;

        /// <inheritdoc />
        public bool IsApplicable
        {
            get
            {
                try
                {
                    GLFW.Glfw.GetApi(); // activate the class so we can determine if we can activate the class
                }
                catch (Exception ex)
                {
#if DEBUG
                    Console.WriteLine($"Can't load GLFW: {ex}");
#endif
                    return false;
                }

                return true;
            }
        }

        /// <inheritdoc />
        public IWindow CreateWindow(WindowOptions options) => _lastCreatedWindow = new GlfwWindow(options, null, null);

        /// <inheritdoc />
        public IView GetView(ViewOptions? opts = null)
        {
            return opts switch
            {
                null when _lastCreatedWindow is null => throw new InvalidOperationException
                (
                    "No view has been created prior to this call, and couldn't " +
                    "create one due to no view options being provided."
                ),
                null => _lastCreatedWindow!,
                _ => _lastCreatedWindow = CreateWindow(new WindowOptions(opts.Value))
            };
        }

        /// <inheritdoc />
        public unsafe void ClearContexts() => GlfwProvider.GLFW.Value.MakeContextCurrent(null);

        /// <inheritdoc />
        public IEnumerable<IMonitor> GetMonitors() => new GlfwMonitorEnumerable();

        /// <inheritdoc />
        public unsafe IMonitor GetMainMonitor() => new GlfwMonitor(GlfwProvider.GLFW.Value.GetPrimaryMonitor(), 0);

        public bool IsSourceOfView(IView view) => view is GlfwWindow;
    }
}
