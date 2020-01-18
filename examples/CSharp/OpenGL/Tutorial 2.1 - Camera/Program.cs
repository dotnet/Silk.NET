using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using System;
using System.Drawing;

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

        private static readonly float[] Vertices =
        {
            //X    Y      Z     U   V
             0.5f,  0.5f,  0.5f, 1f, 1f,
             0.5f,  0.5f, -0.5f, 1f, 1f,
             0.5f, -0.5f,  0.5f, 1f, 1f,
             0.5f, -0.5f, -0.0f, 1f, 0f,
            -0.5f,  0.5f,  0.5f, 1f, 1f,
            -0.5f,  0.5f, -0.5f, 1f, 1f,
            -0.5f, -0.5f,  0.5f, 1f, 1f,
            -0.5f, -0.5f, -0.0f, 1f, 0f,
        };

        private static readonly uint[] Indices =
        {
            //Right face
            0, 1, 2,
            1, 2, 3,
            //Left face
            4, 5, 6,
            5, 6, 7,
            //Top face
            0, 1, 4,
            1, 4, 5,
            //Bottom face
            2, 3, 6,
            3, 6, 7,
            //Front face
            0, 2, 4,
            2, 4, 6,
            //Back face
            1, 3, 5,
            3, 5, 7
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
            Gl.Enable(EnableCap.DepthTest);
            
            Ebo = new BufferObject<uint>(Gl, Indices, GLEnum.ElementArrayBuffer);
            Vbo = new BufferObject<float>(Gl, Vertices, GLEnum.ArrayBuffer);
            Vao = new VertexArrayObject<float, uint>(Gl, Vbo, Ebo);

            Vao.VertexAttributePointer(0, 3, GLEnum.Float, 5, 0);
            Vao.VertexAttributePointer(1, 2, GLEnum.Float, 5, 3);

            Shader = new Shader(Gl, "shader.vert", "shader.frag");

            Texture = new Texture(Gl, "silk.png");
        }

        private static void OnRender(double obj)
        {
            Gl.Clear((uint)ClearBufferMask.ColorBufferBit | (uint)ClearBufferMask.DepthBufferBit);

            Vao.Bind();
            Texture.Bind();
            Shader.Use();
            Shader.SetUniform("uTexture0", 0);

            Gl.DrawElements(GLEnum.Triangles, (uint)Indices.Length, GLEnum.UnsignedInt, 0);
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
