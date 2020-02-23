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
        private static IWindow _window;
        private static GL _gl;

        private static BufferObject<float> _vbo;
        private static BufferObject<uint> _ebo;
        private static VertexArrayObject<float, uint> _vao;
        private static Camera _camera;
        private static Texture _texture;
        private static Shader _shader;

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
        // private static readonly float[] Vertices =
        // {
        //     //X    Y      Z     U   V
        //      0.5f,  0.5f,  0.5f, 1f, 1f,
        //      0.5f,  0.5f, -0.5f, 1f, 1f,
        //      0.5f, -0.5f,  0.5f, 1f, 1f,
        //      0.5f, -0.5f, -0.0f, 1f, 0f,
        //     -0.5f,  0.5f,  0.5f, 1f, 1f,
        //     -0.5f,  0.5f, -0.5f, 1f, 1f,
        //     -0.5f, -0.5f,  0.5f, 1f, 1f,
        //     -0.5f, -0.5f, -0.0f, 1f, 0f,
        // };
        //
        // private static readonly uint[] Indices =
        // {
        //     //Right face
        //     0, 1, 2,
        //     1, 2, 3,
        //     //Left face
        //     4, 5, 6,
        //     5, 6, 7,
        //     //Top face
        //     0, 1, 4,
        //     1, 4, 5,
        //     //Bottom face
        //     2, 3, 6,
        //     3, 6, 7,
        //     //Front face
        //     0, 2, 4,
        //     2, 4, 6,
        //     //Back face
        //     1, 3, 5,
        //     3, 5, 7
        // };


        private static void Main(string[] args)
        {
            var options = WindowOptions.Default;
            options.Size = new Size(800, 600);
            options.Title = "LearnOpenGL with Silk.NET";
            _window = Window.Create(options);

            _window.Load += OnLoad;
            _window.Render += OnRender;
            _window.Closing += OnClose;

            _window.Run();
        }


        private static void OnLoad()
        {
            IInputContext input = _window.GetInput();
            for (int i = 0; i < input.Keyboards.Count; i++)
            {
                input.Keyboards[i].KeyDown += KeyDown;
            }

            _gl = GL.GetApi();
            _gl.Enable(EnableCap.DepthTest);

            _ebo = new BufferObject<uint>(_gl, Indices, GLEnum.ElementArrayBuffer);
            _vbo = new BufferObject<float>(_gl, Vertices, GLEnum.ArrayBuffer);
            _vao = new VertexArrayObject<float, uint>(_gl, _vbo, _ebo);
            _camera = new Camera(Vector3.Zero, (float)_window.Size.Width / _window.Size.Height);

            _vao.VertexAttributePointer(0, 3, GLEnum.Float, 5, 0);
            _vao.VertexAttributePointer(1, 2, GLEnum.Float, 5, 3);

            _shader = new Shader(_gl, "shader.vert", "shader.frag");

            _texture = new Texture(_gl, "silk.png");
        }

        private static void OnRender(double obj)
        {
            _gl.Clear((uint)ClearBufferMask.ColorBufferBit | (uint)ClearBufferMask.DepthBufferBit);

            _vao.Bind();
            _texture.Bind();
            _shader.Use();
            _shader.SetUniform("uTexture0", 0);
            //_shader.SetUniform("uModel", Matrix4x4.Identity);
            _shader.SetUniform("uView", _camera.GetViewMatrix());
            _shader.SetUniform("uPerspective", _camera.GetProjectionMatrix());

            _gl.DrawElements(GLEnum.Triangles, (uint)Indices.Length, GLEnum.UnsignedInt, 0);
        }

        private static void OnClose()
        {
            _vbo.Dispose();
            _ebo.Dispose();
            _vao.Dispose();
            _shader.Dispose();
            _texture.Dispose();
        }

        private static void KeyDown(IKeyboard arg1, Key arg2, int arg3)
        {
            switch (arg2)
            {
                case Key.Escape:
                    _window.Close();
                    break;
                case Key.W:
                    _camera.Position += Vector3.UnitZ;
                    break;
                case Key.S:
                    _camera.Position -= Vector3.UnitZ;
                    break;
                case Key.A:
                    _camera.Position += Vector3.UnitX;
                    break;
                case Key.D:
                    _camera.Position -= Vector3.UnitX;
                    break;
            }
        }
    }
}
