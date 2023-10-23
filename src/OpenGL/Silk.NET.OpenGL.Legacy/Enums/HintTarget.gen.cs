// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "HintTarget")]
    public enum HintTarget : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PERSPECTIVE_CORRECTION_HINT")]
        PerspectiveCorrectionHint = 0xC50,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SMOOTH_HINT")]
        PointSmoothHint = 0xC51,
        [NativeName("Name", "GL_LINE_SMOOTH_HINT")]
        LineSmoothHint = 0xC52,
        [NativeName("Name", "GL_POLYGON_SMOOTH_HINT")]
        PolygonSmoothHint = 0xC53,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_HINT")]
        FogHint = 0xC54,
        [NativeName("Name", "GL_PACK_CMYK_HINT_EXT")]
        PackCmykHintExt = 0x800E,
        [NativeName("Name", "GL_UNPACK_CMYK_HINT_EXT")]
        UnpackCmykHintExt = 0x800F,
        [NativeName("Name", "GL_PHONG_HINT_WIN")]
        PhongHintWin = 0x80EB,
        [NativeName("Name", "GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
        ClipVolumeClippingHintExt = 0x80F0,
        [NativeName("Name", "GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
        TextureMultiBufferHintSgix = 0x812E,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_GENERATE_MIPMAP_HINT")]
        GenerateMipmapHint = 0x8192,
        [NativeName("Name", "GL_GENERATE_MIPMAP_HINT_SGIS")]
        GenerateMipmapHintSgis = 0x8192,
        [NativeName("Name", "GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
        ProgramBinaryRetrievableHint = 0x8257,
        [NativeName("Name", "GL_CONVOLUTION_HINT_SGIX")]
        ConvolutionHintSgix = 0x8316,
        [NativeName("Name", "GL_SCALEBIAS_HINT_SGIX")]
        ScalebiasHintSgix = 0x8322,
        [NativeName("Name", "GL_LINE_QUALITY_HINT_SGIX")]
        LineQualityHintSgix = 0x835B,
        [NativeName("Name", "GL_VERTEX_PRECLIP_SGIX")]
        VertexPreclipSgix = 0x83EE,
        [NativeName("Name", "GL_VERTEX_PRECLIP_HINT_SGIX")]
        VertexPreclipHintSgix = 0x83EF,
        [NativeName("Name", "GL_TEXTURE_COMPRESSION_HINT")]
        TextureCompressionHint = 0x84EF,
        [NativeName("Name", "GL_TEXTURE_COMPRESSION_HINT_ARB")]
        TextureCompressionHintArb = 0x84EF,
        [NativeName("Name", "GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
        VertexArrayStorageHintApple = 0x851F,
        [NativeName("Name", "GL_MULTISAMPLE_FILTER_HINT_NV")]
        MultisampleFilterHintNV = 0x8534,
        [NativeName("Name", "GL_TRANSFORM_HINT_APPLE")]
        TransformHintApple = 0x85B1,
        [NativeName("Name", "GL_TEXTURE_STORAGE_HINT_APPLE")]
        TextureStorageHintApple = 0x85BC,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
        FragmentShaderDerivativeHint = 0x8B8B,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
        FragmentShaderDerivativeHintArb = 0x8B8B,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
        FragmentShaderDerivativeHintOes = 0x8B8B,
        [NativeName("Name", "GL_BINNING_CONTROL_HINT_QCOM")]
        BinningControlHintQCom = 0x8FB0,
        [NativeName("Name", "GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
        PreferDoublebufferHintPgi = 0x1A1F8,
        [NativeName("Name", "GL_CONSERVE_MEMORY_HINT_PGI")]
        ConserveMemoryHintPgi = 0x1A1FD,
        [NativeName("Name", "GL_RECLAIM_MEMORY_HINT_PGI")]
        ReclaimMemoryHintPgi = 0x1A1FE,
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
    }
}
