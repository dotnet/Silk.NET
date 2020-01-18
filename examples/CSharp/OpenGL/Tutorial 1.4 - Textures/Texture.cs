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
            //Loading an image using imagesharp.
            Image<Rgba32> img = (Image<Rgba32>)Image.Load(path);
            //Converting the image into a byte array of data.
            byte[] data = new byte[img.Height * img.Width * 4];
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    data[(x + y * img.Width) * 4 + 0] = img[x, y].R;
                    data[(x + y * img.Width) * 4 + 1] = img[x, y].G;
                    data[(x + y * img.Width) * 4 + 2] = img[x, y].B;
                    data[(x + y * img.Width) * 4 + 3] = img[x, y].A;
                }
            }
            //Loading the actual image.
            Load(gl, data, (uint)img.Width, (uint)img.Height);

            //Deleting the img from imagesharp.
            img.Dispose();
        }

        //We want the ability to create a texture using data generated from code aswell.
        public Texture(GL gl, byte[] data, uint width, uint height) => Load(gl, data, width, height);

        private unsafe void Load(GL gl, byte[] data, uint width, uint height)
        {
            //Saving the gl instance.
            _gl = gl;

            //Generating the opengl handle;
            _handle = _gl.GenTexture();
            Bind();

            //Setting the data of a texture.
            fixed (void* d = data)
            {
                _gl.TexImage2D(TextureTarget.Texture2D, 0, (int)GLEnum.Rgba, width, height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, d);
            }
            //Setting some texture perameters so the texture behaves as expected.
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)GLEnum.Repeat);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)GLEnum.Repeat);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)GLEnum.Linear);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)GLEnum.Linear);

            //Generating mipmaps.
            _gl.GenerateMipmap(TextureTarget.Texture2D);
        }

        public void Bind(TextureUnit textureSlot = TextureUnit.Texture0)
        {
            //When we bind a texture we can choose which textureslot we can bind it to.
            _gl.ActiveTexture(textureSlot);
            _gl.BindTexture(TextureTarget.Texture2D, _handle);
        }

        public void Dispose()
        {
            //In order to dispose we need to delete the opengl handle for the texure.
            _gl.DeleteTexture(_handle);
        }
    }
}
