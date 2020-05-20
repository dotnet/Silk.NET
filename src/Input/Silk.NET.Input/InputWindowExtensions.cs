// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Silk.NET.Input.Common;
using Silk.NET.Input.Glfw;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input
{
    /// <summary>
    /// Extensions related to input contexts and windows.
    /// </summary>
    public static class InputWindowExtensions
    {
        public static event CustomInputContextCreationCallback ContextCreation;
        
        /// <summary>
        /// Get an input context for the given window.
        /// </summary>
        /// <param name="window">The window to create an input context for.</param>
        /// <returns>An input context for the provided window.</returns>
        public static IInputContext CreateInput(this IView view)
        {
            if (Window.IsUsingGlfw(view))
            {
                return new GlfwInputContext(view);
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