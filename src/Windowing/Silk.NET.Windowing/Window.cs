// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport.Loaders;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Platform;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Convenience wrapper for easily creating a Silk.NET window.
    /// </summary>
    public static class Window
    {
        /// <summary>
        /// Create a window on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IWindow Create(WindowOptions options)
        {
            if (!SilkManager.IsRegistered<IWindowPlatform>()) {
                Init();
            }

            // We should have a platform now, as Silk.Init would've thrown otherwise.
            // ReSharper disable once PossibleNullReferenceException
            return SilkManager.Get<IWindowPlatform>().GetWindow(options);
        }

        /// <summary>
        /// Attempts to resolve an <see cref="IWindowPlatform" />.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// Thrown if no applicable <see cref="IWindowPlatform" /> was found.
        /// </exception>
        public static void Init()
        {
            var glfwPlatform = new GlfwPlatform();
            if (glfwPlatform.IsApplicable) {
                SilkManager.Register<IWindowPlatform>(glfwPlatform);
                SilkManager.Register<IGLSymbolLoader>(new GlfwLoader());
                return;
            }

            // TODO: Mobile

            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
                throw new NotSupportedException
                (
                    "Couldn't find a suitable windowing platform. You probably forgot to copy a glfw3 library into " +
                    "your bin/Debug or bin/Release folder (this won't be a problem in Preview 4)"
                );
            }
        }
    }
}