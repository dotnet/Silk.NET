// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelTexGenParameterNameSGIS")]
    public enum PixelTexGenParameterNameSGIS : int
    {
        [Obsolete("Deprecated in favour of \"RgbSourceSgis\"")]
        [NativeName("Name", "GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
        PixelFragmentRgbSourceSgis = 0x8354,
        [Obsolete("Deprecated in favour of \"AlphaSourceSgis\"")]
        [NativeName("Name", "GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
        PixelFragmentAlphaSourceSgis = 0x8355,
        [NativeName("Name", "GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
        RgbSourceSgis = 0x8354,
        [NativeName("Name", "GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
        AlphaSourceSgis = 0x8355,
    }
}
