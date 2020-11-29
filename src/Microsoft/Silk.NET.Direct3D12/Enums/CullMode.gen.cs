// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_CULL_MODE")]
    public enum CullMode
    {
        [NativeName("Name", "D3D12_CULL_MODE_NONE")]
        CullModeNone = 0x1,
        [NativeName("Name", "D3D12_CULL_MODE_FRONT")]
        CullModeFront = 0x2,
        [NativeName("Name", "D3D12_CULL_MODE_BACK")]
        CullModeBack = 0x3,
    }
}
