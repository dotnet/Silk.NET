// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    public static class WindowExtensions
    {
        public static T Invoke<T>(this IWindow window, Func<T> t)
        {
            return (T) window.Invoke(t);
        }

        public static void Invoke(this IWindow window, Action t)
        {
            window.Invoke(t);
        }

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
