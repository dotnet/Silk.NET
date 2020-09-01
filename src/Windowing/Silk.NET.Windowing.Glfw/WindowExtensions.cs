// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing.Glfw
{
    public static class WindowExtensions
    {
        public static void AddGLFW()
        {
            Window.Add(new GlfwPlatform());
        }
    }
}
