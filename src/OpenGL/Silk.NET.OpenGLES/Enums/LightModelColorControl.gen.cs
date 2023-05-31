// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "LightModelColorControl")]
    public enum LightModelColorControl : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SINGLE_COLOR")]
        SingleColor = 0x81F9,
        [NativeName("Name", "GL_SINGLE_COLOR_EXT")]
        SingleColorExt = 0x81F9,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SEPARATE_SPECULAR_COLOR")]
        SeparateSpecularColor = 0x81FA,
        [NativeName("Name", "GL_SEPARATE_SPECULAR_COLOR_EXT")]
        SeparateSpecularColorExt = 0x81FA,
    }
}
