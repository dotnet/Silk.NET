using System;
using System.Drawing;
using System.IO;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using Silk.NET.OpenGL;
using StbImageSharp;

// Textures!
// In this tutorial, you'll learn how to load and render textures.

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

        private static uint _texture;

        public static void Main(string[] args)
        {
            WindowOptions options = WindowOptions.Default;
            options.Size = new Vector2D<int>(800, 600);
            options.Title = "1.3 - Textures";

            _window = Window.Create(options);

            _window.Load += OnLoad;
            _window.Update += OnUpdate;
            _window.Render += OnRender;
            _window.FramebufferResize += OnResize;
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
            // You may have noticed an addition - texture coordinates!
            // Texture coordinates are a value between 0-1 (see more later about this) which tell the GPU which part
            // of the texture to use for each vertex.
            float[] vertices =
            {
              // aPosition--------   aTexCoords
                 0.5f,  0.5f, 0.0f,  1.0f, 1.0f,
                 0.5f, -0.5f, 0.0f,  1.0f, 0.0f,
                -0.5f, -0.5f, 0.0f,  0.0f, 0.0f,
                -0.5f,  0.5f, 0.0f,  0.0f, 1.0f
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

        // On top of our aPosition attribute, we now create an aTexCoords attribute for our texture coordinates.
        layout (location = 1) in vec2 aTexCoords;

        // Likewise, we also assign an out attribute to go into the fragment shader.
        out vec2 frag_texCoords;
        
        void main()
        {
            gl_Position = vec4(aPosition, 1.0);

            // This basic vertex shader does no additional processing of texture coordinates, so we can pass them
            // straight to the fragment shader.
            frag_texCoords = aTexCoords;
        }";

            // The fragment shader code.
            const string fragmentCode = @"
        #version 330 core

        // This in attribute corresponds to the out attribute we defined in the vertex shader.
        in vec2 frag_texCoords;
        
        out vec4 out_color;

        // Now we define a uniform value!
        // A uniform in OpenGL is a value that can be changed outside of the shader by modifying its value.
        // A sampler2D contains both a texture and information on how to sample it.
        // Sampling a texture is basically calculating the color of a pixel on a texture at any given point.
        uniform sampler2D uTexture;
        
        void main()
        {
            // We use GLSL's texture function to sample from the texture at the given input texture coordinates.
            out_color = texture(uTexture, frag_texCoords);
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
            
            // Set up our vertex attributes! These tell the vertex array (VAO) how to process the vertex data we defined
            // earlier. Each vertex array contains attributes. 

            // Our stride constant. The stride must be in bytes, so we take the first attribute (a vec3), multiply it
            // by the size in bytes of a float, and then take our second attribute (a vec2), and do the same.
            const uint stride = (3 * sizeof(float)) + (2 * sizeof(float));

            // Enable the "aPosition" attribute in our vertex array, providing its size and stride too.
            const uint positionLoc = 0;
            _gl.EnableVertexAttribArray(positionLoc);
            _gl.VertexAttribPointer(positionLoc, 3, VertexAttribPointerType.Float, false, stride, (void*) 0);

            // Now we need to enable our texture coordinates! We've defined that as location 1 so that's what we'll use
            // here. The code is very similar to above, but you must make sure you set its offset to the **size in bytes**
            // of the attribute before.
            const uint textureLoc = 1;
            _gl.EnableVertexAttribArray(textureLoc);
            _gl.VertexAttribPointer(textureLoc, 2, VertexAttribPointerType.Float, false, stride, (void*) (3 * sizeof(float)));

            // Unbind everything as we don't need it.
            _gl.BindVertexArray(0);
            _gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
            _gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, 0);

            // Now we create our texture!
            // First, we create the texture itself. Then, we must set an active texture unit. Each texture unit is a
            // separate bindable texture that we can use in a shader. GPUs have a maximum number of texture units they
            // can use, however the OpenGL spec states there MUST be at least 32 units available.
            // Much like buffers, we then bind the texture to a Texture2D target.
            _texture = _gl.GenTexture();
            _gl.ActiveTexture(TextureUnit.Texture0);
            _gl.BindTexture(TextureTarget.Texture2D, _texture);

            // Use StbImageSharp to load an image from our PNG file.
            // This will load and decompress the result into a raw byte array that we can pass directly into OpenGL.
            ImageResult result = ImageResult.FromMemory(File.ReadAllBytes("silk.png"), ColorComponents.RedGreenBlueAlpha);

            fixed (byte* ptr = result.Data)
            {
                // Upload our texture data to the GPU.
                // Let's go over each parameter used here:
                // 1. Tell OpenGL that we want to upload to the texture bound in the Texture2D target.
                // 2. We are uploading the "base" texture level, therefore this value should be 0. You don't need to
                //    worry about texture levels for now.
                // 3. We tell OpenGL that we want the GPU to store this data as RGBA formatted data on the GPU itself.
                // 4. The image's width.
                // 5. The image's height.
                // 6. This is the image's border. This valu MUST be 0. It is a leftover component from legacy OpenGL, and
                //    it serves no purpose.
                // 7. Our image data is formatted as RGBA data, therefore we must tell OpenGL we are uploading RGBA data.
                // 8. StbImageSharp returns this data as a byte[] array, therefore we must tell OpenGL we are uploading
                //    data in the unsigned byte format.
                // 9. The actual pointer to our data!
                _gl.TexImage2D(TextureTarget.Texture2D, 0, InternalFormat.Rgba, (uint) result.Width, 
                    (uint) result.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, ptr);
            }

            // Let's set some texture parameters!
            // This tells the GPU how it should sample the texture.
            
            // Set the texture wrap mode to repeat.
            // The texture wrap mode defines what should happen when the texture coordinates go outside of the 0-1 range.
            // In this case, we set it to repeat. The texture will just repeatedly tile over and over again.
            // You'll notice we're using S and T wrapping here. This is OpenGL's version of the standard UV mapping you
            // may be more used to, where S is on the X-axis, and T is on the Y-axis.
            _gl.TextureParameter(_texture, TextureParameterName.TextureWrapS, (int) TextureWrapMode.Repeat);
            _gl.TextureParameter(_texture, TextureParameterName.TextureWrapT, (int) TextureWrapMode.Repeat);

            // The min and mag filters define how the texture should be sampled as it resized.
            // The min, or minification filter, is used when the texture is reduced in size.
            // The mag, or magnification filter, is used when the texture is increased in size.
            // We're using bilinear filtering here, as it produces a generally nice result.
            // You can also use nearest (point) filtering, or anisotropic filtering, which is only available on the min
            // filter.
            // You may notice that the min filter defines a "mipmap" filter as well. We'll go over mipmaps below.
            _gl.TextureParameter(_texture, TextureParameterName.TextureMinFilter, (int) TextureMinFilter.LinearMipmapLinear);
            _gl.TextureParameter(_texture, TextureParameterName.TextureMagFilter, (int) TextureMagFilter.Linear);

            // Generate mipmaps for this texture.
            // Note: We MUST do this or the texture will appear as black (this is an option you can change but this is
            // out of scope for this tutorial).
            // What is a mipmap?
            // A mipmap is essentially a smaller version of the existing texture. When generating mipmaps, the texture
            // size is continuously halved, generally stopping once it reaches a size of 1x1 pixels. (Note: there are
            // exceptions to this, for example if the GPU reaches its maximum level of mipmaps, which is both a hardware
            // limitation, and a user defined value. You don't need to worry about this for now, so just assume that
            // the mips will be generated all the way down to 1x1 pixels).
            // Mipmaps are used when the texture is reduced in size, to produce a much nicer result, and to reduce moire
            // effect patterns.
            _gl.GenerateMipmap(TextureTarget.Texture2D);

            // Unbind the texture as we no longer need to update it any further.
            _gl.BindTexture(TextureTarget.Texture2D, 0);

            // Get our texture uniform, and set it to 0.
            // We can easily do this by using glGetUniformLocation and giving it a name.
            // Setting it to 0 tells it that you want it to use the 0th texture unit.
            // Generally, OpenGL should automatically initialize all uniform values to their default value (which is
            // almost always 0), however you should get into the practice of initializing all uniform values to a known
            // value, before you use them in your shader.
            int location = _gl.GetUniformLocation(_program, "uTexture");
            _gl.Uniform1(location, 0);

            // Finally a bit of blending!
            // If you disable blending, you'll notice a black border around the texture.
            // The texture is partially transparent, however OpenGL doesn't know how to handle this by default.
            // By enabling blending, and giving it a blend function, you can tell OpenGL how to handle transparency.
            // In this case, it removes the black background and just leaves the texture on its own.
            // The blend function is out of scope for this tutorial, so don't worry if you don't understand it too much.
            // The program will function just fine without blending!
            _gl.Enable(EnableCap.Blend);
            _gl.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        }

        private static void OnUpdate(double dt) { }

        private static unsafe void OnRender(double dt)
        {
            // Clear the window to the color we set earlier.
            _gl.Clear(ClearBufferMask.ColorBufferBit);

            // Bind our VAO, then the program.
            _gl.BindVertexArray(_vao);
            _gl.UseProgram(_program);

            // Much like our texture creation earlier, we must first set our active texture unit, and then bind the
            // texture to use it during draw!
            _gl.ActiveTexture(TextureUnit.Texture0);
            _gl.BindTexture(TextureTarget.Texture2D, _texture);

            // Draw our quad! We use a count of 6 here because we have 6 total vertices that makes up a quad.
            _gl.DrawElements(PrimitiveType.Triangles, 6, DrawElementsType.UnsignedInt, (void*) 0);
        }

        private static void OnResize(Vector2D<int> size)
        {
            _gl.Viewport(0, 0, (uint) size.X, (uint) size.Y);
        }
    }
}
