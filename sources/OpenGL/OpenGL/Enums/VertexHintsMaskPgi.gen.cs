// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "PGI", 0)]
[NativeName("VertexHintsMaskPGI")]
[Transformed]
[Flags]
public enum VertexHintsMaskPgi : uint
{
    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_COLOR3_BIT_PGI")]
    Color3Bitpgi = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4Bitpgi = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBitpgi = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBitpgi = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBitpgi = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBitpgi = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBitpgi = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBitpgi = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBitpgi = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBitpgi = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBitpgi = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBitpgi = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1Bitpgi = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2Bitpgi = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3Bitpgi = unchecked((uint)0x40000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4Bitpgi = unchecked((uint)0x80000000),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23Bitpgi = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4Bitpgi = unchecked((uint)0x00000008),
}
