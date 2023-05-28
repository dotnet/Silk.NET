// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathColorFormat")]
    public enum PathColorFormat : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
        [NativeName("Name", "GL_RGBA")]
        Rgba = 0x1908,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE")]
        Luminance = 0x1909,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE_ALPHA")]
        LuminanceAlpha = 0x190A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INTENSITY")]
        Intensity = 0x8049,
    }
}
