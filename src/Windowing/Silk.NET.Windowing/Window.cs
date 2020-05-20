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
using Silk.NET.Windowing.Glfw;
using GlfwLoader = Silk.NET.GLFW.GlfwLoader;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Convenience wrapper for easily creating a Silk.NET window.
    /// </summary>
    public static class Window
    {
        public static IWindowPlatform Platform { get; set; }
        /// <summary>
        /// Instructs the windowing system to prefer the SDL backend over the GLFW backend on platforms where GLFW is
        /// supported.
        /// </summary>
        public static bool PreferSdl { get; set; }
        public static bool IsGlfw => Platform is GlfwPlatform;
        // TODO IsSdl
        
        /// <summary>
        /// Gets whether this platform only supports window views. If false, this means that you may use desktop
        /// functionality with your applications.
        /// </summary>
        public static bool IsViewOnly
        {
            get
            {
                if (Platform is null)
                {
                    Init();
                }

                return Platform.IsViewOnly;
            }
        }
        
        /// <summary>
        /// Create a window on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IWindow Create(WindowOptions options)
        {
            if (Platform is null)
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

            // ReSharper disable once PossibleNullReferenceException
            return Platform.CreateWindow(options);
        }
        
        /// <summary>
        /// Create a view on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IView GetView(ViewOptions? options = null)
        {
            if (Platform is null)
            {
                Init();
            }

            // We should have a platform now, as Silk.Init would've thrown otherwise.
            // ReSharper disable once PossibleNullReferenceException
            return Platform.GetView(options);
        }

        /// <summary>
        /// Attempts to resolve an <see cref="IWindowPlatform" />.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// Thrown if no applicable <see cref="IWindowPlatform" /> was found.
        /// </exception>
        public static void Init()
        {
            var glfwPlatform = GlfwPlatform.Instance;
            if (glfwPlatform.IsApplicable)
            {
                Platform = glfwPlatform;
                SilkManager.Register<GLSymbolLoader>(new GlfwLoader()); // TODO remove this 2.0
                return;
            }

            // TODO: SDL & Mobile

            if (Platform is null)
            {
                var entAsm = Assembly.GetEntryAssembly()?.Location;
                entAsm = entAsm is null ? "the entry assembly" : Path.GetFileName(entAsm);
                throw new NotSupportedException
                (
                    "Couldn't find a suitable windowing platform. \n"+
                    $"GLFW: Copy a GLFW 3.3 binary into the same directory as {entAsm}\n"
                );
            }
        }

        /// <summary>
        /// Clears all current contexts for this backend on the current thread.
        /// </summary>
        public static void ClearCurrentContexts()
        {
            if (Platform is null)
            {
                Init();
            }
            
            Platform.ClearContexts();
        }

        public static bool IsUsingGlfw(IView view) => view is GlfwWindow;
        // TODO allow passing in a GLFW WindowHandle*
        // TODO allow passing in a SDL window handle
    }
}
