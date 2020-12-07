// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "MaterialParameter")]
    public enum MaterialParameter
    {
        [NativeName("Name", "GL_AMBIENT")]
        Ambient = 0x1200,
        [NativeName("Name", "GL_DIFFUSE")]
        Diffuse = 0x1201,
        [NativeName("Name", "GL_SPECULAR")]
        Specular = 0x1202,
        [NativeName("Name", "GL_EMISSION")]
        Emission = 0x1600,
        [NativeName("Name", "GL_SHININESS")]
        Shininess = 0x1601,
        [NativeName("Name", "GL_AMBIENT_AND_DIFFUSE")]
        AmbientAndDiffuse = 0x1602,
        [NativeName("Name", "GL_COLOR_INDEXES")]
        ColorIndexes = 0x1603,
    }
}
