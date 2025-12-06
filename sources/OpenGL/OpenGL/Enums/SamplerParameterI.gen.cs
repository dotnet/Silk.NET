// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplerParameterI")]
public enum SamplerParameterI : uint
{
    [NativeName("GL_TEXTURE_MAG_FILTER")]
    MagFilter = 10240,

    [NativeName("GL_TEXTURE_MIN_FILTER")]
    MinFilter = 10241,

    [NativeName("GL_TEXTURE_WRAP_S")]
    WrapS = 10242,

    [NativeName("GL_TEXTURE_WRAP_T")]
    WrapT = 10243,

    [NativeName("GL_TEXTURE_WRAP_R")]
    WrapR = 32882,

    [NativeName("GL_TEXTURE_COMPARE_MODE")]
    CompareMode = 34892,

    [NativeName("GL_TEXTURE_COMPARE_FUNC")]
    CompareFunc = 34893,

    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    UnnormalizedCoordinatesARM = 36714,
}
