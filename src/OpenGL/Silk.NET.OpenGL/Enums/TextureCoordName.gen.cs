// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureCoordName")]
    public enum TextureCoordName : int
    {
        [NativeName("Name", "GL_TEXTURE_GEN_STR_OES")]
        TextureGenStrOes = 0x8D60,
    }
}
