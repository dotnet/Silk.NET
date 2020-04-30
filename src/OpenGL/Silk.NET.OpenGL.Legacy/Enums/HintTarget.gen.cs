// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy
{
    public enum HintTarget
    {
        PerspectiveCorrectionHint = 0xC50,
        PointSmoothHint = 0xC51,
        LineSmoothHint = 0xC52,
        PolygonSmoothHint = 0xC53,
        FogHint = 0xC54,
        PackCmykHintExt = 0x800E,
        UnpackCmykHintExt = 0x800F,
        PhongHintWin = 0x80EB,
        ClipVolumeClippingHintExt = 0x80F0,
        TextureMultiBufferHintSgix = 0x812E,
        GenerateMipmapHint = 0x8192,
        GenerateMipmapHintSgis = 0x8192,
        ProgramBinaryRetrievableHint = 0x8257,
        ConvolutionHintSgix = 0x8316,
        ScalebiasHintSgix = 0x8322,
        LineQualityHintSgix = 0x835B,
        VertexPreclipSgix = 0x83EE,
        VertexPreclipHintSgix = 0x83EF,
        TextureCompressionHint = 0x84EF,
        TextureCompressionHintArb = 0x84EF,
        VertexArrayStorageHintApple = 0x851F,
        MultisampleFilterHintNV = 0x8534,
        TransformHintApple = 0x85B1,
        TextureStorageHintApple = 0x85BC,
        FragmentShaderDerivativeHint = 0x8B8B,
        FragmentShaderDerivativeHintArb = 0x8B8B,
        FragmentShaderDerivativeHintOes = 0x8B8B,
        BinningControlHintQCom = 0x8FB0,
        PreferDoublebufferHintPgi = 0x1A1F8,
        ConserveMemoryHintPgi = 0x1A1FD,
        ReclaimMemoryHintPgi = 0x1A1FE,
        NativeGraphicsBeginHintPgi = 0x1A203,
        NativeGraphicsEndHintPgi = 0x1A204,
        AlwaysFastHintPgi = 0x1A20C,
        AlwaysSoftHintPgi = 0x1A20D,
        AllowDrawObjHintPgi = 0x1A20E,
        AllowDrawWinHintPgi = 0x1A20F,
        AllowDrawFrgHintPgi = 0x1A210,
        AllowDrawMemHintPgi = 0x1A211,
        StrictDepthfuncHintPgi = 0x1A216,
        StrictLightingHintPgi = 0x1A217,
        StrictScissorHintPgi = 0x1A218,
        FullStippleHintPgi = 0x1A219,
        ClipNearHintPgi = 0x1A220,
        ClipFarHintPgi = 0x1A221,
        WideLineHintPgi = 0x1A222,
        BackNormalsHintPgi = 0x1A223,
        VertexDataHintPgi = 0x1A22A,
        VertexConsistentHintPgi = 0x1A22B,
        MaterialSideHintPgi = 0x1A22C,
        MaxVertexHintPgi = 0x1A22D,
    }
}
