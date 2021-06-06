// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using OpenGL_VR_Demo.OpenXR;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.OpenXR;
using Shader = Silk.NET.OpenGL.Shader;

namespace OpenGL_VR_Demo
{
    public class Game : OpenGLXRGame
    {
        private static GL Gl;

        private static BufferObject<float> Vbo;
        private static BufferObject<uint> Ebo;
        private static VertexArrayObject<float, uint> VaoCube;
        private static Shader LightingShader;
        private static Shader LampShader;
        private static Vector3 CubePosition = new(0.2f, 0.0f, 1.0f);
        private static Vector3 LampPosition = new(1.2f, 1.0f, 2.0f);

        private static Camera Camera;
        private static Vector2 LastOrientation;

        private static readonly float[] Vertices =
        {
            //X    Y      Z       Normals
            -0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,
             0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,
             0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,
             0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,
            -0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,

            -0.5f, -0.5f,  0.5f,  0.0f,  0.0f,  1.0f,
             0.5f, -0.5f,  0.5f,  0.0f,  0.0f,  1.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  0.0f,  1.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  0.0f,  1.0f,
            -0.5f,  0.5f,  0.5f,  0.0f,  0.0f,  1.0f,
            -0.5f, -0.5f,  0.5f,  0.0f,  0.0f,  1.0f,

            -0.5f,  0.5f,  0.5f, -1.0f,  0.0f,  0.0f,
            -0.5f,  0.5f, -0.5f, -1.0f,  0.0f,  0.0f,
            -0.5f, -0.5f, -0.5f, -1.0f,  0.0f,  0.0f,
            -0.5f, -0.5f, -0.5f, -1.0f,  0.0f,  0.0f,
            -0.5f, -0.5f,  0.5f, -1.0f,  0.0f,  0.0f,
            -0.5f,  0.5f,  0.5f, -1.0f,  0.0f,  0.0f,

             0.5f,  0.5f,  0.5f,  1.0f,  0.0f,  0.0f,
             0.5f,  0.5f, -0.5f,  1.0f,  0.0f,  0.0f,
             0.5f, -0.5f, -0.5f,  1.0f,  0.0f,  0.0f,
             0.5f, -0.5f, -0.5f,  1.0f,  0.0f,  0.0f,
             0.5f, -0.5f,  0.5f,  1.0f,  0.0f,  0.0f,
             0.5f,  0.5f,  0.5f,  1.0f,  0.0f,  0.0f,

            -0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,
             0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,
             0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,
             0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,

            -0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,
             0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,
            -0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,
            -0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f
        };

        private static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };

        
        public Game(bool forceNoDebug = false, bool useMinimumVersion = false)
                : base("OpenGL VR Demo", forceNoDebug, useMinimumVersion)
        {
        }

        protected override void Load()
        {
            Gl = Renderer!.Gl;
            
            Ebo = new(Gl, Indices, BufferTargetARB.ElementArrayBuffer);
            Vbo = new(Gl, Vertices, BufferTargetARB.ArrayBuffer);
            VaoCube = new(Gl, Vbo, Ebo);

            VaoCube.VertexAttributePointer(0, 3, VertexAttribPointerType.Float, 6, 0);
            VaoCube.VertexAttributePointer(1, 3, VertexAttribPointerType.Float, 6, 3);

            //The lighting shader will give our main cube it's colour multiplied by the light's intensity
            LightingShader = new(Gl, "shader.vert", "lighting.frag");
            //The Lamp shader uses a fragment shader that just colours it solid white so that we know it is the light source
            LampShader = new(Gl, "shader.vert", "shader.frag");

            //Start a camera at position 3 on the Z axis, looking at position -1 on the Z axis
            Camera = new(Vector3.UnitZ * 6 * 6, Renderer);
        }

        protected override void Update(double delta)
        {
            var moveSpeed = 2.5f * (float) delta;
            // TODO add OpenXR controller input handling
        }

        protected override void Render(int eye, double delta)
        {
            Gl.Enable(EnableCap.DepthTest);
            Gl.Clear((uint) (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));

            VaoCube.Bind();
            LightingShader.Use();
            
            // Define the matrix for our cube
            var cubeMatrix = Matrix4x4.Identity;
            cubeMatrix *= Matrix4x4.CreateTranslation(CubePosition);

            // Slightly rotate the cube to give it an angled face to look at
            cubeMatrix *= Matrix4x4.CreateRotationY(Scalar.DegreesToRadians(25f));
            
            //LightingShader.SetUniform("uModel", Matrix4x4.CreateRotationY(MathHelper.DegreesToRadians(25f)));
            LightingShader.SetUniform("uModel", cubeMatrix);
            LightingShader.SetUniform("uView", Camera.GetViewMatrix(eye));
            LightingShader.SetUniform("uProjection", Camera.GetProjectionMatrix(eye));
            LightingShader.SetUniform("objectColor", new Vector3(1.0f, 0.5f, 0.31f));
            LightingShader.SetUniform("lightColor", Vector3.One);
            LightingShader.SetUniform("lightPos", LampPosition);
            LightingShader.SetUniform("viewPos", Camera.Position);

            // We're drawing with just vertices and no indicies, and it takes 36 verticies to have a six-sided textured cube
            Gl.DrawArrays(PrimitiveType.Triangles, 0, 36);

            LampShader.Use();

            //The Lamp cube is going to be a scaled down version of the normal cubes verticies moved to a different screen location
            var lampMatrix = Matrix4x4.Identity;
            lampMatrix *= Matrix4x4.CreateScale(0.2f);
            lampMatrix *= Matrix4x4.CreateTranslation(LampPosition);

            LampShader.SetUniform("uModel", lampMatrix);
            LampShader.SetUniform("uView", Camera.GetViewMatrix(eye));
            LampShader.SetUniform("uProjection", Camera.GetProjectionMatrix(eye));

            Gl.DrawArrays(PrimitiveType.Triangles, 0, 36);
        }

        protected override void Unload()
        {
            Vbo.Dispose();
            Ebo.Dispose();
            VaoCube.Dispose();
            LightingShader.Dispose();
        }
    }
}
