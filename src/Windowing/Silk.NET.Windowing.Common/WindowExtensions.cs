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
        /// Executes a Func&lt;T&gt; delegate on the given view.
        /// </summary>
        /// <param name="view">The view to invoke on.</param>
        /// <param name="t">The function to invoke.</param>
        /// <typeparam name="T">Type of the function.</typeparam>
        /// <remarks>This function is not applicable on single-threaded windows</remarks>
        /// <returns>The return value of the given delegate.</returns>
        public static T Invoke<T>(this IView view, Func<T> t)
        {
            return (T) view.Invoke(t);
        }

        /// <summary>
        /// Executes an <see cref="Action"/> on the given view.
        /// </summary>
        /// <param name="view">The view to invoke on.</param>
        /// <param name="t">The action to invoke.</param>
        /// <remarks>This function is not applicable on single-threaded windows</remarks>
        public static void Invoke(this IView view, Action t)
        {
            view.Invoke(t);
        }

        /// <summary>
        /// Start the default event loop on this view.
        /// </summary>
        /// <param name="view">The view to begin the loop on.</param>
        public static void Run(this IView view)
        {
            view.Initialize();
            while (!view.IsClosing)
            {
                view.DoEvents();
                view.DoUpdate();
                view.DoRender();
            }
            view.DoEvents();
            view.Reset();
        }
    }
}
