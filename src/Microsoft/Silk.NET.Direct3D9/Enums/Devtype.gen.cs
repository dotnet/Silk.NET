// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVTYPE")]
    public enum Devtype : int
    {
        [NativeName("Name", "D3DDEVTYPE_HAL")]
        DevtypeHal = 0x1,
        [NativeName("Name", "D3DDEVTYPE_REF")]
        DevtypeRef = 0x2,
        [NativeName("Name", "D3DDEVTYPE_SW")]
        DevtypeSW = 0x3,
        [NativeName("Name", "D3DDEVTYPE_NULLREF")]
        DevtypeNullref = 0x4,
        [NativeName("Name", "D3DDEVTYPE_FORCE_DWORD")]
        DevtypeForceDword = 0x7FFFFFFF,
    }
}
