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
        [Obsolete("Deprecated in favour of \"Index\"")]
        [NativeName("Name", "GL_FOG_INDEX")]
        FogIndex = 0xB61,
        [Obsolete("Deprecated in favour of \"Density\"")]
        [NativeName("Name", "GL_FOG_DENSITY")]
        FogDensity = 0xB62,
        [Obsolete("Deprecated in favour of \"Start\"")]
        [NativeName("Name", "GL_FOG_START")]
        FogStart = 0xB63,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "GL_FOG_END")]
        FogEnd = 0xB64,
        [Obsolete("Deprecated in favour of \"Mode\"")]
        [NativeName("Name", "GL_FOG_MODE")]
        FogMode = 0xB65,
        [Obsolete("Deprecated in favour of \"CoordSrc\"")]
        [NativeName("Name", "GL_FOG_COORD_SRC")]
        FogCoordSrc = 0x8450,
        [System.Obsolete]
        [NativeName("Name", "GL_FOG_INDEX")]
        Index = 0xB61,
        [System.Obsolete]
        [NativeName("Name", "GL_FOG_DENSITY")]
        Density = 0xB62,
        [System.Obsolete]
        [NativeName("Name", "GL_FOG_START")]
        Start = 0xB63,
        [System.Obsolete]
        [NativeName("Name", "GL_FOG_END")]
        End = 0xB64,
        [System.Obsolete]
        [NativeName("Name", "GL_FOG_MODE")]
        Mode = 0xB65,
        [System.Obsolete]
        [NativeName("Name", "GL_FOG_COORD_SRC")]
        CoordSrc = 0x8450,
    }
}
