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
        }

        public override void OnFileDrop(string[] files)
        {
            foreach (var file in files) {
                Console.WriteLine(file);
            }
        }
    }
}