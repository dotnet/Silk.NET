// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureTarget")]
[Transformed]
public enum TextureTarget : uint
{
    [NativeName("GL_TEXTURE_2D")]
    Texture2D = unchecked((uint)0x0DE1),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapoes = unchecked((uint)0x8513),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
    TextureCubeMapPositiveXoes = unchecked((uint)0x8515),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
    TextureCubeMapNegativeXoes = unchecked((uint)0x8516),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
    TextureCubeMapPositiveYoes = unchecked((uint)0x8517),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
    TextureCubeMapNegativeYoes = unchecked((uint)0x8518),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
    TextureCubeMapPositiveZoes = unchecked((uint)0x8519),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
    TextureCubeMapNegativeZoes = unchecked((uint)0x851A),

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = unchecked((uint)0x0DE0),

    [NativeName("GL_PROXY_TEXTURE_1D")]
    ProxyTexture1D = unchecked((uint)0x8063),

    [NativeName("GL_PROXY_TEXTURE_2D")]
    ProxyTexture2D = unchecked((uint)0x8064),

    [NativeName("GL_TEXTURE_3D")]
    Texture3D = unchecked((uint)0x806F),

    [NativeName("GL_PROXY_TEXTURE_3D")]
    ProxyTexture3D = unchecked((uint)0x8070),

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = unchecked((uint)0x8513),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
    TextureCubeMapPositiveX = unchecked((uint)0x8515),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
    TextureCubeMapNegativeX = unchecked((uint)0x8516),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
    TextureCubeMapPositiveY = unchecked((uint)0x8517),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
    TextureCubeMapNegativeY = unchecked((uint)0x8518),

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
    TextureCubeMapPositiveZ = unchecked((uint)0x8519),

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
    TextureCubeMapNegativeZ = unchecked((uint)0x851A),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP")]
    ProxyTextureCubeMap = unchecked((uint)0x851B),

    [NativeName("GL_TEXTURE_1D_ARRAY")]
    Texture1DArray = unchecked((uint)0x8C18),

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY")]
    ProxyTexture1DArray = unchecked((uint)0x8C19),

    [NativeName("GL_TEXTURE_2D_ARRAY")]
    Texture2DArray = unchecked((uint)0x8C1A),

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY")]
    ProxyTexture2DArray = unchecked((uint)0x8C1B),

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = unchecked((uint)0x8D41),

    [NativeName("GL_TEXTURE_BUFFER")]
    TextureBuffer = unchecked((uint)0x8C2A),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectangle = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_PROXY_TEXTURE_RECTANGLE")]
    ProxyTextureRectangle = unchecked((uint)0x84F7),

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE")]
    Texture2DMultisample = unchecked((uint)0x9100),

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE")]
    ProxyTexture2DMultisample = unchecked((uint)0x9101),

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    Texture2DMultisampleArray = unchecked((uint)0x9102),

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    ProxyTexture2DMultisampleArray = unchecked((uint)0x9103),

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY")]
    TextureCubeMapArray = unchecked((uint)0x9009),

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY")]
    ProxyTextureCubeMapArray = unchecked((uint)0x900B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMaparb = unchecked((uint)0x8513),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
    TextureCubeMapPositiveXarb = unchecked((uint)0x8515),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
    TextureCubeMapNegativeXarb = unchecked((uint)0x8516),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
    TextureCubeMapPositiveYarb = unchecked((uint)0x8517),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
    TextureCubeMapNegativeYarb = unchecked((uint)0x8518),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
    TextureCubeMapPositiveZarb = unchecked((uint)0x8519),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
    TextureCubeMapNegativeZarb = unchecked((uint)0x851A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
    ProxyTextureCubeMaparb = unchecked((uint)0x851B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    TextureCubeMapArrayarb = unchecked((uint)0x9009),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    ProxyTextureCubeMapArrayarb = unchecked((uint)0x900B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectAnglearb = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_ARB")]
    ProxyTextureRectAnglearb = unchecked((uint)0x84F7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_1D_EXT")]
    ProxyTexture1Dext = unchecked((uint)0x8063),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_2D_EXT")]
    ProxyTexture2Dext = unchecked((uint)0x8064),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3Dext = unchecked((uint)0x806F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_3D_EXT")]
    ProxyTexture3Dext = unchecked((uint)0x8070),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
    ProxyTexture1DArrayext = unchecked((uint)0x8C19),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
    ProxyTexture2DArrayext = unchecked((uint)0x8C1B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapext = unchecked((uint)0x8513),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
    TextureCubeMapPositiveXext = unchecked((uint)0x8515),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
    TextureCubeMapNegativeXext = unchecked((uint)0x8516),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
    TextureCubeMapPositiveYext = unchecked((uint)0x8517),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
    TextureCubeMapNegativeYext = unchecked((uint)0x8518),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
    TextureCubeMapPositiveZext = unchecked((uint)0x8519),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
    TextureCubeMapNegativeZext = unchecked((uint)0x851A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
    ProxyTextureCubeMapext = unchecked((uint)0x851B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectAnglenv = unchecked((uint)0x84F5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_NV")]
    ProxyTextureRectAnglenv = unchecked((uint)0x84F7),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_2D_SGIS")]
    DetailTexture2Dsgis = unchecked((uint)0x8095),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4Dsgis = unchecked((uint)0x8134),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PROXY_TEXTURE_4D_SGIS")]
    ProxyTexture4Dsgis = unchecked((uint)0x8135),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_3D_OES")]
    Texture3Does = unchecked((uint)0x806F),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
    TextureCubeMapArrayoes = unchecked((uint)0x9009),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
    TextureCubeMapArrayext = unchecked((uint)0x9009),
}
