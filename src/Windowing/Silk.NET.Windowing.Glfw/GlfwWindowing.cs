// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.GLFW;

namespace Silk.NET.Windowing.Glfw
{
    public static class GlfwWindowing
    {
        public static void RegisterPlatform()
        {
            Window.Add(new GlfwPlatform());
        }

        /// <summary>
        /// Prioritizes the GLFW windowing platform over others.
        /// </summary>
        public static void Use() => Window.PrioritizeGlfw();

        /// <summary>
        /// Gets a value indicating whether the given view is a GLFW view.
        /// </summary>
        /// <returns>Whether the given view is a GLFW view.</returns>
        public static bool IsViewGlfw(IView view) => view is GlfwWindow;

        public static GLFW.Glfw? GetExistingApi(IView view) => (view as GlfwWindow)?._glfw;

        public static unsafe WindowHandle* GetHandle(IView view)
            => view is GlfwWindow glfwWindow ? glfwWindow._glfwWindow : null;
    }
}
