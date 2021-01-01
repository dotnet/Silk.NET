// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_MISCTYPE_OFFSETS")]
    public enum ShaderMisctypeOffsets : int
    {
        [NativeName("Name", "D3DSMO_POSITION")]
        SmoPosition = 0x0,
        [NativeName("Name", "D3DSMO_FACE")]
        SmoFace = 0x1,
    }
}
