// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.DotNet.PlatformAbstractions;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Sdl;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Convenience wrapper for easily creating a Silk.NET window.
    /// </summary>
    public static class Window
    {
        internal const string GlfwBackendAssembly = "Silk.NET.Windowing.GlfwBackend";
        internal const string GlfwBackendType = "Silk.NET.Windowing.GlfwBackend.GlfwPlatform";
        /// <summary>
        /// Gets the Silk.NET-provided windowing backend to use.
        /// </summary>
        /// <remarks>
        /// The platform returned by this property will use SDL unless the Silk.NET.Windowing.GlfwBackend package is
        /// installed, in which case this property will return a platform powered by GLFW. Using the SDL backend is
        /// generally recommended, however if you use GLFW-specific code you may want to install the GLFW backend to
        /// allow this code to continue to work. If this package is installed but GLFW is unavailable in the current
        /// environment, Silk.NET will automatically fallback on the SDL platform. If SDL is not applicable, this
        /// property will return null and all methods will throw an exception unless you manually provide a custom
        /// platform.
        /// </remarks>
        public static IWindowPlatform? FirstPartyPlatform { get; }
        /// <summary>
        /// Gets or sets the custom windowing platform to use.
        /// </summary>
        public static IWindowPlatform? Platform { get; set; }
        internal static Exception NoPlatformException
            => new PlatformNotSupportedException("No applicable windowing platform found.");

        static Window()
        {
            var sdlPlatform = new SdlPlatform();
            IWindowPlatform glfwPlatform = null;
            try
            {
                var glfwBackendAssembly = Assembly.Load(GlfwBackendAssembly);
                var glfwPlatformType = glfwBackendAssembly.GetType(GlfwBackendType);
                glfwPlatform = Activator.CreateInstance(glfwPlatformType, true) as IWindowPlatform;
            }
            catch
            {
                // do nothing, just means there's no GLFW available.
            }

            if (glfwPlatform?.IsApplicable ?? false)
            {
                FirstPartyPlatform = glfwPlatform;
            }

            if (sdlPlatform.IsApplicable)
            {
                FirstPartyPlatform = sdlPlatform;
            }
        }

        /// <summary>
        /// Gets whether this platform only supports window views. If false, this means that you may use desktop
        /// functionality with your applications.
        /// </summary>
        public static bool IsViewOnly =>
            Platform?.IsViewOnly ?? FirstPartyPlatform?.IsViewOnly ?? throw NoPlatformException;

        /// <summary>
        /// Create a window on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IWindow Create(WindowOptions options)
        {
            if (IsViewOnly)
            {
                throw new NotSupportedException
                (
                    "The currently bound window platform only supports views," +
                    "instead of windows. Use the view APIs instead."
                );
            }

            return Platform?.CreateWindow
                (options) ?? FirstPartyPlatform?.CreateWindow(options) ?? throw NoPlatformException;
        }
        
        /// <summary>
        /// Create a view on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IView GetView(ViewOptions? options = null)
            => Platform?.GetView(options) ?? FirstPartyPlatform?.GetView() ?? throw NoPlatformException;

        /// <summary>
        /// Clears all current contexts for this backend on the current thread.
        /// </summary>
        public static void ClearCurrentContexts()
        {
            if (!(Platform is null))
            {
                Platform.ClearContexts();
            }
            else if (!(FirstPartyPlatform is null))
            {
                FirstPartyPlatform.ClearContexts();
            }
            else
            {
                throw NoPlatformException;
            }
        }

        internal static bool IsUsingGlfw(IView view)
            => !(FirstPartyPlatform is SdlPlatform) &&
               !(FirstPartyPlatform is null) &&
               FirstPartyPlatform.IsSourceOfView(view);
    }
}
