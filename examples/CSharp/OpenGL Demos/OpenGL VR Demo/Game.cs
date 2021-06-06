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
        private static Shader CubesShader;
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

            CubesShader = new(Gl, "cubes.vert", "cubes.frag");

            //Start a camera at position 3 on the Z axis, looking at position -1 on the Z axis
            Camera = new(Vector3.One + Vector3.One, Renderer);
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
            CubesShader.Use();
            
            CubesShader.SetUniform("uniformColor", Vector3.Zero);
            CubesShader.SetUniform("view", Matrix4x4.Transpose(Camera.GetViewMatrix(eye)));
            CubesShader.SetUniform("proj", Matrix4x4.Transpose(Camera.GetProjectionMatrix(eye)));

            const float rotations_per_sec = .25f;

            float angle = ((long)(delta * 360f * rotations_per_sec)) % 360f;

            float dist = 1.5f;
            float height = 0.5f;
            DrawRotatedCube(new(0, height, -dist), .33f, angle);
            DrawRotatedCube(new(0, height, dist), .33f, angle);
            DrawRotatedCube(new(dist, height, 0), .33f, angle);
            DrawRotatedCube(new(-dist, height, 0), .33f, angle);
        }

        private void DrawRotatedCube(Vector3 position, float cube_size, float rotation)
        {
	        var modelmatrix = Matrix4x4.CreateTranslation(position)
                              * Matrix4x4.CreateScale(new Vector3(cube_size / 2f, cube_size / 2f, cube_size / 2f));
	        modelmatrix *= Matrix4x4.CreateRotationY(Scalar.DegreesToRadians(rotation));
            CubesShader.SetUniform("model", Matrix4x4.Transpose(modelmatrix));  
	        Gl.DrawArrays(GLEnum.Triangles, 0, 36);
        }

        protected override void Unload()
        {
            Vbo.Dispose();
            Ebo.Dispose();
            VaoCube.Dispose();
            CubesShader.Dispose();
        }
    }
}
