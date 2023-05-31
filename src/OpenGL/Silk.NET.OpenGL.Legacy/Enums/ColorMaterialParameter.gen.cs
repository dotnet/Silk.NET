// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ColorMaterialParameter")]
    public enum ColorMaterialParameter : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AMBIENT")]
        Ambient = 0x1200,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_DIFFUSE")]
        Diffuse = 0x1201,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SPECULAR")]
        Specular = 0x1202,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EMISSION")]
        Emission = 0x1600,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AMBIENT_AND_DIFFUSE")]
        AmbientAndDiffuse = 0x1602,
    }
}
