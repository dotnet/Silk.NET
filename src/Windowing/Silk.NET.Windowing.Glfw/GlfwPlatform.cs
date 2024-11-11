// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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

        private Lazy<bool> _isApplicable = new Lazy<bool>
        (
            () =>
            {
                GLFW.Glfw? api = null;
                try
                {
                    api = GLFW.Glfw.GetApi(); // activate the class so we can determine if we can activate the class
                }
                catch (Exception ex)
                {
#if DEBUG
                    Console.WriteLine($"Can't load GLFW: {ex}");
#endif
                    return false;
                }
                finally
                {
                    api?.Dispose();
                }

                return true;
            }
        );

        string Name => nameof(GlfwPlatform);
        
        /// <inheritdoc />
        public bool IsViewOnly { get; } = false;

        /// <inheritdoc />
        public bool IsApplicable => _isApplicable.Value;
        
        private static void ThrowUnsupported()
            => throw new PlatformNotSupportedException("GLFW is not supported on this platform.");

        /// <inheritdoc />
        public IWindow CreateWindow(WindowOptions options)
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                return null!;
            }
            
            return _lastCreatedWindow = new GlfwWindow(options, null, null);
        }

        /// <inheritdoc />
        public IView GetView(ViewOptions? opts = null)
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                return null!;
            }
            
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
