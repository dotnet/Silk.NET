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
    Color3Bit = 0x10000,

    [NativeName("GL_COLOR4_BIT_PGI")]
    Color4Bit = 0x20000,

    [NativeName("GL_EDGEFLAG_BIT_PGI")]
    EdgeflagBit = 0x40000,

    [NativeName("GL_INDEX_BIT_PGI")]
    IndexBit = 0x80000,

    [NativeName("GL_MAT_AMBIENT_BIT_PGI")]
    MatAmbientBit = 0x100000,

    [NativeName("GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
    MatAmbientAndDiffuseBit = 0x200000,

    [NativeName("GL_MAT_DIFFUSE_BIT_PGI")]
    MatDiffuseBit = 0x400000,

    [NativeName("GL_MAT_EMISSION_BIT_PGI")]
    MatEmissionBit = 0x800000,

    [NativeName("GL_MAT_COLOR_INDEXES_BIT_PGI")]
    MatColorIndexesBit = 0x1000000,

    [NativeName("GL_MAT_SHININESS_BIT_PGI")]
    MatShininessBit = 0x2000000,

    [NativeName("GL_MAT_SPECULAR_BIT_PGI")]
    MatSpecularBit = 0x4000000,

    [NativeName("GL_NORMAL_BIT_PGI")]
    NormalBit = 0x8000000,

    [NativeName("GL_TEXCOORD1_BIT_PGI")]
    Texcoord1Bit = 0x10000000,

    [NativeName("GL_TEXCOORD2_BIT_PGI")]
    Texcoord2Bit = 0x20000000,

    [NativeName("GL_TEXCOORD3_BIT_PGI")]
    Texcoord3Bit = 0x40000000,

    [NativeName("GL_TEXCOORD4_BIT_PGI")]
    Texcoord4Bit = 0x80000000,

    [NativeName("GL_VERTEX23_BIT_PGI")]
    Vertex23Bit = 0x4,

    [NativeName("GL_VERTEX4_BIT_PGI")]
    Vertex4Bit = 0x8,
}
