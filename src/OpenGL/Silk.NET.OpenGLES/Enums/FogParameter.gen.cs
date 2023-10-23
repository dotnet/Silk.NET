// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FogParameter")]
    public enum FogParameter : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_INDEX")]
        FogIndex = 0xB61,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_DENSITY")]
        FogDensity = 0xB62,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_START")]
        FogStart = 0xB63,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_END")]
        FogEnd = 0xB64,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_MODE")]
        FogMode = 0xB65,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_COLOR")]
        FogColor = 0xB66,
        [Obsolete("Deprecated in favour of \"OffsetValueSgix\"")]
        [NativeName("Name", "GL_FOG_OFFSET_VALUE_SGIX")]
        FogOffsetValueSgix = 0x8199,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_INDEX")]
        Index = 0xB61,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_DENSITY")]
        Density = 0xB62,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_START")]
        Start = 0xB63,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_END")]
        End = 0xB64,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_MODE")]
        Mode = 0xB65,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_COLOR")]
        Color = 0xB66,
        [NativeName("Name", "GL_FOG_OFFSET_VALUE_SGIX")]
        OffsetValueSgix = 0x8199,
    }
}
