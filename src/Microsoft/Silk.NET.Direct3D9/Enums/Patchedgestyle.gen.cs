// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPATCHEDGESTYLE")]
    public enum Patchedgestyle
    {
        [NativeName("Name", "D3DPATCHEDGE_DISCRETE")]
        PatchedgeDiscrete = 0x0,
        [NativeName("Name", "D3DPATCHEDGE_CONTINUOUS")]
        PatchedgeContinuous = 0x1,
        [NativeName("Name", "D3DPATCHEDGE_FORCE_DWORD")]
        PatchedgeForceDword = 0x7FFFFFFF,
    }
}
