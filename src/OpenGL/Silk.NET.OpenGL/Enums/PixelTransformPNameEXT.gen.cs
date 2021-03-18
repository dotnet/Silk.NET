// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
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
