// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCULL")]
    public enum Cull
    {
        [NativeName("Name", "D3DCULL_NONE")]
        CullNone = 0x1,
        [NativeName("Name", "D3DCULL_CW")]
        CullCW = 0x2,
        [NativeName("Name", "D3DCULL_CCW")]
        CullCcw = 0x3,
        [NativeName("Name", "D3DCULL_FORCE_DWORD")]
        CullForceDword = 0x7FFFFFFF,
    }
}
