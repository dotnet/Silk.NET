// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexHintsMaskPGI")]
[Flags]
public enum VertexHintsMaskPGI : uint
{
    None = 0x0,

    [NativeName("GL_COLOR3_BIT_PGI")]
    Color3BitPGI = unchecked((uint)0x00010000),

    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4BitPGI = unchecked((uint)0x00020000),

    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBitPGI = unchecked((uint)0x00040000),

    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBitPGI = unchecked((uint)0x00080000),

    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBitPGI = unchecked((uint)0x00100000),

    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBitPGI = unchecked((uint)0x00200000),

    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBitPGI = unchecked((uint)0x00400000),

    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBitPGI = unchecked((uint)0x00800000),

    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBitPGI = unchecked((uint)0x01000000),

    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBitPGI = unchecked((uint)0x02000000),

    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBitPGI = unchecked((uint)0x04000000),

    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBitPGI = unchecked((uint)0x08000000),

    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1BitPGI = unchecked((uint)0x10000000),

    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2BitPGI = unchecked((uint)0x20000000),

    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3BitPGI = unchecked((uint)0x40000000),

    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4BitPGI = unchecked((uint)0x80000000),

    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23BitPGI = unchecked((uint)0x00000004),

    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4BitPGI = unchecked((uint)0x00000008),
}
