// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing.Glfw
{
    public static class GlfwWindowing
    {
        public static void RegisterPlatform()
        {
            Window.Add(new GlfwPlatform());
        }
    }
}
