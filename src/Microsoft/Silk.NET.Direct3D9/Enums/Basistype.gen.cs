// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBASISTYPE")]
    public enum Basistype
    {
        [NativeName("Name", "D3DBASIS_BEZIER")]
        BasisBezier = 0x0,
        [NativeName("Name", "D3DBASIS_BSPLINE")]
        BasisBspline = 0x1,
        [NativeName("Name", "D3DBASIS_CATMULL_ROM")]
        BasisCatmullRom = 0x2,
        [NativeName("Name", "D3DBASIS_FORCE_DWORD")]
        BasisForceDword = 0x7FFFFFFF,
    }
}
