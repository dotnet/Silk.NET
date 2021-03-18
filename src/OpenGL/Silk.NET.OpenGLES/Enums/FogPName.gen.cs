// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FogPName")]
    public enum FogPName : int
    {
        [NativeName("Name", "GL_FOG_INDEX")]
        FogIndex = 0xB61,
        [NativeName("Name", "GL_FOG_DENSITY")]
        FogDensity = 0xB62,
        [NativeName("Name", "GL_FOG_START")]
        FogStart = 0xB63,
        [NativeName("Name", "GL_FOG_END")]
        FogEnd = 0xB64,
        [NativeName("Name", "GL_FOG_MODE")]
        FogMode = 0xB65,
        [NativeName("Name", "GL_FOG_COORD_SRC")]
        FogCoordSrc = 0x8450,
    }
}
