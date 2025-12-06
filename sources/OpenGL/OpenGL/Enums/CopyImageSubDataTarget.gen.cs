// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CopyImageSubDataTarget")]
public enum CopyImageSubDataTarget : uint
{
    [NativeName("GL_TEXTURE_2D")]
    Texture2D = 3553,

    [NativeName("GL_TEXTURE_1D")]
    Texture1D = 3552,

    [NativeName("GL_TEXTURE_3D")]
    Texture3D = 32879,

    [NativeName("GL_TEXTURE_CUBE_MAP")]
    TextureCubeMap = 34067,

    [NativeName("GL_TEXTURE_1D_ARRAY")]
    Texture1DArray = 35864,

    [NativeName("GL_TEXTURE_2D_ARRAY")]
    Texture2DArray = 35866,

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = 36161,

    [NativeName("GL_TEXTURE_RECTANGLE")]
    TextureRectANGLE = 34037,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE")]
    Texture2DMultisample = 37120,

    [NativeName("GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
    Texture2DMultisampleArray = 37122,

    [NativeName("GL_TEXTURE_CUBE_MAP_ARRAY")]
    TextureCubeMapArray = 36873,
}
