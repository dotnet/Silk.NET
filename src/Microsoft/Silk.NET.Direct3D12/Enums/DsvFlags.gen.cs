// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DSV_FLAGS")]
    public enum DsvFlags
    {
        [NativeName("Name", "D3D12_DSV_FLAG_NONE")]
        DsvFlagNone = 0x0,
        [NativeName("Name", "D3D12_DSV_FLAG_READ_ONLY_DEPTH")]
        DsvFlagReadOnlyDepth = 0x1,
        [NativeName("Name", "D3D12_DSV_FLAG_READ_ONLY_STENCIL")]
        DsvFlagReadOnlyStencil = 0x2,
    }
}
