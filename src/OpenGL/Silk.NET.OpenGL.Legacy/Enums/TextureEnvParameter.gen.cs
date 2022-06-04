// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureEnvParameter")]
    public enum TextureEnvParameter : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_TEXTURE_ENV_MODE")]
        TextureEnvMode = 0x2200,
        [System.Obsolete]
        [NativeName("Name", "GL_TEXTURE_ENV_COLOR")]
        TextureEnvColor = 0x2201,
    }
}
