// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_SWAP_EFFECT")]
    public enum SwapEffect : int
    {
        [NativeName("Name", "DXGI_SWAP_EFFECT_DISCARD")]
        SwapEffectDiscard = 0x0,
        [NativeName("Name", "DXGI_SWAP_EFFECT_SEQUENTIAL")]
        SwapEffectSequential = 0x1,
        [NativeName("Name", "DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL")]
        SwapEffectFlipSequential = 0x3,
        [NativeName("Name", "DXGI_SWAP_EFFECT_FLIP_DISCARD")]
        SwapEffectFlipDiscard = 0x4,
    }
}
