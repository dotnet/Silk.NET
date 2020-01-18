using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using System;
using System.Drawing;
using System.Numerics;

namespace Tutorial
{
    class Program
    {
        private static IWindow window;
        private static GL Gl;

        private static BufferObject<float> Vbo;
        private static BufferObject<uint> Ebo;
        private static VertexArrayObject<float, uint> Vao;
        private static Texture Texture;
        private static Shader Shader;
        //Creating matrix transformations
        private static Matrix4x4[] Matrices = new Matrix4x4[3];

        private static readonly float[] Vertices =
        {
            //X    Y      Z     U   V
             0.5f,  0.5f, 0.0f, 1f, 1f,
             0.5f, -0.5f, 0.0f, 1f, 0f,
            -0.5f, -0.5f, 0.0f, 0f, 0f,
            -0.5f,  0.5f, 0.5f, 0f, 1f
        };

        private static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };


        private static void Main(string[] args)
        {
            var options = WindowOptions.Default;
            options.Size = new Size(800, 600);
            options.Title = "LearnOpenGL with Silk.NET";
            window = Window.Create(options);

            window.Load += OnLoad;
            window.Render += OnRender;
            window.Closing += OnClose;

            window.Run();
        }


        private unsafe static void OnLoad()
        {
            IInputContext input = window.GetInput();
            for (int i = 0; i < input.Keyboards.Count; i++)
            {
                input.Keyboards[i].KeyDown += KeyDown;
            }

            Gl = GL.GetApi();
            
            Ebo = new BufferObject<uint>(Gl, Indices, GLEnum.ElementArrayBuffer);
            Vbo = new BufferObject<float>(Gl, Vertices, GLEnum.ArrayBuffer);
            Vao = new VertexArrayObject<float, uint>(Gl, Vbo, Ebo);

            Vao.VertexAttributePointer(0, 3, GLEnum.Float, 5, 0);
            Vao.VertexAttributePointer(1, 2, GLEnum.Float, 5, 3);

            Shader = new Shader(Gl, "shader.vert", "shader.frag");

            Texture = new Texture(Gl, "silk.png");

            //Scaling.
            Matrices[0] *= Matrix4x4.CreateScale(0.5f);
            //Translation.
            Matrices[1] *= Matrix4x4.CreateTranslation(0.5f, 0.5f, 0.5f);
            //Rotation.
            Matrices[2] *= Matrix4x4.CreateRotationZ(1);
        }

        private static void OnRender(double obj)
        {
            Gl.Clear((uint)ClearBufferMask.ColorBufferBit);

            Vao.Bind();
            Texture.Bind();
            Shader.Use();
            Shader.SetUniform("uTexture0", 0);

            for (int i = 0; i < Matrices.Length; i++)
            {
                Shader.SetUniform("uModel", Matrices[i]);
                Gl.DrawElements(GLEnum.Triangles, (uint)Indices.Length, GLEnum.UnsignedInt, 0);
            }
        }

        private static void OnClose()
        {
            Vbo.Dispose();
            Ebo.Dispose();
            Vao.Dispose();
            Shader.Dispose();
            Texture.Dispose();
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
