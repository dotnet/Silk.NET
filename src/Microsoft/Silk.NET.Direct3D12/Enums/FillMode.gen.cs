// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FILL_MODE")]
    public enum FillMode
    {
        [NativeName("Name", "D3D12_FILL_MODE_WIREFRAME")]
        FillModeWireframe = 0x2,
        [NativeName("Name", "D3D12_FILL_MODE_SOLID")]
        FillModeSolid = 0x3,
    }
}
