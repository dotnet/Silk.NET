// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.PGI
{
    [NativeName("Name", "GLenum")]
    public enum PGI : int
    {
        [NativeName("Name", "GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
        PreferDoublebufferHintPgi = 0x1A1F8,
        [NativeName("Name", "GL_CONSERVE_MEMORY_HINT_PGI")]
        ConserveMemoryHintPgi = 0x1A1FD,
        [NativeName("Name", "GL_RECLAIM_MEMORY_HINT_PGI")]
        ReclaimMemoryHintPgi = 0x1A1FE,
        [NativeName("Name", "GL_NATIVE_GRAPHICS_HANDLE_PGI")]
        NativeGraphicsHandlePgi = 0x1A202,
        [NativeName("Name", "GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI")]
        NativeGraphicsBeginHintPgi = 0x1A203,
        [NativeName("Name", "GL_NATIVE_GRAPHICS_END_HINT_PGI")]
        NativeGraphicsEndHintPgi = 0x1A204,
        [NativeName("Name", "GL_ALWAYS_FAST_HINT_PGI")]
        AlwaysFastHintPgi = 0x1A20C,
        [NativeName("Name", "GL_ALWAYS_SOFT_HINT_PGI")]
        AlwaysSoftHintPgi = 0x1A20D,
        [NativeName("Name", "GL_ALLOW_DRAW_OBJ_HINT_PGI")]
        AllowDrawObjHintPgi = 0x1A20E,
        [NativeName("Name", "GL_ALLOW_DRAW_WIN_HINT_PGI")]
        AllowDrawWinHintPgi = 0x1A20F,
        [NativeName("Name", "GL_ALLOW_DRAW_FRG_HINT_PGI")]
        AllowDrawFrgHintPgi = 0x1A210,
        [NativeName("Name", "GL_ALLOW_DRAW_MEM_HINT_PGI")]
        AllowDrawMemHintPgi = 0x1A211,
        [NativeName("Name", "GL_STRICT_DEPTHFUNC_HINT_PGI")]
        StrictDepthfuncHintPgi = 0x1A216,
        [NativeName("Name", "GL_STRICT_LIGHTING_HINT_PGI")]
        StrictLightingHintPgi = 0x1A217,
        [NativeName("Name", "GL_STRICT_SCISSOR_HINT_PGI")]
        StrictScissorHintPgi = 0x1A218,
        [NativeName("Name", "GL_FULL_STIPPLE_HINT_PGI")]
        FullStippleHintPgi = 0x1A219,
        [NativeName("Name", "GL_CLIP_NEAR_HINT_PGI")]
        ClipNearHintPgi = 0x1A220,
        [NativeName("Name", "GL_CLIP_FAR_HINT_PGI")]
        ClipFarHintPgi = 0x1A221,
        [NativeName("Name", "GL_WIDE_LINE_HINT_PGI")]
        WideLineHintPgi = 0x1A222,
        [NativeName("Name", "GL_BACK_NORMALS_HINT_PGI")]
        BackNormalsHintPgi = 0x1A223,
        [NativeName("Name", "GL_VERTEX_DATA_HINT_PGI")]
        VertexDataHintPgi = 0x1A22A,
        [NativeName("Name", "GL_VERTEX_CONSISTENT_HINT_PGI")]
        VertexConsistentHintPgi = 0x1A22B,
        [NativeName("Name", "GL_MATERIAL_SIDE_HINT_PGI")]
        MaterialSideHintPgi = 0x1A22C,
        [NativeName("Name", "GL_MAX_VERTEX_HINT_PGI")]
        MaxVertexHintPgi = 0x1A22D,
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
        [NativeName("Name", "GL_VERTEX23_BIT_PGI")]
        Vertex23BitPgi = 0x4,
        [NativeName("Name", "GL_VERTEX4_BIT_PGI")]
        Vertex4BitPgi = 0x8,
    }
}
