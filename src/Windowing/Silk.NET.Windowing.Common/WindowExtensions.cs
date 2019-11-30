// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Extensions for IWindow
    /// </summary>
    public static class WindowExtensions
    {
        /// <summary>
        /// Executes a Func&lt;T&gt; delegate on the given window.
        /// </summary>
        /// <param name="window">The window to invoke on.</param>
        /// <param name="t">The function to invoke.</param>
        /// <typeparam name="T">Type of the function.</typeparam>
        /// <remarks>This function is not applicable on single-threaded windows</remarks>
        /// <returns>The return value of the given delegate.</returns>
        public static T Invoke<T>(this IWindow window, Func<T> t)
        {
            return (T) window.Invoke(t);
        }

        /// <summary>
        /// Executes an <see cref="Action"/> on the given window.
        /// </summary>
        /// <param name="window">The window to invoke on.</param>
        /// <param name="t">The action to invoke.</param>
        /// <remarks>This function is not applicable on single-threaded windows</remarks>
        public static void Invoke(this IWindow window, Action t)
        {
            window.Invoke(t);
        }

        /// <summary>
        /// Start the default event loop on this window.
        /// </summary>
        /// <param name="window">The window to begin the loop on.</param>
        public static void Run(this IWindow window)
        {
            window.Open();
            while (!window.IsClosing)
            {
                window.DoEvents();
                window.DoUpdate();
                window.DoRender();
            }
            window.Reset();
        }
    }
}
