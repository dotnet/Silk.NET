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
    [NativeName("GL_LINE_SMOOTH_HINT")]
    LineSmoothHint = 3154,

    [NativeName("GL_POLYGON_SMOOTH_HINT")]
    PolygonSmoothHint = 3155,

    [NativeName("GL_PERSPECTIVE_CORRECTION_HINT")]
    PerspectiveCorrectionHint = 3152,

    [NativeName("GL_POINT_SMOOTH_HINT")]
    PointSmoothHint = 3153,

    [NativeName("GL_FOG_HINT")]
    FogHint = 3156,

    [NativeName("GL_TEXTURE_COMPRESSION_HINT")]
    TextureCompressionHint = 34031,

    [NativeName("GL_GENERATE_MIPMAP_HINT")]
    GenerateMipmapHint = 33170,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT")]
    FragmentShaderDerivativeHint = 35723,

    [NativeName("GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
    ProgramBinaryRetrievableHint = 33367,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
    FragmentShaderDerivativeHintARB = 35723,

    [NativeName("GL_TEXTURE_COMPRESSION_HINT_ARB")]
    TextureCompressionHintARB = 34031,

    [NativeName("GL_TEXTURE_STORAGE_HINT_APPLE")]
    TextureStorageHintAPPLE = 34236,

    [NativeName("GL_TRANSFORM_HINT_APPLE")]
    TransformHintAPPLE = 34225,

    [NativeName("GL_VERTEX_ARRAY_STORAGE_HINT_APPLE")]
    VertexArrayStorageHintAPPLE = 34079,

    [NativeName("GL_CLIP_VOLUME_CLIPPING_HINT_EXT")]
    ClipVolumeClippingHintEXT = 33008,

    [NativeName("GL_PACK_CMYK_HINT_EXT")]
    PackCmykHintEXT = 32782,

    [NativeName("GL_UNPACK_CMYK_HINT_EXT")]
    UnpackCmykHintEXT = 32783,

    [NativeName("GL_MULTISAMPLE_FILTER_HINT_NV")]
    MultisampleFilterHintNV = 34100,

    [NativeName("GL_PREFER_DOUBLEBUFFER_HINT_PGI")]
    PreferDoublebufferHintPGI = 107000,

    [NativeName("GL_CONSERVE_MEMORY_HINT_PGI")]
    ConserveMemoryHintPGI = 107005,

    [NativeName("GL_RECLAIM_MEMORY_HINT_PGI")]
    ReclaimMemoryHintPGI = 107006,

    [NativeName("GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI")]
    NativeGraphicsBeginHintPGI = 107011,

    [NativeName("GL_NATIVE_GRAPHICS_END_HINT_PGI")]
    NativeGraphicsEndHintPGI = 107012,

    [NativeName("GL_ALWAYS_FAST_HINT_PGI")]
    AlwaysFastHintPGI = 107020,

    [NativeName("GL_ALWAYS_SOFT_HINT_PGI")]
    AlwaysSoftHintPGI = 107021,

    [NativeName("GL_ALLOW_DRAW_OBJ_HINT_PGI")]
    AllowDrawObjHintPGI = 107022,

    [NativeName("GL_ALLOW_DRAW_WIN_HINT_PGI")]
    AllowDrawWinHintPGI = 107023,

    [NativeName("GL_ALLOW_DRAW_FRG_HINT_PGI")]
    AllowDrawFrgHintPGI = 107024,

    [NativeName("GL_ALLOW_DRAW_MEM_HINT_PGI")]
    AllowDrawMemHintPGI = 107025,

    [NativeName("GL_STRICT_DEPTHFUNC_HINT_PGI")]
    StrictDepthfuncHintPGI = 107030,

    [NativeName("GL_STRICT_LIGHTING_HINT_PGI")]
    StrictLightingHintPGI = 107031,

    [NativeName("GL_STRICT_SCISSOR_HINT_PGI")]
    StrictScissorHintPGI = 107032,

    [NativeName("GL_FULL_STIPPLE_HINT_PGI")]
    FullStippleHintPGI = 107033,

    [NativeName("GL_CLIP_NEAR_HINT_PGI")]
    ClipNearHintPGI = 107040,

    [NativeName("GL_CLIP_FAR_HINT_PGI")]
    ClipFarHintPGI = 107041,

    [NativeName("GL_WIDE_LINE_HINT_PGI")]
    WideLineHintPGI = 107042,

    [NativeName("GL_BACK_NORMALS_HINT_PGI")]
    BackNormalsHintPGI = 107043,

    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHintPGI = 107050,

    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHintPGI = 107051,

    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHintPGI = 107052,

    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHintPGI = 107053,

    [NativeName("GL_GENERATE_MIPMAP_HINT_SGIS")]
    GenerateMipmapHintSGIS = 33170,

    [NativeName("GL_CONVOLUTION_HINT_SGIX")]
    ConvolutionHintSGIX = 33558,

    [NativeName("GL_SCALEBIAS_HINT_SGIX")]
    ScalebiasHintSGIX = 33570,

    [NativeName("GL_TEXTURE_MULTI_BUFFER_HINT_SGIX")]
    TextureMultiBufferHintSGIX = 33070,

    [NativeName("GL_VERTEX_PRECLIP_SGIX")]
    VertexPreclipSGIX = 33774,

    [NativeName("GL_VERTEX_PRECLIP_HINT_SGIX")]
    VertexPreclipHintSGIX = 33775,

    [NativeName("GL_PHONG_HINT_WIN")]
    PhongHintWIN = 33003,

    [NativeName("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
    FragmentShaderDerivativeHintOES = 35723,

    [NativeName("GL_BINNING_CONTROL_HINT_QCOM")]
    BinningControlHintQCOM = 36784,
}
