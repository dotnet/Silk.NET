// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
