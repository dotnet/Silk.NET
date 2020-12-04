// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using System.Reflection;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Platform;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;
using GlfwLoader = Silk.NET.GLFW.GlfwLoader;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Convenience wrapper for easily creating a Silk.NET window.
    /// </summary>
    public static class Window
    {
        /// <summary>
        /// Gets whether this platform only supports window views. If false, this means that you may use desktop
        /// functionality with your applications.
        /// </summary>
        public static bool IsViewOnly
        {
            get
            {
                if (!SilkManager.IsRegistered<IWindowPlatform>())
                {
                    Init();
                }

                return SilkManager.Get<IWindowPlatform>().IsViewOnly;
            }
        }

        /// <summary>
        /// Create a window on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IWindow Create(WindowOptions options)
        {
            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
                Init();
            }

            if (IsViewOnly)
            {
                throw new NotSupportedException
                (
                    "The currently bound window platform only supports views," +
                    "instead of windows. Use the view APIs instead."
                );
            }

            // We should have a platform now, as Silk.Init would've thrown otherwise.
            // ReSharper disable once PossibleNullReferenceException
            return SilkManager.Get<IWindowPlatform>().CreateWindow(options);
        }

        /// <summary>
        /// Create a view on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IView GetView(ViewOptions? options = null)
        {
            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
                Init();
            }

            // We should have a platform now, as Silk.Init would've thrown otherwise.
            // ReSharper disable once PossibleNullReferenceException
            return SilkManager.Get<IWindowPlatform>().GetView(options);
        }

        /// <summary>
        /// Attempts to resolve an <see cref="IWindowPlatform" />.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// Thrown if no applicable <see cref="IWindowPlatform" /> was found.
        /// </exception>
        internal static void Init()
        {
            var glfwPlatform = GlfwPlatform.Instance;
            if (glfwPlatform.IsApplicable)
            {
                SilkManager.Register<IWindowPlatform>(glfwPlatform);
                SilkManager.Register<GLSymbolLoader>(new GlfwLoader());
                return;
            }

            // TODO: Mobile

            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
                var entAsm = Assembly.GetEntryAssembly()?.Location;
                entAsm = entAsm is null ? "the entry assembly" : Path.GetFileName(entAsm);
                throw new NotSupportedException
                (
                    "Couldn't find a suitable windowing platform. \n" +
                    $"GLFW: Copy a GLFW 3.3 binary into the same directory as {entAsm}\n"
                );
            }
        }

        /// <summary>
        /// Clears all current contexts for this backend on the current thread.
        /// </summary>
        public static void ClearCurrentContexts()
        {
            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
                Init();
            }

            SilkManager.Get<IWindowPlatform>().ClearContexts();
        }
    }
}
