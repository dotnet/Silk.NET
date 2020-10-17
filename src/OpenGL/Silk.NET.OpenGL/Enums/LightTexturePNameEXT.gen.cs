// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "LightTexturePNameEXT")]
    public enum LightTexturePNameEXT
    {
        [NativeName("Name", "GL_ATTENUATION_EXT")]
        AttenuationExt = 0x834D,
        [NativeName("Name", "GL_SHADOW_ATTENUATION_EXT")]
        ShadowAttenuationExt = 0x834E,
    }
}
