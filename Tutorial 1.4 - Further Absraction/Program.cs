using System;
using System.Drawing;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.OpenGL;
using Silk.NET.OpenGL.Abstactions;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Tutorial
{
    class Program
    {
        static IWindow window;
        static GLObject quad; 
        
        private static readonly float[] Vertices =
         {
            //X    Y      Z
             0.5f,  0.5f, 0.0f,
             0.5f, -0.5f, 0.0f,
            -0.5f, -0.5f, 0.0f,
            -0.5f,  0.5f, 0.5f,
        };

        private static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };
        static void Main(string[] args)
        {
            var options = WindowOptions.Default;
            options.Size = new Size(800, 600);
            options.Title = "LearnOpenGL with Silk.NET";
            window = Window.Create(options);
            quad = new GLObject(GL.GetApi(window), Vertices, Indices);
            window.Load += OnLoad;
            window.Render += OnRender;
            window.Closing += OnClose;

            window.Run();
        }

        private static void OnLoad()
        {
            IInputContext input = window.CreateInput();
            for (int i = 0; i < input.Keyboards.Count; i++)
            {
                input.Keyboards[i].KeyDown += KeyDown;
            }
            quad.CreateResources("shader.vert", "shader.frag");
        }

        private static void OnRender(double obj)
        {
            quad.Render();
        }

        private static void OnClose()
        {
            quad.DisposeResources();
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
