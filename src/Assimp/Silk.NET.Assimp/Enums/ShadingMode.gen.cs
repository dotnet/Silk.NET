// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiShadingMode")]
    public enum ShadingMode : int
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
        [NativeName("Name", "aiShadingMode_Unlit")]
        ShadingModeUnlit = 0x9,
        [NativeName("Name", "aiShadingMode_Fresnel")]
        ShadingModeFresnel = 0xA,
        [NativeName("Name", "aiShadingMode_PBR_BRDF")]
        ShadingModePbrBrdf = 0xB,
    }
}
