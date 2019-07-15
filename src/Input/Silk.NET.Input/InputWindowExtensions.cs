// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input
{
    public static class InputWindowExtensions
    {
        private static List<IInputPlatform> _platforms = new List<IInputPlatform>();
        static InputWindowExtensions()
        {
            RegisterInputPlatform(new GlfwInputPlatform());
        }
        public static void RegisterInputPlatform(IInputPlatform platform)
        {
            _platforms.Add(platform);
        }

        public static void UnregisterInputPlatform(IInputPlatform platform)
        {
            _platforms.Remove(platform);
        }

        public static IInputContext GetInput(this IWindow window)
        {
            return _platforms.FirstOrDefault(x => x.IsApplicable(window))?.GetInput(window) 
                ?? throw new NotSupportedException("Couldn't find a suitable input platform for this window.");
        }
    }
}