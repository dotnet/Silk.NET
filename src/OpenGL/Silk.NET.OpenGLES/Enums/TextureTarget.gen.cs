// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureTarget")]
    public enum TextureTarget : int
    {
        [NativeName("Name", "GL_TEXTURE_1D")]
        Texture1D = 0xDE0,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D")]
        ProxyTexture1D = 0x8063,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D_EXT")]
        ProxyTexture1DExt = 0x8063,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D")]
        ProxyTexture2D = 0x8064,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_EXT")]
        ProxyTexture2DExt = 0x8064,
        [NativeName("Name", "GL_TEXTURE_3D")]
        Texture3D = 0x806F,
        [NativeName("Name", "GL_TEXTURE_3D_EXT")]
        Texture3DExt = 0x806F,
        [NativeName("Name", "GL_TEXTURE_3D_OES")]
        Texture3DOes = 0x806F,
        [NativeName("Name", "GL_PROXY_TEXTURE_3D")]
        ProxyTexture3D = 0x8070,
        [NativeName("Name", "GL_PROXY_TEXTURE_3D_EXT")]
        ProxyTexture3DExt = 0x8070,
        [NativeName("Name", "GL_DETAIL_TEXTURE_2D_SGIS")]
        DetailTexture2DSgis = 0x8095,
        [NativeName("Name", "GL_TEXTURE_4D_SGIS")]
        Texture4DSgis = 0x8134,
        [NativeName("Name", "GL_PROXY_TEXTURE_4D_SGIS")]
        ProxyTexture4DSgis = 0x8135,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE")]
        TextureRectangle = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE_ARB")]
        TextureRectangleArb = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE_NV")]
        TextureRectangleNV = 0x84F5,
        [NativeName("Name", "GL_PROXY_TEXTURE_RECTANGLE")]
        ProxyTextureRectangle = 0x84F7,
        [NativeName("Name", "GL_PROXY_TEXTURE_RECTANGLE_ARB")]
        ProxyTextureRectangleArb = 0x84F7,
        [NativeName("Name", "GL_PROXY_TEXTURE_RECTANGLE_NV")]
        ProxyTextureRectangleNV = 0x84F7,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP")]
        TextureCubeMap = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARB")]
        TextureCubeMapArb = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_EXT")]
        TextureCubeMapExt = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_OES")]
        TextureCubeMapOes = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
        TextureCubeMapPositiveX = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
        TextureCubeMapPositiveXArb = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
        TextureCubeMapPositiveXExt = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
        TextureCubeMapPositiveXOes = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
        TextureCubeMapNegativeX = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
        TextureCubeMapNegativeXArb = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
        TextureCubeMapNegativeXExt = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
        TextureCubeMapNegativeXOes = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
        TextureCubeMapPositiveY = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
        TextureCubeMapPositiveYArb = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
        TextureCubeMapPositiveYExt = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
        TextureCubeMapPositiveYOes = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
        TextureCubeMapNegativeY = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
        TextureCubeMapNegativeYArb = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
        TextureCubeMapNegativeYExt = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
        TextureCubeMapNegativeYOes = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
        TextureCubeMapPositiveZ = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
        TextureCubeMapPositiveZArb = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
        TextureCubeMapPositiveZExt = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
        TextureCubeMapPositiveZOes = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
        TextureCubeMapNegativeZ = 0x851A,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
        TextureCubeMapNegativeZArb = 0x851A,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
        TextureCubeMapNegativeZExt = 0x851A,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
        TextureCubeMapNegativeZOes = 0x851A,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP")]
        ProxyTextureCubeMap = 0x851B,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
        ProxyTextureCubeMapArb = 0x851B,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
        ProxyTextureCubeMapExt = 0x851B,
        [NativeName("Name", "GL_TEXTURE_1D_ARRAY")]
        Texture1DArray = 0x8C18,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D_ARRAY")]
        ProxyTexture1DArray = 0x8C19,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
        ProxyTexture1DArrayExt = 0x8C19,
        [NativeName("Name", "GL_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x8C1A,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_ARRAY")]
        ProxyTexture2DArray = 0x8C1B,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
        ProxyTexture2DArrayExt = 0x8C1B,
        [NativeName("Name", "GL_TEXTURE_BUFFER")]
        TextureBuffer = 0x8C2A,
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY")]
        TextureCubeMapArray = 0x9009,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
        TextureCubeMapArrayArb = 0x9009,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
        TextureCubeMapArrayExt = 0x9009,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
        TextureCubeMapArrayOes = 0x9009,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_ARRAY")]
        ProxyTextureCubeMapArray = 0x900B,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
        ProxyTextureCubeMapArrayArb = 0x900B,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE")]
        Texture2DMultisample = 0x9100,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_MULTISAMPLE")]
        ProxyTexture2DMultisample = 0x9101,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        Texture2DMultisampleArray = 0x9102,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        ProxyTexture2DMultisampleArray = 0x9103,
    }
}
