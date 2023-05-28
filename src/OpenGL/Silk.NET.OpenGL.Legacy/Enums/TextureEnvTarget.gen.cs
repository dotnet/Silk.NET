// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureEnvTarget")]
    public enum TextureEnvTarget : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_ENV")]
        TextureEnv = 0x2300,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_FILTER_CONTROL")]
        TextureFilterControl = 0x8500,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_SPRITE")]
        PointSprite = 0x8861,
    }
}
