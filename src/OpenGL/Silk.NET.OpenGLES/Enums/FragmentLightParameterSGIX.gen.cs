// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum FragmentLightParameterSGIX
    {
        Ambient = 0x1200,
        Diffuse = 0x1201,
        Specular = 0x1202,
        Position = 0x1203,
        SpotDirection = 0x1204,
        SpotExponent = 0x1205,
        SpotCutoff = 0x1206,
        ConstantAttenuation = 0x1207,
        LinearAttenuation = 0x1208,
        QuadraticAttenuation = 0x1209,
    }
}
