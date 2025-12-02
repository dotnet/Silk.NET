// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("HintTarget")]
public enum HintTarget : uint
{
    [NativeName("GL_PERSPECTIVE_CORRECTION_HINT")]
    PerspectiveCorrectionHint = unchecked((uint)0x0C50),

    [NativeName("GL_POINT_SMOOTH_HINT")]
    PointSmoothHint = unchecked((uint)0x0C51),

    [NativeName("GL_LINE_SMOOTH_HINT")]
    LineSmoothHint = unchecked((uint)0x0C52),

    [NativeName("GL_FOG_HINT")]
    FogHint = unchecked((uint)0x0C54),

    [NativeName("GL_GENERATE_MIPMAP_HINT")]
    GenerateMipmapHint = unchecked((uint)0x8192),

    [NativeName("GL_POLYGON_SMOOTH_HINT")]
    PolygonSmoothHint = unchecked((uint)0x0C53),

    [NativeName("GL_TEXTURE_COMPRESSION_HINT")]
    TextureCompressionHint = unchecked((uint)0x84EF),

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
    FragmentShaderDerivativeHint = unchecked((uint)0x8B8B),

    [NativeName("GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
    ProgramBinaryRetrievableHint = unchecked((uint)0x8257),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
    FragmentShaderDerivativeHintARB = unchecked((uint)0x8B8B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE_COMPRESSION_HINT_ARB")]
    TextureCompressionHintARB = unchecked((uint)0x84EF),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TEXTURE_STORAGE_HINT_APPLE")]
    TextureStorageHintAPPLE = unchecked((uint)0x85BC),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_TRANSFORM_HINT_APPLE")]
    TransformHintAPPLE = unchecked((uint)0x85B1),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
    VertexArrayStorageHintAPPLE = unchecked((uint)0x851F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
    ClipVolumeClippingHintEXT = unchecked((uint)0x80F0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintEXT = unchecked((uint)0x800E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintEXT = unchecked((uint)0x800F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MULTISAMPLE_FILTER_HINT_NV")]
    MultisampleFilterHintNV = unchecked((uint)0x8534),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
    PreferDoublebufferHintPGI = unchecked((uint)0x1A1F8),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_CONSERVE_MEMORY_HINT_PGI")]
    ConserveMemoryHintPGI = unchecked((uint)0x1A1FD),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_RECLAIM_MEMORY_HINT_PGI")]
    ReclaimMemoryHintPGI = unchecked((uint)0x1A1FE),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI")]
    NativeGraphicsBeginHintPGI = unchecked((uint)0x1A203),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_NATIVE_GRAPHICS_END_HINT_PGI")]
    NativeGraphicsEndHintPGI = unchecked((uint)0x1A204),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALWAYS_FAST_HINT_PGI")]
    AlwaysFastHintPGI = unchecked((uint)0x1A20C),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALWAYS_SOFT_HINT_PGI")]
    AlwaysSoftHintPGI = unchecked((uint)0x1A20D),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_OBJ_HINT_PGI")]
    AllowDrawObjHintPGI = unchecked((uint)0x1A20E),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_WIN_HINT_PGI")]
    AllowDrawWinHintPGI = unchecked((uint)0x1A20F),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_FRG_HINT_PGI")]
    AllowDrawFrgHintPGI = unchecked((uint)0x1A210),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_ALLOW_DRAW_MEM_HINT_PGI")]
    AllowDrawMemHintPGI = unchecked((uint)0x1A211),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_STRICT_DEPTHFUNC_HINT_PGI")]
    StrictDepthfuncHintPGI = unchecked((uint)0x1A216),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_STRICT_LIGHTING_HINT_PGI")]
    StrictLightingHintPGI = unchecked((uint)0x1A217),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_STRICT_SCISSOR_HINT_PGI")]
    StrictScissorHintPGI = unchecked((uint)0x1A218),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_FULL_STIPPLE_HINT_PGI")]
    FullStippleHintPGI = unchecked((uint)0x1A219),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_CLIP_NEAR_HINT_PGI")]
    ClipNearHintPGI = unchecked((uint)0x1A220),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_CLIP_FAR_HINT_PGI")]
    ClipFarHintPGI = unchecked((uint)0x1A221),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_WIDE_LINE_HINT_PGI")]
    WideLineHintPGI = unchecked((uint)0x1A222),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_BACK_NORMALS_HINT_PGI")]
    BackNormalsHintPGI = unchecked((uint)0x1A223),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHintPGI = unchecked((uint)0x1A22A),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHintPGI = unchecked((uint)0x1A22B),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHintPGI = unchecked((uint)0x1A22C),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHintPGI = unchecked((uint)0x1A22D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_GENERATE_MIPMAP_HINT_SGIS")]
    GenerateMipmapHintSGIS = unchecked((uint)0x8192),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintSGIX = unchecked((uint)0x8316),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SCALEBIAS_HINT_SGIX")]
    ScalebiasHintSGIX = unchecked((uint)0x8322),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
    TextureMultiBufferHintSGIX = unchecked((uint)0x812E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipSGIX = unchecked((uint)0x83EE),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintSGIX = unchecked((uint)0x83EF),

    [NameAffix("Suffix", "WIN", 0)]
    [NativeName("GL_PHONG_HINT_WIN")]
    PhongHintWIN = unchecked((uint)0x80EB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
    FragmentShaderDerivativeHintOES = unchecked((uint)0x8B8B),

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("GL_BINNING_CONTROL_HINT_QCOM")]
    BinningControlHintQCOM = unchecked((uint)0x8FB0),
}
