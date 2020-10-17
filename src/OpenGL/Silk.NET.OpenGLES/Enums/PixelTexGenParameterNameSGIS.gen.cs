// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelTexGenParameterNameSGIS")]
    public enum PixelTexGenParameterNameSGIS
    {
        [NativeName("Name", "GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS")]
        PixelFragmentRgbSourceSgis = 0x8354,
        [NativeName("Name", "GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS")]
        PixelFragmentAlphaSourceSgis = 0x8355,
    }
}
