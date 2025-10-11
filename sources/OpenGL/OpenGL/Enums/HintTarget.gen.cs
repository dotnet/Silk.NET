// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum HintTarget : uint
{
    LineSmoothHint = unchecked((uint)0x0C52),
    PolygonSmoothHint = unchecked((uint)0x0C53),
    PerspectiveCorrectionHint = unchecked((uint)0x0C50),
    PointSmoothHint = unchecked((uint)0x0C51),
    FogHint = unchecked((uint)0x0C54),
    TextureCompressionHint = unchecked((uint)0x84EF),
    GenerateMipmapHint = unchecked((uint)0x8192),
    FragmentShaderDerivativeHint = unchecked((uint)0x8B8B),
    ProgramBinaryRetrievableHint = unchecked((uint)0x8257),
    FragmentShaderDerivativeHintARB = unchecked((uint)0x8B8B),
    TextureCompressionHintARB = unchecked((uint)0x84EF),
    TextureStorageHintApple = unchecked((uint)0x85BC),
    TransformHintApple = unchecked((uint)0x85B1),
    VertexArrayStorageHintApple = unchecked((uint)0x851F),
    ClipVolumeClippingHintEXT = unchecked((uint)0x80F0),
    PackCmykHintEXT = unchecked((uint)0x800E),
    UnpackCmykHintEXT = unchecked((uint)0x800F),
    MultisampleFilterHintNV = unchecked((uint)0x8534),
    PreferDoublebufferHintPGI = unchecked((uint)0x1A1F8),
    ConserveMemoryHintPGI = unchecked((uint)0x1A1FD),
    ReclaimMemoryHintPGI = unchecked((uint)0x1A1FE),
    NativeGraphicsBeginHintPGI = unchecked((uint)0x1A203),
    NativeGraphicsEndHintPGI = unchecked((uint)0x1A204),
    AlwaysFastHintPGI = unchecked((uint)0x1A20C),
    AlwaysSoftHintPGI = unchecked((uint)0x1A20D),
    AllowDrawObjHintPGI = unchecked((uint)0x1A20E),
    AllowDrawWinHintPGI = unchecked((uint)0x1A20F),
    AllowDrawFrgHintPGI = unchecked((uint)0x1A210),
    AllowDrawMemHintPGI = unchecked((uint)0x1A211),
    StrictDepthfuncHintPGI = unchecked((uint)0x1A216),
    StrictLightingHintPGI = unchecked((uint)0x1A217),
    StrictScissorHintPGI = unchecked((uint)0x1A218),
    FullStippleHintPGI = unchecked((uint)0x1A219),
    ClipNearHintPGI = unchecked((uint)0x1A220),
    ClipFarHintPGI = unchecked((uint)0x1A221),
    WideLineHintPGI = unchecked((uint)0x1A222),
    BackNormalsHintPGI = unchecked((uint)0x1A223),
    VertexDataHintPGI = unchecked((uint)0x1A22A),
    VertexConsistentHintPGI = unchecked((uint)0x1A22B),
    MaterialSideHintPGI = unchecked((uint)0x1A22C),
    MaxVertexHintPGI = unchecked((uint)0x1A22D),
    GenerateMipmapHintSGIS = unchecked((uint)0x8192),
    ConvolutionHintSGIX = unchecked((uint)0x8316),
    ScalebiasHintSGIX = unchecked((uint)0x8322),
    TextureMultiBufferHintSGIX = unchecked((uint)0x812E),
    VertexPreclipSGIX = unchecked((uint)0x83EE),
    VertexPreclipHintSGIX = unchecked((uint)0x83EF),
    PhongHintWIN = unchecked((uint)0x80EB),
    FragmentShaderDerivativeHintOES = unchecked((uint)0x8B8B),
    BinningControlHintQCOM = unchecked((uint)0x8FB0),
}
