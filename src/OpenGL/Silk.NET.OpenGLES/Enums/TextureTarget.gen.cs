// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum TextureTarget
    {
        Texture1D = 0xDE0,
        Texture2D = 0xDE1,
        ProxyTexture1D = 0x8063,
        ProxyTexture1DExt = 0x8063,
        ProxyTexture2D = 0x8064,
        ProxyTexture2DExt = 0x8064,
        Texture3D = 0x806F,
        Texture3DExt = 0x806F,
        Texture3DOes = 0x806F,
        ProxyTexture3D = 0x8070,
        ProxyTexture3DExt = 0x8070,
        DetailTexture2DSgis = 0x8095,
        Texture4DSgis = 0x8134,
        ProxyTexture4DSgis = 0x8135,
        TextureRectangle = 0x84F5,
        ProxyTextureRectangle = 0x84F7,
        ProxyTextureRectangleArb = 0x84F7,
        ProxyTextureRectangleNV = 0x84F7,
        TextureCubeMap = 0x8513,
        TextureCubeMapPositiveX = 0x8515,
        TextureCubeMapNegativeX = 0x8516,
        TextureCubeMapPositiveY = 0x8517,
        TextureCubeMapNegativeY = 0x8518,
        TextureCubeMapPositiveZ = 0x8519,
        TextureCubeMapNegativeZ = 0x851A,
        ProxyTextureCubeMap = 0x851B,
        ProxyTextureCubeMapArb = 0x851B,
        ProxyTextureCubeMapExt = 0x851B,
        Texture1DArray = 0x8C18,
        ProxyTexture1DArray = 0x8C19,
        ProxyTexture1DArrayExt = 0x8C19,
        Texture2DArray = 0x8C1A,
        ProxyTexture2DArray = 0x8C1B,
        ProxyTexture2DArrayExt = 0x8C1B,
        TextureCubeMapArray = 0x9009,
        TextureCubeMapArrayArb = 0x9009,
        TextureCubeMapArrayExt = 0x9009,
        TextureCubeMapArrayOes = 0x9009,
        ProxyTextureCubeMapArray = 0x900B,
        ProxyTextureCubeMapArrayArb = 0x900B,
        Texture2DMultisample = 0x9100,
        ProxyTexture2DMultisample = 0x9101,
        Texture2DMultisampleArray = 0x9102,
        ProxyTexture2DMultisampleArray = 0x9103,
    }
}
