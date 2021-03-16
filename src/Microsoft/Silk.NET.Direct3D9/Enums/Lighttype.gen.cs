// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DLIGHTTYPE")]
    public enum Lighttype : int
    {
        [NativeName("Name", "D3DLIGHT_POINT")]
        LightPoint = 0x1,
        [NativeName("Name", "D3DLIGHT_SPOT")]
        LightSpot = 0x2,
        [NativeName("Name", "D3DLIGHT_DIRECTIONAL")]
        LightDirectional = 0x3,
        [NativeName("Name", "D3DLIGHT_FORCE_DWORD")]
        LightForceDword = 0x7FFFFFFF,
    }
}
