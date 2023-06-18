// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
#if GLES
using Silk.NET.OpenGLES;
#elif GL
using Silk.NET.OpenGL;
#elif LEGACY
using Silk.NET.OpenGL.Legacy;
#endif

#if GL
namespace Silk.NET.OpenGL.Extensions.ImGui
#elif GLES
namespace Silk.NET.OpenGLES.Extensions.ImGui
#elif LEGACY
namespace Silk.NET.OpenGL.Legacy.Extensions.ImGui
#endif
{
    public enum TextureCoordinate
    {
        S = TextureParameterName.TextureWrapS,
        T = TextureParameterName.TextureWrapT,
        R = TextureParameterName.TextureWrapR
    }

    class Texture : IDisposable
    {
        public const SizedInternalFormat Srgb8Alpha8 = (SizedInternalFormat) GLEnum.Srgb8Alpha8;
        public const SizedInternalFormat Rgb32F = (SizedInternalFormat) GLEnum.Rgb32f;

        public const GLEnum MaxTextureMaxAnisotropy = (GLEnum) 0x84FF;

        public static float? MaxAniso;
        private readonly GL _gl;
        public readonly string Name;
        public readonly uint GlTexture;
        public readonly uint Width, Height;
        public readonly uint MipmapLevels;
        public readonly SizedInternalFormat InternalFormat;

        public unsafe Texture(GL gl, int width, int height, IntPtr data, bool generateMipmaps = false, bool srgb = false)
        {
            _gl = gl;
            if (MaxAniso is null)
            {
                float aniso;
                gl.GetFloat(MaxTextureMaxAnisotropy, &aniso);
                MaxAniso = aniso;
            }

            Width = (uint) width;
            Height = (uint) height;
            InternalFormat = srgb ? Srgb8Alpha8 : SizedInternalFormat.Rgba8;
            MipmapLevels = (uint) (generateMipmaps == false ? 1 : (int) Math.Floor(Math.Log(Math.Max(Width, Height), 2)));

            fixed (uint* tex = &GlTexture)
            {
                _gl.GenTextures(1, tex);
            }

            Bind();

#if GLES || LEGACY
            PixelFormat pxFormat = PixelFormat.Rgba;
#elif GL
            PixelFormat pxFormat = PixelFormat.Bgra;
#endif

            _gl.TexStorage2D(GLEnum.Texture2D, MipmapLevels, (GLEnum) InternalFormat, Width, Height);
            _gl.TexSubImage2D(GLEnum.Texture2D, 0, 0, 0, Width, Height, (GLEnum) pxFormat, (GLEnum) PixelType.UnsignedByte, (void*) data);

            if (generateMipmaps)
#if GLES
                _gl.GenerateMipmap(GLEnum.Texture2D);
#elif GL
                _gl.GenerateTextureMipmap(GlTexture);
#endif
            SetWrap(TextureCoordinate.S, TextureWrapMode.Repeat);
            SetWrap(TextureCoordinate.T, TextureWrapMode.Repeat);

            var maxLevel = MipmapLevels - 1;
            _gl.TexParameterI(GLEnum.Texture2D, GLEnum.TextureMaxLevel, &maxLevel);
        }

        public void Bind()
        {
            _gl.BindTexture(GLEnum.Texture2D, GlTexture);
        }

        public unsafe void SetMinFilter(TextureMinFilter filter)
        {
            _gl.TexParameterI(GLEnum.Texture2D, GLEnum.TextureMinFilter, (int*) &filter);
        }

        public unsafe void SetMagFilter(TextureMagFilter filter)
        {
            _gl.TexParameterI(GLEnum.Texture2D, GLEnum.TextureMagFilter, (int*) &filter);
        }

        public void SetAnisotropy(float level)
        {
            const TextureParameterName textureMaxAnisotropy = (TextureParameterName) 0x84FE;
            _gl.TexParameter(GLEnum.Texture2D, (GLEnum) textureMaxAnisotropy, Util.Clamp(level, 1, MaxAniso.GetValueOrDefault()));
        }

        public unsafe void SetLod(int @base, int min, int max)
        {
#if !GLES
            _gl.TexParameterI(GLEnum.Texture2D, GLEnum.TextureLodBias, &@base);
            _gl.TexParameterI(GLEnum.Texture2D, GLEnum.TextureMinLod, &min);
            _gl.TexParameterI(GLEnum.Texture2D, GLEnum.TextureMaxLod, &max);
#endif
        }

        public unsafe void SetWrap(TextureCoordinate coord, TextureWrapMode mode)
        {
            _gl.TexParameterI(GLEnum.Texture2D, (GLEnum) coord, (int*) &mode);
        }

        public unsafe void Dispose()
        {
            fixed (uint* tex = &GlTexture)
            {
                _gl.DeleteTextures(1, tex);
            }
        }
    }
}
