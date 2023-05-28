// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureCoordName")]
    public enum TextureCoordName : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_S")]
        S = 0x2000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T")]
        T = 0x2001,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_R")]
        R = 0x2002,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_Q")]
        Q = 0x2003,
        [NativeName("Name", "GL_TEXTURE_GEN_STR_OES")]
        TextureGenStrOes = 0x8D60,
    }
}
