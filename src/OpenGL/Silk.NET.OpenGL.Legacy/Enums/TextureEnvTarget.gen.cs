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
        [NativeName("Name", "GL_TEXTURE_ENV")]
        TextureEnv = 0x2300,
    }
}
