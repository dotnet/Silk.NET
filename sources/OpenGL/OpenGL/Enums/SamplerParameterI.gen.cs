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
    MagFilter = unchecked((uint)0x2800),

    [NativeName("GL_TEXTURE_MIN_FILTER")]
    MinFilter = unchecked((uint)0x2801),

    [NativeName("GL_TEXTURE_WRAP_S")]
    WrapS = unchecked((uint)0x2802),

    [NativeName("GL_TEXTURE_WRAP")]
    [NameAffix("Suffix", "_T", -1)]
    Wrap = unchecked((uint)0x2803),

    [NativeName("GL_TEXTURE_WRAP_R")]
    WrapR = unchecked((uint)0x8072),

    [NativeName("GL_TEXTURE_COMPARE_MODE")]
    CompareMode = unchecked((uint)0x884C),

    [NativeName("GL_TEXTURE_COMPARE_FUNC")]
    CompareFunc = unchecked((uint)0x884D),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    UnnormalizedCoordinatesARM = unchecked((uint)0x8F6A),
}
