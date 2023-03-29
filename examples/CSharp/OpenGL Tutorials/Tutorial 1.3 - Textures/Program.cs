using System;
using System.Drawing;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using Silk.NET.OpenGL;

namespace Tutorial
{
    public class Program
    {
        private static IWindow _window;
        private static GL _gl;

        private static uint _vao;
        private static uint _vbo;
        private static uint _ebo;

        private static uint _program;
    
        public static void Main(string[] args)
        {
            WindowOptions options = WindowOptions.Default;
            options.Size = new Vector2D<int>(800, 600);
            options.Title = "1.2 - Drawing a Quad";
    
            _window = Window.Create(options);
            
            _window.Load += OnLoad;
            _window.Update += OnUpdate;
            _window.Render += OnRender;
            _window.Run();
            
            _window.Dispose();
        }
        
        private static unsafe void OnLoad()
            {
                _gl = _window.CreateOpenGL();
                
                _gl.ClearColor(Color.CornflowerBlue);
        
                // Create the VAO.
                _vao = _gl.GenVertexArray();
                _gl.BindVertexArray(_vao);
        
                // The quad vertices data.
                float[] vertices =
                {
                    0.5f,  0.5f, 0.0f,
                    0.5f, -0.5f, 0.0f,
                    -0.5f, -0.5f, 0.0f,
                    -0.5f,  0.5f, 0.0f
                };
        
                // Create the VBO.
                _vbo = _gl.GenBuffer();
                _gl.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);
        
                // Upload the vertices data to the VBO.
                fixed (float* buf = vertices)
                    _gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) (vertices.Length * sizeof(float)), buf, BufferUsageARB.StaticDraw);
        
                // The quad indices data.
                uint[] indices =
                {
                    0u, 1u, 3u,
                    1u, 2u, 3u
                };
        
                // Create the EBO.
                _ebo = _gl.GenBuffer();
                _gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, _ebo);
        
                // Upload the indices data to the EBO.
                fixed (uint* buf = indices)
                    _gl.BufferData(BufferTargetARB.ElementArrayBuffer, (nuint) (indices.Length * sizeof(uint)), buf, BufferUsageARB.StaticDraw);
        
                // The vertex shader code.
                const string vertexCode = @"
        #version 330 core
        
        layout (location = 0) in vec3 aPosition;
        
        void main()
        {
            gl_Position = vec4(aPosition, 1.0);
        }";
        
                // The fragment shader code.
                const string fragmentCode = @"
        #version 330 core
        
        out vec4 out_color;
        
        void main()
        {
            out_color = vec4(1.0, 0.5, 0.2, 1.0);
        }";
        
                // Create our vertex shader, and give it our vertex shader source code.
                uint vertexShader = _gl.CreateShader(ShaderType.VertexShader);
                _gl.ShaderSource(vertexShader, vertexCode);
        
                // Attempt to compile the shader.
                _gl.CompileShader(vertexShader);
        
                // Check to make sure that the shader has successfully compiled.
                _gl.GetShader(vertexShader, ShaderParameterName.CompileStatus, out int vStatus);
                if (vStatus != (int) GLEnum.True)
                    throw new Exception("Vertex shader failed to compile: " + _gl.GetShaderInfoLog(vertexShader));
        
                // Repeat this process for the fragment shader.
                uint fragmentShader = _gl.CreateShader(ShaderType.FragmentShader);
                _gl.ShaderSource(fragmentShader, fragmentCode);
        
                _gl.CompileShader(fragmentShader);
        
                _gl.GetShader(fragmentShader, ShaderParameterName.CompileStatus, out int fStatus);
                if (fStatus != (int) GLEnum.True)
                    throw new Exception("Fragment shader failed to compile: " + _gl.GetShaderInfoLog(fragmentShader));
        
                // Create our shader program, and attach the vertex & fragment shaders.
                _program = _gl.CreateProgram();
        
                _gl.AttachShader(_program, vertexShader);
                _gl.AttachShader(_program, fragmentShader);
        
                // Attempt to "link" the program together.
                _gl.LinkProgram(_program);
        
                // Similar to shader compilation, check to make sure that the shader program has linked properly.
                _gl.GetProgram(_program, ProgramPropertyARB.LinkStatus, out int lStatus);
                if (lStatus != (int) GLEnum.True)
                    throw new Exception("Program failed to link: " + _gl.GetProgramInfoLog(_program));
        
                // Detach and delete our shaders. Once a program is linked, we no longer need the individual shader objects.
                _gl.DetachShader(_program, vertexShader);
                _gl.DetachShader(_program, fragmentShader);
                _gl.DeleteShader(vertexShader);
                _gl.DeleteShader(fragmentShader);
        
                // Enable the "aPosition" attribute in our vertex shader, providing its size and stride too.
                const uint positionLoc = 0;
                _gl.EnableVertexAttribArray(positionLoc);
                _gl.VertexAttribPointer(positionLoc, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), (void*) 0);
                
                // Unbind everything as we don't need it.
                _gl.BindVertexArray(0);
                _gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
                _gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, 0);
            }
        
            private static void OnUpdate(double dt) { }
            
            private static unsafe void OnRender(double dt)
            {
                // Clear the window to the color we set earlier.
                _gl.Clear(ClearBufferMask.ColorBufferBit);
        
                // Bind our VAO, then the program, and then draw our quad! We use a count of 6 here because we have 6
                // total vertices that makes up a quad.
        	    _gl.BindVertexArray(_vao);
        	    _gl.UseProgram(_program);
        	    _gl.DrawElements(PrimitiveType.Triangles, 6, DrawElementsType.UnsignedInt, (void*) 0);
            }
    }
}
