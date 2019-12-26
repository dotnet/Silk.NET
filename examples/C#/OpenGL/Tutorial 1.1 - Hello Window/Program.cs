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
            //Create a window.
            window = new GlfwWindow(new WindowOptions()
                { Size = new System.Drawing.Size(800, 600),
                Title = "LearnOpenGL with Silk.NET" });

            //Assign events.
            window.Load += OnLoad;

            //Run the window.
            window.Run();
        }

        private static void OnLoad()
        {
            //Set-up input context.
            IInputContext input = window.GetInput();
            for (int i = 0; i < input.Keyboards.Count; i++)
            {
                input.Keyboards[0].KeyDown += KeyDown;
            }
        }

        private static void KeyDown(IKeyboard arg1, Key arg2, int arg3)
        {
            //Check to close the window on escape.
            if (arg2 == Key.Escape)
            {
                window.Close();
            }
        }
    }
}
