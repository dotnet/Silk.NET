// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDECLTYPE")]
    public enum Decltype : int
    {
        [Obsolete("Deprecated in favour of \"Float1\"")]
        [NativeName("Name", "D3DDECLTYPE_FLOAT1")]
        DecltypeFloat1 = 0x0,
        [Obsolete("Deprecated in favour of \"Float2\"")]
        [NativeName("Name", "D3DDECLTYPE_FLOAT2")]
        DecltypeFloat2 = 0x1,
        [Obsolete("Deprecated in favour of \"Float3\"")]
        [NativeName("Name", "D3DDECLTYPE_FLOAT3")]
        DecltypeFloat3 = 0x2,
        [Obsolete("Deprecated in favour of \"Float4\"")]
        [NativeName("Name", "D3DDECLTYPE_FLOAT4")]
        DecltypeFloat4 = 0x3,
        [Obsolete("Deprecated in favour of \"D3Dcolor\"")]
        [NativeName("Name", "D3DDECLTYPE_D3DCOLOR")]
        DecltypeD3Dcolor = 0x4,
        [Obsolete("Deprecated in favour of \"Ubyte4\"")]
        [NativeName("Name", "D3DDECLTYPE_UBYTE4")]
        DecltypeUbyte4 = 0x5,
        [Obsolete("Deprecated in favour of \"Short2\"")]
        [NativeName("Name", "D3DDECLTYPE_SHORT2")]
        DecltypeShort2 = 0x6,
        [Obsolete("Deprecated in favour of \"Short4\"")]
        [NativeName("Name", "D3DDECLTYPE_SHORT4")]
        DecltypeShort4 = 0x7,
        [Obsolete("Deprecated in favour of \"Ubyte4N\"")]
        [NativeName("Name", "D3DDECLTYPE_UBYTE4N")]
        DecltypeUbyte4N = 0x8,
        [Obsolete("Deprecated in favour of \"Short2N\"")]
        [NativeName("Name", "D3DDECLTYPE_SHORT2N")]
        DecltypeShort2N = 0x9,
        [Obsolete("Deprecated in favour of \"Short4N\"")]
        [NativeName("Name", "D3DDECLTYPE_SHORT4N")]
        DecltypeShort4N = 0xA,
        [Obsolete("Deprecated in favour of \"Ushort2N\"")]
        [NativeName("Name", "D3DDECLTYPE_USHORT2N")]
        DecltypeUshort2N = 0xB,
        [Obsolete("Deprecated in favour of \"Ushort4N\"")]
        [NativeName("Name", "D3DDECLTYPE_USHORT4N")]
        DecltypeUshort4N = 0xC,
        [Obsolete("Deprecated in favour of \"Udec3\"")]
        [NativeName("Name", "D3DDECLTYPE_UDEC3")]
        DecltypeUdec3 = 0xD,
        [Obsolete("Deprecated in favour of \"Dec3N\"")]
        [NativeName("Name", "D3DDECLTYPE_DEC3N")]
        DecltypeDec3N = 0xE,
        [Obsolete("Deprecated in favour of \"Float162\"")]
        [NativeName("Name", "D3DDECLTYPE_FLOAT16_2")]
        DecltypeFloat162 = 0xF,
        [Obsolete("Deprecated in favour of \"Float164\"")]
        [NativeName("Name", "D3DDECLTYPE_FLOAT16_4")]
        DecltypeFloat164 = 0x10,
        [Obsolete("Deprecated in favour of \"Unused\"")]
        [NativeName("Name", "D3DDECLTYPE_UNUSED")]
        DecltypeUnused = 0x11,
        [NativeName("Name", "D3DDECLTYPE_FLOAT1")]
        Float1 = 0x0,
        [NativeName("Name", "D3DDECLTYPE_FLOAT2")]
        Float2 = 0x1,
        [NativeName("Name", "D3DDECLTYPE_FLOAT3")]
        Float3 = 0x2,
        [NativeName("Name", "D3DDECLTYPE_FLOAT4")]
        Float4 = 0x3,
        [NativeName("Name", "D3DDECLTYPE_D3DCOLOR")]
        D3Dcolor = 0x4,
        [NativeName("Name", "D3DDECLTYPE_UBYTE4")]
        Ubyte4 = 0x5,
        [NativeName("Name", "D3DDECLTYPE_SHORT2")]
        Short2 = 0x6,
        [NativeName("Name", "D3DDECLTYPE_SHORT4")]
        Short4 = 0x7,
        [NativeName("Name", "D3DDECLTYPE_UBYTE4N")]
        Ubyte4N = 0x8,
        [NativeName("Name", "D3DDECLTYPE_SHORT2N")]
        Short2N = 0x9,
        [NativeName("Name", "D3DDECLTYPE_SHORT4N")]
        Short4N = 0xA,
        [NativeName("Name", "D3DDECLTYPE_USHORT2N")]
        Ushort2N = 0xB,
        [NativeName("Name", "D3DDECLTYPE_USHORT4N")]
        Ushort4N = 0xC,
        [NativeName("Name", "D3DDECLTYPE_UDEC3")]
        Udec3 = 0xD,
        [NativeName("Name", "D3DDECLTYPE_DEC3N")]
        Dec3N = 0xE,
        [NativeName("Name", "D3DDECLTYPE_FLOAT16_2")]
        Float162 = 0xF,
        [NativeName("Name", "D3DDECLTYPE_FLOAT16_4")]
        Float164 = 0x10,
        [NativeName("Name", "D3DDECLTYPE_UNUSED")]
        Unused = 0x11,
    }
}
