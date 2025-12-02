// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "PGI", 0)]
[NativeName("VertexHintsMaskPGI")]
[Flags]
public enum VertexHintsMaskPGI : uint
{
    None = 0x0,

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_COLOR3_BIT_PGI")]
    Color3Bit = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4Bit = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBit = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBit = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBit = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBit = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBit = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBit = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBit = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBit = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBit = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBit = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1Bit = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2Bit = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3Bit = unchecked((uint)0x40000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4Bit = unchecked((uint)0x80000000),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23Bit = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4Bit = unchecked((uint)0x00000008),
}
