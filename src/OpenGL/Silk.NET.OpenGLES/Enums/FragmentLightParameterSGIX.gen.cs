// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FragmentLightParameterSGIX")]
    public enum FragmentLightParameterSGIX
    {
        [NativeName("Name", "GL_AMBIENT")]
        Ambient = 0x1200,
        [NativeName("Name", "GL_DIFFUSE")]
        Diffuse = 0x1201,
        [NativeName("Name", "GL_SPECULAR")]
        Specular = 0x1202,
        [NativeName("Name", "GL_POSITION")]
        Position = 0x1203,
        [NativeName("Name", "GL_SPOT_DIRECTION")]
        SpotDirection = 0x1204,
        [NativeName("Name", "GL_SPOT_EXPONENT")]
        SpotExponent = 0x1205,
        [NativeName("Name", "GL_SPOT_CUTOFF")]
        SpotCutoff = 0x1206,
        [NativeName("Name", "GL_CONSTANT_ATTENUATION")]
        ConstantAttenuation = 0x1207,
        [NativeName("Name", "GL_LINEAR_ATTENUATION")]
        LinearAttenuation = 0x1208,
        [NativeName("Name", "GL_QUADRATIC_ATTENUATION")]
        QuadraticAttenuation = 0x1209,
    }
}
