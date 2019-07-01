// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Contains properties and methods for resolving a window creation API.
    /// </summary>
    public static class Silk
    {
        /// <summary>
        /// Gets or sets the current windowing platform.
        /// </summary>
        public static ISilkPlatform CurrentPlatform { get; set; }

        /// <summary>
        /// Reflects over the current AppDomain in an attempt to resolve an <see cref="ISilkPlatform" />.
        /// </summary>
        /// <exception cref="NotSupportedException">Thrown f no applicable <see cref="ISilkPlatform" /> was found.</exception>
        public static void Init()
        {
            var glfwPlatform = new GlfwPlatform();
            if (glfwPlatform.IsApplicable) {
                CurrentPlatform = glfwPlatform;
                return;
            }

            // TODO: Mobile

            if (CurrentPlatform == null) {
                throw new NotSupportedException("Couldn't find a suitable windowing platform.");
            }
        }
    }
}