// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiShadingMode")]
    public enum ShadingMode
    {
        [NativeName("Name", "aiShadingMode_Flat")]
        ShadingModeFlat = 0x1,
        [NativeName("Name", "aiShadingMode_Gouraud")]
        ShadingModeGouraud = 0x2,
        [NativeName("Name", "aiShadingMode_Phong")]
        ShadingModePhong = 0x3,
        [NativeName("Name", "aiShadingMode_Blinn")]
        ShadingModeBlinn = 0x4,
        [NativeName("Name", "aiShadingMode_Toon")]
        ShadingModeToon = 0x5,
        [NativeName("Name", "aiShadingMode_OrenNayar")]
        ShadingModeOrenNayar = 0x6,
        [NativeName("Name", "aiShadingMode_Minnaert")]
        ShadingModeMinnaert = 0x7,
        [NativeName("Name", "aiShadingMode_CookTorrance")]
        ShadingModeCookTorrance = 0x8,
        [NativeName("Name", "aiShadingMode_NoShading")]
        ShadingModeNoShading = 0x9,
        [NativeName("Name", "aiShadingMode_Fresnel")]
        ShadingModeFresnel = 0xA,
    }
}
