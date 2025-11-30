// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CombinerMappingNV")]
[Transformed]
public enum CombinerMappingNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_IDENTITY_NV")]
    UnsignedIdentitynv = unchecked((uint)0x8536),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INVERT_NV")]
    UnsignedInvertnv = unchecked((uint)0x8537),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EXPAND_NORMAL_NV")]
    ExpandNormalnv = unchecked((uint)0x8538),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_EXPAND_NEGATE_NV")]
    ExpandNegatenv = unchecked((uint)0x8539),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HALF_BIAS_NORMAL_NV")]
    HalfBiasNormalnv = unchecked((uint)0x853A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HALF_BIAS_NEGATE_NV")]
    HalfBiasNegatenv = unchecked((uint)0x853B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_IDENTITY_NV")]
    SignedIdentitynv = unchecked((uint)0x853C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SIGNED_NEGATE_NV")]
    SignedNegatenv = unchecked((uint)0x853D),
}
