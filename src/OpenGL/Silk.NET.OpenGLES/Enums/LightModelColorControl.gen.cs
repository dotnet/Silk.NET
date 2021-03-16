// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "LightModelColorControl")]
    public enum LightModelColorControl : int
    {
        [NativeName("Name", "GL_SINGLE_COLOR")]
        SingleColor = 0x81F9,
        [NativeName("Name", "GL_SINGLE_COLOR_EXT")]
        SingleColorExt = 0x81F9,
        [NativeName("Name", "GL_SEPARATE_SPECULAR_COLOR")]
        SeparateSpecularColor = 0x81FA,
        [NativeName("Name", "GL_SEPARATE_SPECULAR_COLOR_EXT")]
        SeparateSpecularColorExt = 0x81FA,
    }
}
