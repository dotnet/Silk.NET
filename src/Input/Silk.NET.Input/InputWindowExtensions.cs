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
    public static class InputWindowExtensions
    {
        static InputWindowExtensions()
        {
            SilkManager.Register<IInputPlatform>(GlfwInputPlatform.Instance);
        }
        public static IInputContext CreateInput(this IView view)
        {
            return SilkManager.GetOrDefault<IInputPlatform>()?.CreateInput(view)
                ?? throw new NotSupportedException("Couldn't find a suitable input platform for this view.");
        }
    }
}