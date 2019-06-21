using System;
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