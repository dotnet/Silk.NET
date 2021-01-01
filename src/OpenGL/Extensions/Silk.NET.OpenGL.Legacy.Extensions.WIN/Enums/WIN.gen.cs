// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.WIN
{
    [NativeName("Name", "GLenum")]
    public enum WIN : int
    {
        [NativeName("Name", "GL_PHONG_WIN")]
        PhongWin = 0x80EA,
        [NativeName("Name", "GL_PHONG_HINT_WIN")]
        PhongHintWin = 0x80EB,
        [NativeName("Name", "GL_FOG_SPECULAR_TEXTURE_WIN")]
        FogSpecularTextureWin = 0x80EC,
    }
}
