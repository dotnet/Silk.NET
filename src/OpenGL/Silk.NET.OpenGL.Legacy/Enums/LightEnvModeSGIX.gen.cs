// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "LightEnvModeSGIX")]
    public enum LightEnvModeSGIX
    {
        [NativeName("Name", "GL_ADD")]
        Add = 0x104,
        [NativeName("Name", "GL_REPLACE")]
        Replace = 0x1E01,
        [NativeName("Name", "GL_MODULATE")]
        Modulate = 0x2100,
    }
}
