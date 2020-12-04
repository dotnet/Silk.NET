// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Platform;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input
{
    /// <summary>
    /// Extensions related to input contexts and windows.
    /// </summary>
    public static class InputWindowExtensions
    {
        static InputWindowExtensions()
        {
            SilkManager.Register<IInputPlatform>(GlfwInputPlatform.Instance);
        }

        /// <summary>
        /// Get an input context for the given window.
        /// </summary>
        /// <param name="window">The window to create an input context for.</param>
        /// <returns>An input context for the provided window.</returns>
        public static IInputContext CreateInput(this IView view)
        {
            return SilkManager.GetOrDefault<IInputPlatform>()?.CreateInput(view)
                ?? throw new NotSupportedException("Couldn't find a suitable input platform for this view.");
        }
    }
}