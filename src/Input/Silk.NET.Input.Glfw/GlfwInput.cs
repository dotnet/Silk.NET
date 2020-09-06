// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;

namespace Silk.NET.Input.Glfw
{
    public static class GlfwInput
    {
        public static void RegisterPlatform()
        {
            Window.Add(new GlfwPlatform());
            InputWindowExtensions.Add(new GlfwInputPlatform());
        }
    }
}
