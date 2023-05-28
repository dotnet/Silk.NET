// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexShaderTextureUnitParameter")]
    public enum VertexShaderTextureUnitParameter : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_TEXTURE_COORDS")]
        CurrentTextureCoords = 0xB03,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_MATRIX")]
        TextureMatrix = 0xBA8,
    }
}
