// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_EFFECT")]
    public enum SwapEffect
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
