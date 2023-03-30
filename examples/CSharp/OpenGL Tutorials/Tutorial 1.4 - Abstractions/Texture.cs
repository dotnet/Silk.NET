using System;
using System.IO;
using Silk.NET.OpenGL;
using StbImageSharp;

namespace Tutorial
{
    public class Texture
    {
        private uint _handle;
        private GL _gl;

        public unsafe Texture(GL gl, string path)
        {
            _gl = gl;

            _handle = _gl.GenTexture();
            Bind();
            
            ImageResult result = ImageResult.FromMemory(File.ReadAllBytes(path), ColorComponents.RedGreenBlueAlpha);
            
            fixed (byte* ptr = result.Data)
            {
                _gl.TexImage2D(TextureTarget.Texture2D, 0, InternalFormat.Rgba, (uint) result.Width, 
                    (uint) result.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, ptr);
            }

            SetParameters();
        }

        public unsafe Texture(GL gl, Span<byte> data, uint width, uint height)
        {
            _gl = gl;

            _handle = _gl.GenTexture();
            Bind();

            fixed (void* d = &data[0])
            {
                _gl.TexImage2D(TextureTarget.Texture2D, 0, (int) InternalFormat.Rgba, width, height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, d);
                SetParameters();
            }
        }

        private void SetParameters()
        {
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int) GLEnum.ClampToEdge);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int) GLEnum.ClampToEdge);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int) GLEnum.LinearMipmapLinear);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int) GLEnum.Linear);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureBaseLevel, 0);
            _gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMaxLevel, 8);
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
