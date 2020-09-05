// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FILL_MODE")]
    public enum FillMode
    {
        [NativeName("Name", "D3D11_FILL_WIREFRAME")]
        FillWireframe = 0x2,
        [NativeName("Name", "D3D11_FILL_SOLID")]
        FillSolid = 0x3,
    }
}
