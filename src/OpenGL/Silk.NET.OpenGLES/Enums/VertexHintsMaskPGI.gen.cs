// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [Flags]
    [NativeName("Name", "VertexHintsMaskPGI")]
    public enum VertexHintsMaskPGI : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_VERTEX23_BIT_PGI")]
        Vertex23BitPgi = 0x4,
        [NativeName("Name", "GL_VERTEX4_BIT_PGI")]
        Vertex4BitPgi = 0x8,
        [NativeName("Name", "GL_COLOR3_BIT_PGI")]
        Color3BitPgi = 0x10000,
        [NativeName("Name", "GL_COLOR4_BIT_PGI")]
        Color4BitPgi = 0x20000,
        [NativeName("Name", "GL_EDGEFLAG_BIT_PGI")]
        EdgeflagBitPgi = 0x40000,
        [NativeName("Name", "GL_INDEX_BIT_PGI")]
        IndexBitPgi = 0x80000,
        [NativeName("Name", "GL_MAT_AMBIENT_BIT_PGI")]
        MatAmbientBitPgi = 0x100000,
        [NativeName("Name", "GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI")]
        MatAmbientAndDiffuseBitPgi = 0x200000,
        [NativeName("Name", "GL_MAT_DIFFUSE_BIT_PGI")]
        MatDiffuseBitPgi = 0x400000,
        [NativeName("Name", "GL_MAT_EMISSION_BIT_PGI")]
        MatEmissionBitPgi = 0x800000,
        [NativeName("Name", "GL_MAT_COLOR_INDEXES_BIT_PGI")]
        MatColorIndexesBitPgi = 0x1000000,
        [NativeName("Name", "GL_MAT_SHININESS_BIT_PGI")]
        MatShininessBitPgi = 0x2000000,
        [NativeName("Name", "GL_MAT_SPECULAR_BIT_PGI")]
        MatSpecularBitPgi = 0x4000000,
        [NativeName("Name", "GL_NORMAL_BIT_PGI")]
        NormalBitPgi = 0x8000000,
        [NativeName("Name", "GL_TEXCOORD1_BIT_PGI")]
        Texcoord1BitPgi = 0x10000000,
        [NativeName("Name", "GL_TEXCOORD2_BIT_PGI")]
        Texcoord2BitPgi = 0x20000000,
        [NativeName("Name", "GL_TEXCOORD3_BIT_PGI")]
        Texcoord3BitPgi = 0x40000000,
        [NativeName("Name", "GL_TEXCOORD4_BIT_PGI")]
        Texcoord4BitPgi = unchecked((int)0x80000000),
    }
}
