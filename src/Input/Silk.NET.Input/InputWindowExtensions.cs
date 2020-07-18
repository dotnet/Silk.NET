// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using System.Reflection;
using Silk.NET.Input.Common;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input
{
    /// <summary>
    /// Extensions related to input contexts and windows.
    /// </summary>
    public static class InputWindowExtensions
    {
        private static IInputPlatform? _glfwPlatform;
        private const string GlfwBackendAssembly = "Silk.NET.Input.GlfwBackend";
        private const string GlfwBackendType = "Silk.NET.Input.GlfwBackend.GlfwInputPlatform";
        public static event CustomInputContextCreationCallback ContextCreation;

        static InputWindowExtensions()
        {
            try
            {
                var glfwBackendAssembly = Assembly.Load(GlfwBackendAssembly);
                var glfwPlatformType = glfwBackendAssembly.GetType(GlfwBackendType);
                _glfwPlatform = Activator.CreateInstance(glfwPlatformType, true) as IInputPlatform;
            }
            catch
            {
                // do nothing, just means there's no GLFW available.
            }
        }
        
        /// <summary>
        /// Get an input context for the given window.
        /// </summary>
        /// <param name="view">The window to create an input context for.</param>
        /// <returns>An input context for the provided window.</returns>
        public static IInputContext CreateInput(this IView view)
        {
            if (Window.IsUsingGlfw(view))
            {
                if (_glfwPlatform is null)
                {
                    throw new InvalidOperationException
                    (
                        "Attempted to create a GLFW-powered input context without " +
                        "the Silk.NET.Input.GlfwBackend package installed."
                    );
                }

                if (_glfwPlatform.IsApplicable(view))
                {
                    return _glfwPlatform.CreateInput(view);
                }
            }
            
            // TODO SDL
            
            foreach (var @delegate in ContextCreation?.GetInvocationList() ?? Enumerable.Empty<Delegate>())
            {
                if (((CustomInputContextCreationCallback) @delegate)(view, out var context))
                {
                    return context;
                }
            }
            
            throw new NotSupportedException("Couldn't find a suitable input platform for this view.");
        }
    }
}