// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelTransformPNameEXT")]
    public enum PixelTransformPNameEXT : int
    {
        [Obsolete("Deprecated in favour of \"MagFilterExt\"")]
        [NativeName("Name", "GL_PIXEL_MAG_FILTER_EXT")]
        PixelMagFilterExt = 0x8331,
        [Obsolete("Deprecated in favour of \"MinFilterExt\"")]
        [NativeName("Name", "GL_PIXEL_MIN_FILTER_EXT")]
        PixelMinFilterExt = 0x8332,
        [Obsolete("Deprecated in favour of \"CubicWeightExt\"")]
        [NativeName("Name", "GL_PIXEL_CUBIC_WEIGHT_EXT")]
        PixelCubicWeightExt = 0x8333,
        [NativeName("Name", "GL_PIXEL_MAG_FILTER_EXT")]
        MagFilterExt = 0x8331,
        [NativeName("Name", "GL_PIXEL_MIN_FILTER_EXT")]
        MinFilterExt = 0x8332,
        [NativeName("Name", "GL_PIXEL_CUBIC_WEIGHT_EXT")]
        CubicWeightExt = 0x8333,
    }
}
