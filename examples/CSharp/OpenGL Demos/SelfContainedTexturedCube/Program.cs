// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace SelfContainedTexturedCube;

public class Program
{
    private static IWindow _window;
    private static GL _gl;
    
    private static uint _vao;
    private static uint _vbo;
    private static uint _ebo;
    
    private static uint _cameraInfoBuffer;
    private static uint _modelMatrixBuffer;

    private static uint _program;

    private static uint _texture;

    private static Quaternion _rotation;
    
    public static void Main(string[] args)
    {
        WindowOptions options = WindowOptions.Default with
        {
            Title = "Self Contained Textured Cube Demo",
            Size = new Vector2D<int>(1280, 720),
            API = new GraphicsAPI(ContextAPI.OpenGL, ContextProfile.Core, ContextFlags.Default, new APIVersion(4, 3))
        };

        _window = Window.Create(options);
        _window.Load += Initialize;
        _window.Update += Update;
        _window.Render += Draw;
        
        _window.Run();
        
        _window.Dispose();
    }

    private static unsafe void Initialize()
    {
        _gl = _window.CreateOpenGL();

        _gl.ClearColor(Color.Indigo);

        _vao = _gl.GenVertexArray();
        _gl.BindVertexArray(_vao);

        Cube cube = new Cube();

        _vbo = _gl.GenBuffer();
        _ebo = _gl.GenBuffer();
        
        _gl.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);
        _gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, _ebo);

        fixed (VertexPositionTexture* vertices = cube.Vertices)
            _gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) (cube.Vertices.Length * sizeof(VertexPositionTexture)), vertices, BufferUsageARB.StaticDraw);

        fixed (uint* indices = cube.Indices)
            _gl.BufferData(BufferTargetARB.ElementArrayBuffer, (nuint) (cube.Indices.Length * sizeof(uint)), indices, BufferUsageARB.StaticDraw);

        CameraInfo camera = new CameraInfo()
        {
            ProjectionMatrix = Matrix4x4.CreatePerspectiveFieldOfView(75 * MathF.PI / 180, _window.Size.X / (float) _window.Size.Y, 0.1f, 100f),
            ViewMatrix = Matrix4x4.CreateLookAt(new Vector3(0, -3, 0), Vector3.Zero, Vector3.UnitX)
        };

        _cameraInfoBuffer = _gl.GenBuffer();
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, _cameraInfoBuffer);
        _gl.BufferData(BufferTargetARB.UniformBuffer, (nuint) sizeof(CameraInfo), &camera, BufferUsageARB.StaticDraw);

        Matrix4x4 modelMatrix = Matrix4x4.Identity;

        _modelMatrixBuffer = _gl.GenBuffer();
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, _modelMatrixBuffer);
        _gl.BufferData(BufferTargetARB.UniformBuffer, (nuint) sizeof(Matrix4x4), &modelMatrix, BufferUsageARB.DynamicDraw);

        _gl.BindBuffer(BufferTargetARB.UniformBuffer, 0);

        uint vertexShader = CreateShader(ShaderType.VertexShader, File.ReadAllText("Content/Cube.vert"));
        uint fragmentShader = CreateShader(ShaderType.FragmentShader, File.ReadAllText("Content/Cube.frag"));

        _program = _gl.CreateProgram();
        _gl.AttachShader(_program, vertexShader);
        _gl.AttachShader(_program, fragmentShader);
        _gl.LinkProgram(_program);

        _gl.GetProgram(_program, ProgramPropertyARB.LinkStatus, out int status);
        if (status != (int) GLEnum.True)
            throw new Exception($"Failed to link program! {_gl.GetProgramInfoLog(_program)}");

        _gl.DetachShader(_program, vertexShader);
        _gl.DetachShader(_program, fragmentShader);
        _gl.DeleteShader(vertexShader);
        _gl.DeleteShader(fragmentShader);

        _gl.UseProgram(_program);

        const uint positionAttribLocation = 0;
        _gl.EnableVertexAttribArray(positionAttribLocation);
        _gl.VertexAttribPointer(positionAttribLocation, 3, VertexAttribPointerType.Float, false, (uint) sizeof(VertexPositionTexture), (void*) 0);

        const uint texCoordAttribLocation = 1;
        _gl.EnableVertexAttribArray(texCoordAttribLocation);
        _gl.VertexAttribPointer(texCoordAttribLocation, 2, VertexAttribPointerType.Float, false, (uint) sizeof(VertexPositionTexture), (void*) 12);

        _gl.BindVertexArray(0);
        _gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
        _gl.BindBuffer(GLEnum.ElementArrayBuffer, 0);
        
        _rotation = Quaternion.Identity;
    }

    private static void Update(double dt)
    {
        _rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitY, 1 * (float) dt) *
                     Quaternion.CreateFromAxisAngle(Vector3.UnitX, 1f * (float) dt);
    }

    private static unsafe void Draw(double dt)
    {
        Matrix4x4 modelMatrix = Matrix4x4.CreateFromQuaternion(_rotation);
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, _modelMatrixBuffer);
        _gl.BufferSubData(BufferTargetARB.UniformBuffer, 0, (nuint) sizeof(Matrix4x4), &modelMatrix);
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, 0);
        
        _gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        _gl.BindVertexArray(_vao);
        _gl.UseProgram(_program);

        _gl.BindBufferBase(BufferTargetARB.UniformBuffer, 0, _cameraInfoBuffer);
        _gl.BindBufferBase(BufferTargetARB.UniformBuffer, 1, _modelMatrixBuffer);
        
        _gl.DrawElements(PrimitiveType.Triangles, 36, DrawElementsType.UnsignedInt, null);
    }

    private static uint CreateShader(ShaderType type, string source)
    {
        uint shader = _gl.CreateShader(type);
        _gl.ShaderSource(shader, source);
        _gl.CompileShader(shader);

        _gl.GetShader(shader, ShaderParameterName.CompileStatus, out int status);
        if (status != (int) GLEnum.True)
            throw new Exception($"Shader of type {type} failed to compile! {_gl.GetShaderInfoLog(shader)}");

        return shader;
    }
}
