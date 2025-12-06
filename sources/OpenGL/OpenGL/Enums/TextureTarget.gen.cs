// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureTarget")]
public enum TextureTarget : uint
{
    [NativeName("GL_TEXTURE_2D")]
    Texture2D = 3553,

    [NativeName("GL_TEXTURE_CUBE_MAP_OES")]
    TextureCubeMapOES = 34067,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES")]
    TextureCubeMapPositiveXOES = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES")]
    TextureCubeMapNegativeXOES = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES")]
    TextureCubeMapPositiveYOES = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES")]
    TextureCubeMapNegativeYOES = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES")]
    TextureCubeMapPositiveZOES = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES")]
    TextureCubeMapNegativeZOES = 34074,

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = 3552,

    [NativeName("GL_PROXY_TEXTURE_1D")]
    ProxyTexture1D = 32867,

    [NativeName("GL_PROXY_TEXTURE_2D")]
    ProxyTexture2D = 32868,

    [NativeName("GL_TEXTURE_3D")]
    Texture3D = 32879,

    [NativeName("GL_PROXY_TEXTURE_3D")]
    ProxyTexture3D = 32880,

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = 34067,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X")]
    TextureCubeMapPositiveX = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X")]
    TextureCubeMapNegativeX = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y")]
    TextureCubeMapPositiveY = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y")]
    TextureCubeMapNegativeY = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z")]
    TextureCubeMapPositiveZ = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z")]
    TextureCubeMapNegativeZ = 34074,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP")]
    ProxyTextureCubeMap = 34075,

    [NativeName("GL_TEXTURE_1D_ARRAY")]
    Texture1DArray = 35864,

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY")]
    ProxyTexture1DArray = 35865,

    [NativeName("GL_TEXTURE_2D_ARRAY")]
    Texture2DArray = 35866,

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY")]
    ProxyTexture2DArray = 35867,

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = 36161,

    [NativeName("GL_TEXTURE_BUFFER")]
    TextureBuffer = 35882,

    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectANGLE = 34037,

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE")]
    ProxyTextureRectANGLE = 34039,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE")]
    Texture2DMultisample = 37120,

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE")]
    ProxyTexture2DMultisample = 37121,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    Texture2DMultisampleArray = 37122,

    [NativeName("GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    ProxyTexture2DMultisampleArray = 37123,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY")]
    TextureCubeMapArray = 36873,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY")]
    ProxyTextureCubeMapArray = 36875,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARB")]
    TextureCubeMapARB = 34067,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
    TextureCubeMapPositiveXARB = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
    TextureCubeMapNegativeXARB = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
    TextureCubeMapPositiveYARB = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
    TextureCubeMapNegativeYARB = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
    TextureCubeMapPositiveZARB = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
    TextureCubeMapNegativeZARB = 34074,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
    ProxyTextureCubeMapARB = 34075,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    TextureCubeMapArrayARB = 36873,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
    ProxyTextureCubeMapArrayARB = 36875,

    [NativeName("GL_TEXTURE_RECTANGLE_ARB")]
    TextureRectangleARB = 34037,

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_ARB")]
    ProxyTextureRectangleARB = 34039,

    [NativeName("GL_PROXY_TEXTURE_1D_EXT")]
    ProxyTexture1DEXT = 32867,

    [NativeName("GL_PROXY_TEXTURE_2D_EXT")]
    ProxyTexture2DEXT = 32868,

    [NativeName("GL_TEXTURE_3D_EXT")]
    Texture3DEXT = 32879,

    [NativeName("GL_PROXY_TEXTURE_3D_EXT")]
    ProxyTexture3DEXT = 32880,

    [NativeName("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
    ProxyTexture1DArrayEXT = 35865,

    [NativeName("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
    ProxyTexture2DArrayEXT = 35867,

    [NativeName("GL_TEXTURE_CUBE_MAP_EXT")]
    TextureCubeMapEXT = 34067,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT")]
    TextureCubeMapPositiveXEXT = 34069,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT")]
    TextureCubeMapNegativeXEXT = 34070,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT")]
    TextureCubeMapPositiveYEXT = 34071,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT")]
    TextureCubeMapNegativeYEXT = 34072,

    [NativeName("GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT")]
    TextureCubeMapPositiveZEXT = 34073,

    [NativeName("GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT")]
    TextureCubeMapNegativeZEXT = 34074,

    [NativeName("GL_PROXY_TEXTURE_CUBE_MAP_EXT")]
    ProxyTextureCubeMapEXT = 34075,

    [NativeName("GL_TEXTURE_RECTANGLE_NV")]
    TextureRectangleNV = 34037,

    [NativeName("GL_PROXY_TEXTURE_RECTANGLE_NV")]
    ProxyTextureRectangleNV = 34039,

    [NativeName("GL_DETAIL_TEXTURE_2D_SGIS")]
    DetailTexture2DSGIS = 32917,

    [NativeName("GL_TEXTURE_4D_SGIS")]
    Texture4DSGIS = 33076,

    [NativeName("GL_PROXY_TEXTURE_4D_SGIS")]
    ProxyTexture4DSGIS = 33077,

    [NativeName("GL_TEXTURE_3D_OES")]
    Texture3DOES = 32879,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_OES")]
    TextureCubeMapArrayOES = 36873,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY_EXT")]
    TextureCubeMapArrayEXT = 36873,
}
