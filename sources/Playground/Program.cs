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

        if (surface.OpenGl is null)
        {
            throw new PlatformNotSupportedException("OpenGL is not supported.");
        }

        // Enable OpenGL context creation for our surface.
        surface.OpenGl.Profile = OpenGlContextProfile.Core;
        surface.OpenGl.Version = new Version32(3, 3);

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
                Console.WriteLine($"{val} = {Gl.GetString(val).ReadToString()}");
            }
            Console.WriteLine("=== END OPENGL INFORMATION");

            // Create the vertex buffer.
            vbo = Gl.GenBuffer();
            Gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            Gl.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            Gl.BufferData(
                BufferTarget.ArrayBuffer,
                (nuint)(vertices.Length * sizeof(float)),
                vertices[0].AsRef(), // TODO simplify this
                BufferUsage.StaticDraw
            );
            vao = Gl.GenVertexArray();
            Gl.BindVertexArray(vao);
            Gl.VertexAttribPointer(
                0,
                3,
                VertexAttribPointerType.Float,
                false,
                3 * sizeof(float),
                nullptr
            );
            Gl.EnableVertexAttribArray(0);
            var vert = Gl.CreateShader(ShaderType.VertexShader);
            var frag = Gl.CreateShader(ShaderType.FragmentShader);

            const string vertSource = """
                #version 330 core
                layout(location = 0) in vec3 aPosition;
                void main(void)
                {
                    gl_Position = vec4(aPosition, 1.0);
                }
                """;
            var vertSourceLength = vertSource.Length;
            Gl.ShaderSource(vert, 1, new[] { vertSource }, vertSourceLength.AsRef());
            const string fragSource = """
                #version 330
                out vec4 outputColor;
                void main()
                {
                    outputColor = vec4(1.0, 0.5, 0.2, 1.0);
                }
                """;
            var fragSourceLength = fragSource.Length;
            Gl.ShaderSource(frag, 1, new[] { fragSource }, fragSourceLength.AsRef());
            Gl.CompileShader(vert);
            Gl.CompileShader(frag);
            prog = Gl.CreateProgram();
            Gl.AttachShader(prog, vert);
            Gl.AttachShader(prog, frag);
            Gl.LinkProgram(prog);
            Gl.DeleteShader(vert);
            Gl.DeleteShader(frag);
            Gl.UseProgram(prog);
        };
        surface.Render += _ =>
        {
            Gl.Clear(ClearBufferMask.ColorBufferBit);
            Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
        };
        surface.Terminating += _ =>
        {
            Gl.DeleteVertexArray(vao);
            Gl.DeleteBuffer(vbo);
        };
    }

    public static void Main() => ISurfaceApplication.Run<MyApplication>();
}
