// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ImageTransformPNameHP")]
    public enum ImageTransformPNameHP : int
    {
        [Obsolete("Deprecated in favour of \"ScaleXHP\"")]
        [NativeName("Name", "GL_IMAGE_SCALE_X_HP")]
        ImageScaleXHP = 0x8155,
        [Obsolete("Deprecated in favour of \"ScaleYHP\"")]
        [NativeName("Name", "GL_IMAGE_SCALE_Y_HP")]
        ImageScaleYHP = 0x8156,
        [Obsolete("Deprecated in favour of \"TranslateXHP\"")]
        [NativeName("Name", "GL_IMAGE_TRANSLATE_X_HP")]
        ImageTranslateXHP = 0x8157,
        [Obsolete("Deprecated in favour of \"TranslateYHP\"")]
        [NativeName("Name", "GL_IMAGE_TRANSLATE_Y_HP")]
        ImageTranslateYHP = 0x8158,
        [Obsolete("Deprecated in favour of \"RotateAngleHP\"")]
        [NativeName("Name", "GL_IMAGE_ROTATE_ANGLE_HP")]
        ImageRotateAngleHP = 0x8159,
        [Obsolete("Deprecated in favour of \"RotateOriginXHP\"")]
        [NativeName("Name", "GL_IMAGE_ROTATE_ORIGIN_X_HP")]
        ImageRotateOriginXHP = 0x815A,
        [Obsolete("Deprecated in favour of \"RotateOriginYHP\"")]
        [NativeName("Name", "GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
        ImageRotateOriginYHP = 0x815B,
        [Obsolete("Deprecated in favour of \"MagFilterHP\"")]
        [NativeName("Name", "GL_IMAGE_MAG_FILTER_HP")]
        ImageMagFilterHP = 0x815C,
        [Obsolete("Deprecated in favour of \"MinFilterHP\"")]
        [NativeName("Name", "GL_IMAGE_MIN_FILTER_HP")]
        ImageMinFilterHP = 0x815D,
        [Obsolete("Deprecated in favour of \"CubicWeightHP\"")]
        [NativeName("Name", "GL_IMAGE_CUBIC_WEIGHT_HP")]
        ImageCubicWeightHP = 0x815E,
        [NativeName("Name", "GL_IMAGE_SCALE_X_HP")]
        ScaleXHP = 0x8155,
        [NativeName("Name", "GL_IMAGE_SCALE_Y_HP")]
        ScaleYHP = 0x8156,
        [NativeName("Name", "GL_IMAGE_TRANSLATE_X_HP")]
        TranslateXHP = 0x8157,
        [NativeName("Name", "GL_IMAGE_TRANSLATE_Y_HP")]
        TranslateYHP = 0x8158,
        [NativeName("Name", "GL_IMAGE_ROTATE_ANGLE_HP")]
        RotateAngleHP = 0x8159,
        [NativeName("Name", "GL_IMAGE_ROTATE_ORIGIN_X_HP")]
        RotateOriginXHP = 0x815A,
        [NativeName("Name", "GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
        RotateOriginYHP = 0x815B,
        [NativeName("Name", "GL_IMAGE_MAG_FILTER_HP")]
        MagFilterHP = 0x815C,
        [NativeName("Name", "GL_IMAGE_MIN_FILTER_HP")]
        MinFilterHP = 0x815D,
        [NativeName("Name", "GL_IMAGE_CUBIC_WEIGHT_HP")]
        CubicWeightHP = 0x815E,
    }
}
