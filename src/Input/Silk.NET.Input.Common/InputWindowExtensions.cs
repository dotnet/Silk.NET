// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input.Common
{
    public static class InputWindowExtensions
    {
        public static void RegisterInputPlatform(IInputPlatform platform)
        {
            throw new NotImplementedException();
        }

        public static void UnregisterInputPlatform(IInputPlatform platform)
        {
            throw new NotImplementedException();
        }

        public static IInputContext GetInput(this IWindow window)
        {
            throw new NotImplementedException();
        }
    }
}