using System;
using Silk.NET.OpenGL;

namespace Ultz.SilkExtensions.ImGui.OpenGL
{
    public enum TextureCoordinate
    {
        S = TextureParameterName.TextureWrapS,
        T = TextureParameterName.TextureWrapT,
        R = TextureParameterName.TextureWrapR
    }

    class Texture : IDisposable
    {
        public const InternalFormat Srgb8Alpha8 = (InternalFormat)GLEnum.Srgb8Alpha8;
        public const InternalFormat RGB32F = (InternalFormat)GLEnum.Rgb32f;

        public const GetPName MAX_TEXTURE_MAX_ANISOTROPY = (GetPName)0x84FF;

        public static float? MaxAniso;
        private readonly GL GL;
        public readonly string Name;
        public readonly uint GLTexture;
        public readonly uint Width, Height;
        public readonly uint MipmapLevels;
        public readonly InternalFormat InternalFormat;
        public unsafe Texture(GL gl, string name, int width, int height, IntPtr data, bool generateMipmaps = false, bool srgb = false)
        {
            GL = gl;
            MaxAniso ??= gl.GetFloat(MAX_TEXTURE_MAX_ANISOTROPY);
            Name = name;
            Width = (uint) width;
            Height = (uint) height;
            InternalFormat = srgb ? Srgb8Alpha8 : InternalFormat.Rgba8;
            MipmapLevels = (uint) (generateMipmaps == false ? 1 : (int)Math.Floor(Math.Log(Math.Max(Width, Height), 2)));

            GL.CreateTexture(TextureTarget.Texture2D, Name, out GLTexture);
            GL.TextureStorage2D(GLTexture, MipmapLevels, InternalFormat, Width, Height);

            GL.TextureSubImage2D(GLTexture, 0, 0, 0, Width, Height, PixelFormat.Bgra, PixelType.UnsignedByte, (void*) data);

            if (generateMipmaps) GL.GenerateTextureMipmap(GLTexture);

            SetWrap(TextureCoordinate.S, TextureWrapMode.Repeat);
            SetWrap(TextureCoordinate.T, TextureWrapMode.Repeat);

            GL.TextureParameter(GLTexture, TextureParameterName.TextureMaxLevel, MipmapLevels - 1);
        }

        public void SetMinFilter(TextureMinFilter filter)
        {
            GL.TextureParameter(GLTexture, TextureParameterName.TextureMinFilter, (int)filter);
        }

        public void SetMagFilter(TextureMagFilter filter)
        {
            GL.TextureParameter(GLTexture, TextureParameterName.TextureMagFilter, (int)filter);
        }

        public void SetAnisotropy(float level)
        {
            const TextureParameterName TEXTURE_MAX_ANISOTROPY = (TextureParameterName)0x84FE;
            GL.TextureParameter(GLTexture, TEXTURE_MAX_ANISOTROPY, Util.Clamp(level, 1, MaxAniso.GetValueOrDefault()));
        }

        public void SetLod(int @base, int min, int max)
        {
            GL.TextureParameter(GLTexture, TextureParameterName.TextureLodBias, @base);
            GL.TextureParameter(GLTexture, TextureParameterName.TextureMinLod, min);
            GL.TextureParameter(GLTexture, TextureParameterName.TextureMaxLod, max);
        }
        
        public void SetWrap(TextureCoordinate coord, TextureWrapMode mode)
        {
            GL.TextureParameter(GLTexture, (TextureParameterName)coord, (int)mode);
        }

        public void Dispose()
        {
            GL.DeleteTexture(GLTexture);
        }
    }
}
