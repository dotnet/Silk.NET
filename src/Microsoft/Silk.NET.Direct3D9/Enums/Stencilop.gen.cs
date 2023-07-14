// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSTENCILOP")]
    public enum Stencilop : int
    {
        [Obsolete("Deprecated in favour of \"Keep\"")]
        [NativeName("Name", "D3DSTENCILOP_KEEP")]
        StencilopKeep = 0x1,
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "D3DSTENCILOP_ZERO")]
        StencilopZero = 0x2,
        [Obsolete("Deprecated in favour of \"Replace\"")]
        [NativeName("Name", "D3DSTENCILOP_REPLACE")]
        StencilopReplace = 0x3,
        [Obsolete("Deprecated in favour of \"Incrsat\"")]
        [NativeName("Name", "D3DSTENCILOP_INCRSAT")]
        StencilopIncrsat = 0x4,
        [Obsolete("Deprecated in favour of \"Decrsat\"")]
        [NativeName("Name", "D3DSTENCILOP_DECRSAT")]
        StencilopDecrsat = 0x5,
        [Obsolete("Deprecated in favour of \"Invert\"")]
        [NativeName("Name", "D3DSTENCILOP_INVERT")]
        StencilopInvert = 0x6,
        [Obsolete("Deprecated in favour of \"Incr\"")]
        [NativeName("Name", "D3DSTENCILOP_INCR")]
        StencilopIncr = 0x7,
        [Obsolete("Deprecated in favour of \"Decr\"")]
        [NativeName("Name", "D3DSTENCILOP_DECR")]
        StencilopDecr = 0x8,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSTENCILOP_FORCE_DWORD")]
        StencilopForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSTENCILOP_KEEP")]
        Keep = 0x1,
        [NativeName("Name", "D3DSTENCILOP_ZERO")]
        Zero = 0x2,
        [NativeName("Name", "D3DSTENCILOP_REPLACE")]
        Replace = 0x3,
        [NativeName("Name", "D3DSTENCILOP_INCRSAT")]
        Incrsat = 0x4,
        [NativeName("Name", "D3DSTENCILOP_DECRSAT")]
        Decrsat = 0x5,
        [NativeName("Name", "D3DSTENCILOP_INVERT")]
        Invert = 0x6,
        [NativeName("Name", "D3DSTENCILOP_INCR")]
        Incr = 0x7,
        [NativeName("Name", "D3DSTENCILOP_DECR")]
        Decr = 0x8,
        [NativeName("Name", "D3DSTENCILOP_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
