// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum HintTarget : uint
{
    LineSmoothHint = 0x0C52,
    PolygonSmoothHint = 0x0C53,
    TextureCompressionHint = 0x84EF,
    FragmentShaderDerivativeHint = 0x8B8B,
    ProgramBinaryRetrievableHint = 0x8257,
    PerspectiveCorrectionHint = 0x0C50,
    PointSmoothHint = 0x0C51,
    FogHint = 0x0C54,
    GenerateMipmapHint = 0x8192,
    FragmentShaderDerivativeHintARB = 0x8B8B,
    TextureCompressionHintARB = 0x84EF,
    TextureStorageHintApple = 0x85BC,
    TransformHintApple = 0x85B1,
    VertexArrayStorageHintApple = 0x851F,
    ClipVolumeClippingHintEXT = 0x80F0,
    PackCmykHintEXT = 0x800E,
    UnpackCmykHintEXT = 0x800F,
    MultisampleFilterHintNV = 0x8534,
    PreferDoublebufferHintPGI = 0x1A1F8,
    ConserveMemoryHintPGI = 0x1A1FD,
    ReclaimMemoryHintPGI = 0x1A1FE,
    NativeGraphicsBeginHintPGI = 0x1A203,
    NativeGraphicsEndHintPGI = 0x1A204,
    AlwaysFastHintPGI = 0x1A20C,
    AlwaysSoftHintPGI = 0x1A20D,
    AllowDrawObjHintPGI = 0x1A20E,
    AllowDrawWinHintPGI = 0x1A20F,
    AllowDrawFrgHintPGI = 0x1A210,
    AllowDrawMemHintPGI = 0x1A211,
    StrictDepthfuncHintPGI = 0x1A216,
    StrictLightingHintPGI = 0x1A217,
    StrictScissorHintPGI = 0x1A218,
    FullStippleHintPGI = 0x1A219,
    ClipNearHintPGI = 0x1A220,
    ClipFarHintPGI = 0x1A221,
    WideLineHintPGI = 0x1A222,
    BackNormalsHintPGI = 0x1A223,
    VertexDataHintPGI = 0x1A22A,
    VertexConsistentHintPGI = 0x1A22B,
    MaterialSideHintPGI = 0x1A22C,
    MaxVertexHintPGI = 0x1A22D,
    GenerateMipmapHintSGIS = 0x8192,
    ConvolutionHintSGIX = 0x8316,
    ScalebiasHintSGIX = 0x8322,
    TextureMultiBufferHintSGIX = 0x812E,
    VertexPreclipSGIX = 0x83EE,
    VertexPreclipHintSGIX = 0x83EF,
    PhongHintWIN = 0x80EB,
    FragmentShaderDerivativeHintOES = 0x8B8B,
    BinningControlHintQCOM = 0x8FB0
}
