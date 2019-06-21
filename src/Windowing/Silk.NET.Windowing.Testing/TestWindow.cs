using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Windowing.Testing
{
    public class TestWindow : GlfwWindow
    {
        public TestWindow(WindowOptions options) : base(options)
        {
            
        }

        public override void OnUpdate(double delta)
        {
            Console.WriteLine("{0}", delta);
        }
    }
}