using System;
using System.Drawing;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using Ultz.SilkExtensions.ImGui.OpenGL;

namespace Example.ImGui
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Silk.NET window as usual
            using var window = Window.Create(WindowOptions.Default);
            
            // Declare some variables
            ImGuiController controller = null;
            GL gl = null;
            IInputContext inputContext = null;
            
            // Our loading function
            window.Load += () =>
            {
                controller = new ImGuiController(
                    gl = window.CreateOpenGL(), // load OpenGL
                    window, // pass in our window
                    inputContext = window.CreateInput() // create an input context
                );
            };
            
            // Handle resizes
            window.Resize += s =>
            {
                // Adjust the viewport to the new window size
                gl.Viewport(s);
            };
            
            // The render funciton
            window.Render += delta =>
            {
                // Make sure ImGui is up-to-date
                controller.Update((float) delta);
                
                // This is where you'll do any rendering beneath the ImGui context
                // Here, we just have a blank screen.
                gl.ClearColor(Color.FromArgb(255, 0, 32, 48));
                gl.Clear((uint) (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit |
                                 ClearBufferMask.StencilBufferBit));
                
                // This is where you'll do all of your ImGUi rendering
                // Here, we're just showing the ImGui built-in demo window.
                ImGuiNET.ImGui.ShowDemoWindow();
                
                // Make sure ImGui renders too!
                controller.Render();
            };
            
            // The closing function
            window.Closing += () =>
            {
                // Dispose our controller first
                controller?.Dispose();
                
                // Dispose the input context
                inputContext?.Dispose();
                
                // Unload OpenGL
                gl?.Dispose();
            };
            
            // Now that everything's defined, let's run this bad boy!
            window.Run();
        }
    }
}