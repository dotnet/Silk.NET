// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Surface = Silk.NET.Windowing.Surface;

internal class MyApplication : ISurfaceApplication
{
    public static void Initialize<TSurface>(TSurface surface)
        where TSurface : Surface
    {
        float[] vertices = [-0.5f, -0.5f, 0.0f, 0.5f, -0.5f, 0.0f, 0.0f, 0.5f, 0.0f];

        if (surface.OpenGL is null)
        {
            throw new PlatformNotSupportedException("OpenGL is not supported.");
        }

        // Enable OpenGL context creation for our surface.
        surface.OpenGL.Profile = OpenGLContextProfile.Core;
        surface.OpenGL.Version = new Version32(3, 3);

        var vbo = 0u;
        var vao = 0u;
        var prog = 0u;
        surface.Created += _ =>
        {
            // Make the OpenGL context current, this will allow us to use GL static functions.
            surface.MakeCurrent();

            Console.WriteLine("=== BEGIN OPENGL INFORMATION");
#pragma warning disable IL3050
            foreach (StringName val in Enum.GetValues(typeof(StringName)))
#pragma warning restore IL3050
            {
                Console.WriteLine($"{val} = {GL.GetString(val).ReadToString()}");
            }
            Console.WriteLine("=== END OPENGL INFORMATION");

            // Create the vertex buffer.
            vbo = GL.GenBuffer();
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(
                BufferTarget.ArrayBuffer,
                (nuint)(vertices.Length * sizeof(float)),
                vertices[0].AsRef(), // TODO simplify this
                BufferUsage.StaticDraw
            );
            vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);
            GL.VertexAttribPointer(
                0,
                3,
                VertexAttribPointerType.Float,
                false,
                3 * sizeof(float),
                nullptr
            );
            GL.EnableVertexAttribArray(0);
            var vert = GL.CreateShader(ShaderType.VertexShader);
            var frag = GL.CreateShader(ShaderType.FragmentShader);

            const string vertSource = """
                #version 330 core
                layout(location = 0) in vec3 aPosition;
                void main(void)
                {
                    gl_Position = vec4(aPosition, 1.0);
                }
                """;
            var vertSourceLength = vertSource.Length;
            GL.ShaderSource(vert, 1, new[] { vertSource }, vertSourceLength.AsRef());
            const string fragSource = """
                #version 330
                out vec4 outputColor;
                void main()
                {
                    outputColor = vec4(1.0, 0.5, 0.2, 1.0);
                }
                """;
            var fragSourceLength = fragSource.Length;
            GL.ShaderSource(frag, 1, new[] { fragSource }, fragSourceLength.AsRef());
            GL.CompileShader(vert);
            GL.CompileShader(frag);
            prog = GL.CreateProgram();
            GL.AttachShader(prog, vert);
            GL.AttachShader(prog, frag);
            GL.LinkProgram(prog);
            GL.DeleteShader(vert);
            GL.DeleteShader(frag);
            GL.UseProgram(prog);
        };
        surface.Render += _ =>
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
        };
        surface.Terminating += _ =>
        {
            GL.DeleteVertexArray(vao);
            GL.DeleteBuffer(vbo);
        };
    }

    public static void Main() => ISurfaceApplication.Run<MyApplication>();
}
