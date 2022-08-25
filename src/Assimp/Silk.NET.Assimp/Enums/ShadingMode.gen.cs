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
        [Obsolete("Deprecated in favour of \"Flat\"")]
        [NativeName("Name", "aiShadingMode_Flat")]
        ShadingModeFlat = 0x1,
        [Obsolete("Deprecated in favour of \"Gouraud\"")]
        [NativeName("Name", "aiShadingMode_Gouraud")]
        ShadingModeGouraud = 0x2,
        [Obsolete("Deprecated in favour of \"Phong\"")]
        [NativeName("Name", "aiShadingMode_Phong")]
        ShadingModePhong = 0x3,
        [Obsolete("Deprecated in favour of \"Blinn\"")]
        [NativeName("Name", "aiShadingMode_Blinn")]
        ShadingModeBlinn = 0x4,
        [Obsolete("Deprecated in favour of \"Toon\"")]
        [NativeName("Name", "aiShadingMode_Toon")]
        ShadingModeToon = 0x5,
        [Obsolete("Deprecated in favour of \"OrenNayar\"")]
        [NativeName("Name", "aiShadingMode_OrenNayar")]
        ShadingModeOrenNayar = 0x6,
        [Obsolete("Deprecated in favour of \"Minnaert\"")]
        [NativeName("Name", "aiShadingMode_Minnaert")]
        ShadingModeMinnaert = 0x7,
        [Obsolete("Deprecated in favour of \"CookTorrance\"")]
        [NativeName("Name", "aiShadingMode_CookTorrance")]
        ShadingModeCookTorrance = 0x8,
        [Obsolete("Deprecated in favour of \"NoShading\"")]
        [NativeName("Name", "aiShadingMode_NoShading")]
        ShadingModeNoShading = 0x9,
        [Obsolete("Deprecated in favour of \"Unlit\"")]
        [NativeName("Name", "aiShadingMode_Unlit")]
        ShadingModeUnlit = 0x9,
        [Obsolete("Deprecated in favour of \"Fresnel\"")]
        [NativeName("Name", "aiShadingMode_Fresnel")]
        ShadingModeFresnel = 0xA,
        [Obsolete("Deprecated in favour of \"PbrBrdf\"")]
        [NativeName("Name", "aiShadingMode_PBR_BRDF")]
        ShadingModePbrBrdf = 0xB,
        [NativeName("Name", "aiShadingMode_Flat")]
        Flat = 0x1,
        [NativeName("Name", "aiShadingMode_Gouraud")]
        Gouraud = 0x2,
        [NativeName("Name", "aiShadingMode_Phong")]
        Phong = 0x3,
        [NativeName("Name", "aiShadingMode_Blinn")]
        Blinn = 0x4,
        [NativeName("Name", "aiShadingMode_Toon")]
        Toon = 0x5,
        [NativeName("Name", "aiShadingMode_OrenNayar")]
        OrenNayar = 0x6,
        [NativeName("Name", "aiShadingMode_Minnaert")]
        Minnaert = 0x7,
        [NativeName("Name", "aiShadingMode_CookTorrance")]
        CookTorrance = 0x8,
        [NativeName("Name", "aiShadingMode_NoShading")]
        NoShading = 0x9,
        [NativeName("Name", "aiShadingMode_Unlit")]
        Unlit = 0x9,
        [NativeName("Name", "aiShadingMode_Fresnel")]
        Fresnel = 0xA,
        [NativeName("Name", "aiShadingMode_PBR_BRDF")]
        PbrBrdf = 0xB,
    }
}
