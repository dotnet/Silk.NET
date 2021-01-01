// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "LightEnvParameterSGIX")]
    public enum LightEnvParameterSGIX : int
    {
        [NativeName("Name", "GL_LIGHT_ENV_MODE_SGIX")]
        LightEnvModeSgix = 0x8407,
    }
}
