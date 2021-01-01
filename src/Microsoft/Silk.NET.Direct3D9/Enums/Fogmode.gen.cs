// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DFOGMODE")]
    public enum Fogmode : int
    {
        [NativeName("Name", "D3DFOG_NONE")]
        FogNone = 0x0,
        [NativeName("Name", "D3DFOG_EXP")]
        FogExp = 0x1,
        [NativeName("Name", "D3DFOG_EXP2")]
        FogExp2 = 0x2,
        [NativeName("Name", "D3DFOG_LINEAR")]
        FogLinear = 0x3,
        [NativeName("Name", "D3DFOG_FORCE_DWORD")]
        FogForceDword = 0x7FFFFFFF,
    }
}
