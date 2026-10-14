// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplerParameterF")]
public enum SamplerParameterF : uint
{
    [NativeName("GL_TEXTURE_BORDER_COLOR")]
    BorderColor = 4100,

    [NativeName("GL_TEXTURE_MIN_LOD")]
    MinLod = 33082,

    [NativeName("GL_TEXTURE_MAX_LOD")]
    MaxLod = 33083,

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    LodBias = 34049,

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY")]
    MaxAnisotropy = 34046,

    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    UnnormalizedCoordinatesARM = 36714,
}
