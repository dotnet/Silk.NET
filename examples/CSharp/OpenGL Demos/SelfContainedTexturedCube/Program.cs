// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using StbImageSharp;

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

        // Create vertex + index buffers.
        _vbo = _gl.GenBuffer();
        _ebo = _gl.GenBuffer();
        
        // Bind the buffers to their respective targets.
        _gl.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);
        _gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, _ebo);

        // Upload the vertices and indices.
        // Note that the vertices are a struct comprising of a Vector3 and Vector2.
        // OpenGL supports this, as byte for byte, this will be exactly the same as just giving it an array of floats,
        // and doing it this way makes it much easier to understand.
        fixed (VertexPositionTexture* vertices = cube.Vertices)
            _gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) (cube.Vertices.Length * sizeof(VertexPositionTexture)), vertices, BufferUsageARB.StaticDraw);

        fixed (uint* indices = cube.Indices)
            _gl.BufferData(BufferTargetARB.ElementArrayBuffer, (nuint) (cube.Indices.Length * sizeof(uint)), indices, BufferUsageARB.StaticDraw);

        // Create our camera struct.
        CameraInfo camera = new CameraInfo()
        {
            ProjectionMatrix = Matrix4x4.CreatePerspectiveFieldOfView(75 * MathF.PI / 180, _window.Size.X / (float) _window.Size.Y, 0.1f, 100f),
            ViewMatrix = Matrix4x4.CreateLookAt(new Vector3(0, -2, 0), Vector3.Zero, Vector3.UnitX)
        };

        // Uniform buffers! A very powerful tool.
        // In short - they are a buffer containing data, much like any other buffer, however can be bound to a uniform
        // in the shader. The advantage of this is that you can update the buffer once, and use it in any shader that
        // wants to use it, without updating a ton of uniforms every time.
        // They are also faster, with the tradeoff of slightly increased memory usage.
        _cameraInfoBuffer = _gl.GenBuffer();
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, _cameraInfoBuffer);
        _gl.BufferData(BufferTargetARB.UniformBuffer, (nuint) sizeof(CameraInfo), &camera, BufferUsageARB.StaticDraw);

        Matrix4x4 modelMatrix = Matrix4x4.Identity;

        _modelMatrixBuffer = _gl.GenBuffer();
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, _modelMatrixBuffer);
        _gl.BufferData(BufferTargetARB.UniformBuffer, (nuint) sizeof(Matrix4x4), &modelMatrix, BufferUsageARB.DynamicDraw);

        // Uniform buffers, unlike VBOs and EBOs, are NOT part of the VAO. As such, we can unbind it here.
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, 0);

        // Create our vertex and fragment shaders by calling the helper function.
        uint vertexShader = CreateShader(ShaderType.VertexShader, File.ReadAllText("Content/Cube.vert"));
        uint fragmentShader = CreateShader(ShaderType.FragmentShader, File.ReadAllText("Content/Cube.frag"));

        // Create our program, attach shaders, and link.
        _program = _gl.CreateProgram();
        _gl.AttachShader(_program, vertexShader);
        _gl.AttachShader(_program, fragmentShader);
        _gl.LinkProgram(_program);

        // Check to make sure it linked correctly.
        _gl.GetProgram(_program, ProgramPropertyARB.LinkStatus, out int status);
        if (status != (int) GLEnum.True)
            throw new Exception($"Failed to link program! {_gl.GetProgramInfoLog(_program)}");

        // Detach and delete our shaders, as we no longer need them.
        _gl.DetachShader(_program, vertexShader);
        _gl.DetachShader(_program, fragmentShader);
        _gl.DeleteShader(vertexShader);
        _gl.DeleteShader(fragmentShader);

        // Enable and setup our position attribute (aPosition).
        const uint positionAttribLocation = 0;
        _gl.EnableVertexAttribArray(positionAttribLocation);
        _gl.VertexAttribPointer(positionAttribLocation, 3, VertexAttribPointerType.Float, false, (uint) sizeof(VertexPositionTexture), (void*) 0);

        // Enable and setup our texture coordinate attribute (aTexCoord).
        const uint texCoordAttribLocation = 1;
        _gl.EnableVertexAttribArray(texCoordAttribLocation);
        _gl.VertexAttribPointer(texCoordAttribLocation, 2, VertexAttribPointerType.Float, false, (uint) sizeof(VertexPositionTexture), (void*) 12);

        // Unbind our vertex array, and then unbind our buffers.
        // Note: If you unbind any of the buffers before you unbind the vertex array, problems will occur.
        // In this case, at best the cube will just not render, and at worst a graphics driver crash may occur. 
        _gl.BindVertexArray(0);
        _gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
        _gl.BindBuffer(GLEnum.ElementArrayBuffer, 0);
        
        // Load our texture data.
        ImageResult image = ImageResult.FromMemory(File.ReadAllBytes("Content/awesomeface.png"), ColorComponents.RedGreenBlueAlpha);
        
        // Create & bind our texture to Texture2D. 
        _texture = _gl.GenTexture();
        _gl.BindTexture(TextureTarget.Texture2D, _texture);

        // Give the texture its data.
        fixed (byte* imgData = image.Data)
            _gl.TexImage2D(TextureTarget.Texture2D, 0, InternalFormat.Rgba, (uint) image.Width, (uint) image.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, imgData);

        // S, T == U, V
        _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int) TextureWrapMode.Repeat);
        _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int) TextureWrapMode.Repeat);

        _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int) TextureMinFilter.LinearMipmapLinear);
        _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int) TextureMagFilter.Linear);

        // Every GPU should have had anisotropic filtering for decades (Direct3D required support since at least D3D9).
        // Unfortunately OpenGL did not add it into the official spec until 4.6 (released in 2017!!!)
        // Therefore, we should check to make sure it is present regardless. 
        if (_gl.IsExtensionPresent("ARB_texture_filter_anisotropic"))
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMaxAnisotropy, 16);

        // Generate mipmaps. If you don't do this, the texture will be black.
        // There are workarounds, but that is beyond the scope of this demo.
        _gl.GenerateMipmap(TextureTarget.Texture2D);

        // Finally, unbind our texture.
        _gl.BindTexture(TextureTarget.Texture2D, 0);
        
        _gl.Enable(EnableCap.DepthTest);
        _gl.DepthFunc(DepthFunction.Lequal);

        // Enable face culling - telling it to cull the back face, and telling it that our vertices are in the clockwise
        // direction.
        _gl.Enable(EnableCap.CullFace);
        _gl.FrontFace(FrontFaceDirection.CW);
        _gl.CullFace(TriangleFace.Back);
        
        _rotation = Quaternion.Identity;
    }

    private static void Update(double dt)
    {
        _rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitY, 1 * (float) dt) *
                     Quaternion.CreateFromAxisAngle(Vector3.UnitX, 0.75f * (float) dt) *
                     Quaternion.CreateFromAxisAngle(Vector3.UnitZ, 0.5f * (float) dt);
    }

    private static unsafe void Draw(double dt)
    {
        // Update our model matrix buffer.
        Matrix4x4 modelMatrix = Matrix4x4.CreateFromQuaternion(_rotation);
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, _modelMatrixBuffer);
        _gl.BufferSubData(BufferTargetARB.UniformBuffer, 0, (nuint) sizeof(Matrix4x4), &modelMatrix);
        _gl.BindBuffer(BufferTargetARB.UniformBuffer, 0);
        
        _gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        _gl.BindVertexArray(_vao);
        _gl.UseProgram(_program);

        _gl.ActiveTexture(TextureUnit.Texture2);
        _gl.BindTexture(TextureTarget.Texture2D, _texture);

        // Bind our uniform buffers to their given binding points in the shader.
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
