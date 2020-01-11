using Silk.NET.OpenGL;
using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Tutorial
{
    public class Texture : IDisposable
    {
        private uint _handle;
        private GL _gl;

        public Texture(GL gl, string path)
        {
            Image<Rgba32> img = (Image<Rgba32>)Image.Load(path);
            byte[] data = new byte[img.Height * img.Width * 4];
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    data[x + y * img.Width + 0] = img[x, y].R;
                    data[x + y * img.Width + 1] = img[x, y].G;
                    data[x + y * img.Width + 2] = img[x, y].B;
                    data[x + y * img.Width + 3] = img[x, y].A;
                }
            }
            Load(gl, data, (uint)img.Width, (uint)img.Height);

            img.Dispose();
        }

        public Texture(GL gl, byte[] data, uint width, uint height) => Load(gl, data, width, height);

        private unsafe void Load(GL gl, byte[] data, uint width, uint height)
        {
            _gl = gl;

            _handle = _gl.GenTexture();
            Bind();
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (float)GLEnum.Repeat);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (float)GLEnum.Repeat);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (float)GLEnum.Linear);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (float)GLEnum.Linear);

            fixed (void* d = data)
            {
                _gl.TexImage2D(TextureTarget.Texture2D, 0, (int)GLEnum.Rgba, width, height, 0, PixelFormat.Rgba, PixelType.Byte, d);
            }
            _gl.GenerateMipmap(TextureTarget.Texture2D);
        }

        public void Bind(TextureUnit textureSlot = TextureUnit.Texture0)
        {
            _gl.ActiveTexture(textureSlot);
            _gl.BindTexture(TextureTarget.Texture2D, _handle);
        }

        public void Dispose()
        {
            _gl.DeleteTexture(_handle);
        }
    }
}
