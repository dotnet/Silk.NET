// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Numerics;
using Android.App;
using Silk.NET.Input;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl.Android;


namespace AndroidInputDemo
{
    /// <summary>
    /// Simple demo on how to use handle user input with Silk.
    /// </summary>
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : SilkActivity
    {
        // Instead of IWindow, we use IView. 
        // IWindow inherits IView, so you can also use this with your desktop code.
        private static IView view;
        private static GL Gl;

        private static BufferObject<float> Vbo;
        private static VertexArrayObject<float, uint> Vao;
        private static Shader Shader;

        private static int maxPoints = 10000;
        private static float[] Vertices = new float[7 * maxPoints];
        private static Matrix4x4 projection;
        private static int counter = 0;

        private static IInputContext input;

        /// <summary>
        /// This is where the application starts.
        /// Note that when using net6-android, you do not need to have a main method.
        /// </summary>
        protected override void OnRun()
        {
            FileManager.AssetManager = Assets;

            var options = ViewOptions.Default;
            // We need to tell Silk to use OpenGLES
            // Version 3.0 is supported by >90% of devices currently in use.
            // https://developer.android.com/about/dashboards#OpenGL
            options.API = new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Compatability, ContextFlags.Default, new APIVersion(3, 0));
            view = Silk.NET.Windowing.Window.GetView(options);

            view.Load += OnLoad;
            view.Render += OnRender;
            view.Closing += OnClose;
            view.Run();

            view.Dispose();
        }

        private unsafe static void OnLoad()
        {
            Gl = GL.GetApi(view);

            input = view.CreateInput();

            input.Mice[0].MouseMove += MouseMove;
            input.Mice[0].MouseDown += MouseDown;

            input.Keyboards[0].KeyChar += KeyChar;

            Vbo = new BufferObject<float>(Gl, Vertices, BufferTargetARB.ArrayBuffer);
            Vao = new VertexArrayObject<float, uint>(Gl, Vbo, null);

            Vao.VertexAttributePointer(0, 3, VertexAttribPointerType.Float, 7, 0);
            Vao.VertexAttributePointer(1, 4, VertexAttribPointerType.Float, 7, 3);

            Shader = new Shader(Gl, "shader.vert", "shader.frag");
            projection = Matrix4x4.CreateOrthographic(
                view.Size.X,
                -view.Size.Y,
                1.0f, 2.0f);
        }

        private static void KeyChar(IKeyboard arg1, char arg2)
        {
            if (arg2 == 'c')
                Array.Clear(Vertices);
            if (arg2 == 'k')
                input.Keyboards[0].EndInput();
        }

        private static void MouseDown(IMouse arg1, MouseButton arg2)
        {
            // If touched upper 1/3 of the screen
            if(arg1.Position.Y < view.Size.Y / 3)
            {
                // This has to be called to register input, even though keyboard can be opened via other means.
                input.Keyboards[0].BeginInput();
            }
        }

        private static void MouseMove(IMouse arg1, Vector2 arg2)
        {
            // Coordinates need to be transformed from display to be between -1...1
            Vector2 point = Vector2.Transform(arg2, projection) - new Vector2(1, -1);
            Debug.WriteLine(point);
            Vertices[counter++] = point.X;  // x
            Vertices[counter++] = point.Y;  // y
            Vertices[counter++] = 0;        // z
            Vertices[counter++] = point.Y;  // R
            Vertices[counter++] = point.X;  // G
            Vertices[counter++] = 1;        // B
            Vertices[counter++] = 1;        // A
            if (counter >= maxPoints) counter = 0;
        }

        private static unsafe void OnRender(double obj)
        {
            Gl.Clear((uint) ClearBufferMask.ColorBufferBit);
            Gl.Enable(GLEnum.ProgramPointSize);
            Vbo.UpdateBuffer(0, Vertices);
            Vao.Bind();
            Shader.Use();
            Gl.DrawArrays(GLEnum.Points, 0, (uint)Vertices.Length);
        }

        private static void OnClose()
        {
            Vbo.Dispose();
            Vao.Dispose();
            Shader.Dispose();
        }
    }
}