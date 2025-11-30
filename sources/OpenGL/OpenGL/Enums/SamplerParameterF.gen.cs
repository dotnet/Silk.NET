// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplerParameterF")]
[Transformed]
public enum SamplerParameterF : uint
{
    [NativeName("GL_TEXTURE_BORDER_COLOR")]
    BorderColor = unchecked((uint)0x1004),

    [NativeName("GL_TEXTURE_MIN_LOD")]
    MinLod = unchecked((uint)0x813A),

    [NativeName("GL_TEXTURE_MAX_LOD")]
    MaxLod = unchecked((uint)0x813B),

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    LodBias = unchecked((uint)0x8501),

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY")]
    MaxAnisotropy = unchecked((uint)0x84FE),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    UnnormalizedCoordinatesARM = unchecked((uint)0x8F6A),
}
