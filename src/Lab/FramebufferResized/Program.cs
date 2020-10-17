using System;
using System.Diagnostics.CodeAnalysis;
using Silk.NET.GLFW;

namespace FramebufferResized
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            var glfw = Glfw.GetApi();
            glfw.Init();

            glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
            var windowHandle = glfw.CreateWindow(800, 600, "resize me to trigger the callback", null, null);

            glfw.SetFramebufferSizeCallback(windowHandle, FramebufferResize);

            while (!glfw.WindowShouldClose(windowHandle))
            {
                glfw.PollEvents();
            }

            glfw.DestroyWindow(windowHandle);
        }
        private static unsafe void FramebufferResize(WindowHandle* window, int width, int height)
        {
            Console.WriteLine($"framebuffer size: {width}, {height}");
        }
    }
}
