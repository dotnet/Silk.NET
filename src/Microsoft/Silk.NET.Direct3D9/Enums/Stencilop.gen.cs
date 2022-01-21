// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DSTENCILOP")]
    public enum Stencilop : int
    {
        [NativeName("Name", "D3DSTENCILOP_KEEP")]
        StencilopKeep = 0x1,
        [NativeName("Name", "D3DSTENCILOP_ZERO")]
        StencilopZero = 0x2,
        [NativeName("Name", "D3DSTENCILOP_REPLACE")]
        StencilopReplace = 0x3,
        [NativeName("Name", "D3DSTENCILOP_INCRSAT")]
        StencilopIncrsat = 0x4,
        [NativeName("Name", "D3DSTENCILOP_DECRSAT")]
        StencilopDecrsat = 0x5,
        [NativeName("Name", "D3DSTENCILOP_INVERT")]
        StencilopInvert = 0x6,
        [NativeName("Name", "D3DSTENCILOP_INCR")]
        StencilopIncr = 0x7,
        [NativeName("Name", "D3DSTENCILOP_DECR")]
        StencilopDecr = 0x8,
        [NativeName("Name", "D3DSTENCILOP_FORCE_DWORD")]
        StencilopForceDword = 0x7FFFFFFF,
    }
}
