// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_CLEAR_FLAGS")]
    public enum ClearFlags
    {
        [NativeName("Name", "D3D12_CLEAR_FLAG_DEPTH")]
        ClearFlagDepth = 0x1,
        [NativeName("Name", "D3D12_CLEAR_FLAG_STENCIL")]
        ClearFlagStencil = 0x2,
    }
}
