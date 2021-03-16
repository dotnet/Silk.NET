// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DFILLMODE")]
    public enum Fillmode : int
    {
        [NativeName("Name", "D3DFILL_POINT")]
        FillPoint = 0x1,
        [NativeName("Name", "D3DFILL_WIREFRAME")]
        FillWireframe = 0x2,
        [NativeName("Name", "D3DFILL_SOLID")]
        FillSolid = 0x3,
        [NativeName("Name", "D3DFILL_FORCE_DWORD")]
        FillForceDword = 0x7FFFFFFF,
    }
}
