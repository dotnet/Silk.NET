// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_MIN_PRECISION")]
    public enum ShaderMinPrecision
    {
        [NativeName("Name", "D3DMP_DEFAULT")]
        MPDefault = 0x0,
        [NativeName("Name", "D3DMP_16")]
        MP16 = 0x1,
        [NativeName("Name", "D3DMP_2_8")]
        MP28 = 0x2,
    }
}
