// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DSWAPEFFECT")]
    public enum Swapeffect : int
    {
        [NativeName("Name", "D3DSWAPEFFECT_DISCARD")]
        SwapeffectDiscard = 0x1,
        [NativeName("Name", "D3DSWAPEFFECT_FLIP")]
        SwapeffectFlip = 0x2,
        [NativeName("Name", "D3DSWAPEFFECT_COPY")]
        SwapeffectCopy = 0x3,
        [NativeName("Name", "D3DSWAPEFFECT_OVERLAY")]
        SwapeffectOverlay = 0x4,
        [NativeName("Name", "D3DSWAPEFFECT_FLIPEX")]
        SwapeffectFlipex = 0x5,
        [NativeName("Name", "D3DSWAPEFFECT_FORCE_DWORD")]
        SwapeffectForceDword = 0x7FFFFFFF,
    }
}
