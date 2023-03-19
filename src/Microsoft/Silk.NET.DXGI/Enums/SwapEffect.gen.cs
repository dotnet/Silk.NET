// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_EFFECT")]
    public enum SwapEffect : int
    {
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "DXGI_SWAP_EFFECT_DISCARD")]
        SwapEffectDiscard = 0x0,
        [Obsolete("Deprecated in favour of \"Sequential\"")]
        [NativeName("Name", "DXGI_SWAP_EFFECT_SEQUENTIAL")]
        SwapEffectSequential = 0x1,
        [Obsolete("Deprecated in favour of \"FlipSequential\"")]
        [NativeName("Name", "DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL")]
        SwapEffectFlipSequential = 0x3,
        [Obsolete("Deprecated in favour of \"FlipDiscard\"")]
        [NativeName("Name", "DXGI_SWAP_EFFECT_FLIP_DISCARD")]
        SwapEffectFlipDiscard = 0x4,
        [NativeName("Name", "DXGI_SWAP_EFFECT_DISCARD")]
        Discard = 0x0,
        [NativeName("Name", "DXGI_SWAP_EFFECT_SEQUENTIAL")]
        Sequential = 0x1,
        [NativeName("Name", "DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL")]
        FlipSequential = 0x3,
        [NativeName("Name", "DXGI_SWAP_EFFECT_FLIP_DISCARD")]
        FlipDiscard = 0x4,
    }
}
