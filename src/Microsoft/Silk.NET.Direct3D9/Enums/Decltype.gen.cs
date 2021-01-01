// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDECLTYPE")]
    public enum Decltype : int
    {
        [NativeName("Name", "D3DDECLTYPE_FLOAT1")]
        DecltypeFloat1 = 0x0,
        [NativeName("Name", "D3DDECLTYPE_FLOAT2")]
        DecltypeFloat2 = 0x1,
        [NativeName("Name", "D3DDECLTYPE_FLOAT3")]
        DecltypeFloat3 = 0x2,
        [NativeName("Name", "D3DDECLTYPE_FLOAT4")]
        DecltypeFloat4 = 0x3,
        [NativeName("Name", "D3DDECLTYPE_D3DCOLOR")]
        DecltypeD3Dcolor = 0x4,
        [NativeName("Name", "D3DDECLTYPE_UBYTE4")]
        DecltypeUbyte4 = 0x5,
        [NativeName("Name", "D3DDECLTYPE_SHORT2")]
        DecltypeShort2 = 0x6,
        [NativeName("Name", "D3DDECLTYPE_SHORT4")]
        DecltypeShort4 = 0x7,
        [NativeName("Name", "D3DDECLTYPE_UBYTE4N")]
        DecltypeUbyte4N = 0x8,
        [NativeName("Name", "D3DDECLTYPE_SHORT2N")]
        DecltypeShort2N = 0x9,
        [NativeName("Name", "D3DDECLTYPE_SHORT4N")]
        DecltypeShort4N = 0xA,
        [NativeName("Name", "D3DDECLTYPE_USHORT2N")]
        DecltypeUshort2N = 0xB,
        [NativeName("Name", "D3DDECLTYPE_USHORT4N")]
        DecltypeUshort4N = 0xC,
        [NativeName("Name", "D3DDECLTYPE_UDEC3")]
        DecltypeUdec3 = 0xD,
        [NativeName("Name", "D3DDECLTYPE_DEC3N")]
        DecltypeDec3N = 0xE,
        [NativeName("Name", "D3DDECLTYPE_FLOAT16_2")]
        DecltypeFloat162 = 0xF,
        [NativeName("Name", "D3DDECLTYPE_FLOAT16_4")]
        DecltypeFloat164 = 0x10,
        [NativeName("Name", "D3DDECLTYPE_UNUSED")]
        DecltypeUnused = 0x11,
    }
}
