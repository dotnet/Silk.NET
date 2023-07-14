using Silk.NET.Input;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using System;
using System.Linq;
using System.Numerics;
using Silk.NET.Maths;

namespace Tutorial
{
    class Program
    {
        private static IWindow window;
        private static GL Gl;
        private static IKeyboard primaryKeyboard;

        private static Texture Texture;
        private static Shader Shader;
        private static Model Model;

        //Setup the camera's location, directions, and movement speed
        private static Vector3 CameraPosition = new Vector3(0.0f, 0.0f, 3.0f);
        private static Vector3 CameraFront = new Vector3(0.0f, 0.0f, -1.0f);
        private static Vector3 CameraUp = Vector3.UnitY;
        private static Vector3 CameraDirection = Vector3.Zero;
        private static float CameraYaw = -90f;
        private static float CameraPitch = 0f;
        private static float CameraZoom = 45f;

        //Used to track change in mouse movement to allow for moving of the Camera
        private static Vector2 LastMousePosition;

        private static void Main(string[] args)
        {
            var options = WindowOptions.Default;
            options.Size = new Vector2D<int>(800, 600);
            options.Title = "LearnOpenGL with Silk.NET";
            window = Window.Create(options);

            window.Load += OnLoad;
            window.Update += OnUpdate;
            window.Render += OnRender;
            window.Closing += OnClose;

            window.Run();

            window.Dispose();
        }

        private static void OnLoad()
        {
            IInputContext input = window.CreateInput();
            primaryKeyboard = input.Keyboards.FirstOrDefault();
            if (primaryKeyboard != null)
            {
                primaryKeyboard.KeyDown += KeyDown;
            }
            for (int i = 0; i < input.Mice.Count; i++)
            {
                input.Mice[i].Cursor.CursorMode = CursorMode.Raw;
                input.Mice[i].MouseMove += OnMouseMove;
                input.Mice[i].Scroll += OnMouseWheel;
            }

            Gl = GL.GetApi(window);

            Shader = new Shader(Gl, "shader.vert", "shader.frag");
            Texture = new Texture(Gl, "silk.png");
            Model = new Model(Gl, "cube.model");
        }

        private static unsafe void OnUpdate(double deltaTime)
        {
            var moveSpeed = 2.5f * (float) deltaTime;

            if (primaryKeyboard.IsKeyPressed(Key.W))
            {
                //Move forwards
                CameraPosition += moveSpeed * CameraFront;
            }
            if (primaryKeyboard.IsKeyPressed(Key.S))
            {
                //Move backwards
                CameraPosition -= moveSpeed * CameraFront;
            }
            if (primaryKeyboard.IsKeyPressed(Key.A))
            {
                //Move left
                CameraPosition -= Vector3.Normalize(Vector3.Cross(CameraFront, CameraUp)) * moveSpeed;
            }
            if (primaryKeyboard.IsKeyPressed(Key.D))
            {
                //Move right
                CameraPosition += Vector3.Normalize(Vector3.Cross(CameraFront, CameraUp)) * moveSpeed;
            }
        }

        private static unsafe void OnRender(double deltaTime)
        {
            Gl.Enable(EnableCap.DepthTest);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Texture.Bind();
            Shader.Use();
            Shader.SetUniform("uTexture0", 0);

            //Use elapsed time to convert to radians to allow our cube to rotate over time
            var difference = (float) (window.Time * 100);

            var model = Matrix4x4.CreateRotationY(MathHelper.DegreesToRadians(difference)) * Matrix4x4.CreateRotationX(MathHelper.DegreesToRadians(difference));
            var view = Matrix4x4.CreateLookAt(CameraPosition, CameraPosition + CameraFront, CameraUp);
            //It's super important for the width / height calculation to regard each value as a float, otherwise
            //it creates rounding errors that result in viewport distortion
            var projection = Matrix4x4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(CameraZoom), (float) window.Size.X / (float)window.Size.Y, 0.1f, 100.0f);

            foreach (var mesh in Model.Meshes)
            {
                mesh.Bind();
                Shader.Use();
                Texture.Bind();
                Shader.SetUniform("uTexture0", 0);
                Shader.SetUniform("uModel", model);
                Shader.SetUniform("uView", view);
                Shader.SetUniform("uProjection", projection);

                Gl.DrawArrays(PrimitiveType.Triangles, 0, (uint)mesh.Vertices.Length);
            }
        }

        private static unsafe void OnMouseMove(IMouse mouse, Vector2 position)
        {
            var lookSensitivity = 0.1f;
            if (LastMousePosition == default)
            {
                LastMousePosition = position;
            }
            else
            {
                var xOffset = (position.X - LastMousePosition.X) * lookSensitivity;
                var yOffset = (position.Y - LastMousePosition.Y) * lookSensitivity;
                LastMousePosition = position;

                CameraYaw += xOffset;
                CameraPitch -= yOffset;

                //We don't want to be able to look behind us by going over our head or under our feet so make sure it stays within these bounds
                CameraPitch = Math.Clamp(CameraPitch, -89.0f, 89.0f);

                CameraDirection.X = MathF.Cos(MathHelper.DegreesToRadians(CameraYaw)) * MathF.Cos(MathHelper.DegreesToRadians(CameraPitch));
                CameraDirection.Y = MathF.Sin(MathHelper.DegreesToRadians(CameraPitch));
                CameraDirection.Z = MathF.Sin(MathHelper.DegreesToRadians(CameraYaw)) * MathF.Cos(MathHelper.DegreesToRadians(CameraPitch));
                CameraFront = Vector3.Normalize(CameraDirection);
            }
        }

        private static unsafe void OnMouseWheel(IMouse mouse, ScrollWheel scrollWheel)
        {
            //We don't want to be able to zoom in too close or too far away so clamp to these values
            CameraZoom = Math.Clamp(CameraZoom - scrollWheel.Y, 1.0f, 45f);
        }

        private static void OnClose()
        {
            Model.Dispose();
            Shader.Dispose();
            Texture.Dispose();
        }

        private static void KeyDown(IKeyboard keyboard, Key key, int arg3)
        {
            if (key == Key.Escape)
            {
                window.Close();
            }
        }
    }
}
