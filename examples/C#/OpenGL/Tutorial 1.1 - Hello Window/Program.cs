using System;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Tutorial
{
    class Program
    {
        private static GlfwWindow window;

        private static void Main(string[] args)
        {
            GlfwWindow window = new GlfwWindow(new WindowOptions()
                { Size = new System.Drawing.Size(800, 600),
                Title = "LearnOpenGL with Silk.NET" });

            window.Load += OnLoad;

            window.Run();
        }

        private static void OnLoad()
        {
            IInputContext input = window.GetInput();
            for (int i = 0; i < input.Keyboards.Count; i++)
            {
                input.Keyboards[0].KeyDown += KeyDown;
            }
        }

        private static void KeyDown(IKeyboard arg1, Key arg2, int arg3)
        {
            if (arg2 == Key.Escape)
            {
                window.Close();
            }
        }
    }
}
