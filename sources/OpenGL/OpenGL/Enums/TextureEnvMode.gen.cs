// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureEnvMode")]
[Transformed]
public enum TextureEnvMode : uint
{
    [NativeName("GL_BLEND")]
    Blend = unchecked((uint)0x0BE2),

    [NativeName("GL_REPLACE")]
    Replace = unchecked((uint)0x1E01),

    [NativeName("GL_MODULATE")]
    Modulate = unchecked((uint)0x2100),

    [NativeName("GL_DECAL")]
    Decal = unchecked((uint)0x2101),

    [NativeName("GL_ADD")]
    Add = unchecked((uint)0x0104),

    [NativeName("GL_COMBINE")]
    Combine = unchecked((uint)0x8570),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REPLACE_EXT")]
    Replaceext = unchecked((uint)0x8062),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_ENV_BIAS_SGIX")]
    TextureEnvBiassgix = unchecked((uint)0x80BE),
}
