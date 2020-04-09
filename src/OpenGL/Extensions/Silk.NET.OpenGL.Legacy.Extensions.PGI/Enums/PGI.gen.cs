// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy.Extensions.PGI
{
    public enum PGI
    {
        PreferDoublebufferHintPgi = 0x1A1F8,
        ConserveMemoryHintPgi = 0x1A1FD,
        ReclaimMemoryHintPgi = 0x1A1FE,
        NativeGraphicsHandlePgi = 0x1A202,
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
        Color3BitPgi = 0x10000,
        Color4BitPgi = 0x20000,
        EdgeflagBitPgi = 0x40000,
        IndexBitPgi = 0x80000,
        MatAmbientBitPgi = 0x100000,
        MatAmbientAndDiffuseBitPgi = 0x200000,
        MatDiffuseBitPgi = 0x400000,
        MatEmissionBitPgi = 0x800000,
        MatColorIndexesBitPgi = 0x1000000,
        MatShininessBitPgi = 0x2000000,
        MatSpecularBitPgi = 0x4000000,
        NormalBitPgi = 0x8000000,
        Texcoord1BitPgi = 0x10000000,
        Texcoord2BitPgi = 0x20000000,
        Texcoord3BitPgi = 0x40000000,
        Texcoord4BitPgi = unchecked((int)0x80000000),
        Vertex23BitPgi = 0x4,
        Vertex4BitPgi = 0x8,
    }
}
