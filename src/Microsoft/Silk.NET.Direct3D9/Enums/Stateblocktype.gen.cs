// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSTATEBLOCKTYPE")]
    public enum Stateblocktype : int
    {
        [NativeName("Name", "D3DSBT_ALL")]
        SbtAll = 0x1,
        [NativeName("Name", "D3DSBT_PIXELSTATE")]
        SbtPixelstate = 0x2,
        [NativeName("Name", "D3DSBT_VERTEXSTATE")]
        SbtVertexstate = 0x3,
        [NativeName("Name", "D3DSBT_FORCE_DWORD")]
        SbtForceDword = 0x7FFFFFFF,
    }
}
