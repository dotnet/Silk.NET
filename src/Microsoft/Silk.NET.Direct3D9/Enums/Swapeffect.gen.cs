// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSWAPEFFECT")]
    public enum Swapeffect : int
    {
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "D3DSWAPEFFECT_DISCARD")]
        SwapeffectDiscard = 0x1,
        [Obsolete("Deprecated in favour of \"Flip\"")]
        [NativeName("Name", "D3DSWAPEFFECT_FLIP")]
        SwapeffectFlip = 0x2,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D3DSWAPEFFECT_COPY")]
        SwapeffectCopy = 0x3,
        [Obsolete("Deprecated in favour of \"Overlay\"")]
        [NativeName("Name", "D3DSWAPEFFECT_OVERLAY")]
        SwapeffectOverlay = 0x4,
        [Obsolete("Deprecated in favour of \"Flipex\"")]
        [NativeName("Name", "D3DSWAPEFFECT_FLIPEX")]
        SwapeffectFlipex = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSWAPEFFECT_FORCE_DWORD")]
        SwapeffectForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSWAPEFFECT_DISCARD")]
        Discard = 0x1,
        [NativeName("Name", "D3DSWAPEFFECT_FLIP")]
        Flip = 0x2,
        [NativeName("Name", "D3DSWAPEFFECT_COPY")]
        Copy = 0x3,
        [NativeName("Name", "D3DSWAPEFFECT_OVERLAY")]
        Overlay = 0x4,
        [NativeName("Name", "D3DSWAPEFFECT_FLIPEX")]
        Flipex = 0x5,
        [NativeName("Name", "D3DSWAPEFFECT_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
