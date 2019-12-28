using System.Drawing;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Tutorial
{
    class Program
    {
        private static IWindow window;

        private static void Main(string[] args)
        {
            //Create a window.
            var options = WindowOptions.Default;
            options.Size = new Size(800, 600);
            options.Title = "LearnOpenGL with Silk.NET";
            window = Window.Create(options);
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
