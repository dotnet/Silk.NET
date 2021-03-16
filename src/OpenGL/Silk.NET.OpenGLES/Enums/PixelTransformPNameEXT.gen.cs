// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelTransformPNameEXT")]
    public enum PixelTransformPNameEXT : int
    {
        [NativeName("Name", "GL_PIXEL_MAG_FILTER_EXT")]
        PixelMagFilterExt = 0x8331,
        [NativeName("Name", "GL_PIXEL_MIN_FILTER_EXT")]
        PixelMinFilterExt = 0x8332,
        [NativeName("Name", "GL_PIXEL_CUBIC_WEIGHT_EXT")]
        PixelCubicWeightExt = 0x8333,
    }
}
