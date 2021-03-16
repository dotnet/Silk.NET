// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureFilterFuncSGIS")]
    public enum TextureFilterFuncSGIS : int
    {
        [NativeName("Name", "GL_FILTER4_SGIS")]
        Filter4Sgis = 0x8146,
    }
}
