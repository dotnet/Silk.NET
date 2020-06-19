// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum VertexHintsMaskPGI
    {
        Vertex23BitPgi = 0x4,
        Vertex4BitPgi = 0x8,
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
    }
}
