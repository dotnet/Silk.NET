// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Platform;
using Silk.NET.Windowing.Common;

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
            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
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
#if NETSTANDARD
            var glfwPlatform = new Windowing.Desktop.GlfwPlatform();
            if (glfwPlatform.IsApplicable) {
                SilkManager.Register<IWindowPlatform>(glfwPlatform);
                return;
            }
#elif XAMARIN_ANDROID
            var androidPlatform = new Windowing.Android.AndroidPlatform();
            if (androidPlatform.IsApplicable)
            {
                SilkManager.Register<IWindowPlatform>(androidPlatform);
            }
#endif
            if (!SilkManager.IsRegistered<IWindowPlatform>())
            {
                throw new NotSupportedException("Couldn't find a suitable windowing platform.");
            }
        }

#if XAMARIN_ANDROID
        /// <summary>
        /// Attempts to resolve an <see cref="IWindowPlatform"/> equipped to use the given <see cref="Activity"/>
        /// </summary>
        /// <param name="activity">The activity to use.</param>
        public static void Init(global::Android.App.Activity activity)
        {
            Android.AndroidPlatform.Activity = activity;
            Init();
        }
#endif
    }
}
