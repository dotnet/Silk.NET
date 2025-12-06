// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ImageTransformPNameHP")]
public enum ImageTransformPNameHP : uint
{
    [NativeName("GL_IMAGE_SCALE_X_HP")]
    ScaleX = 33109,

    [NativeName("GL_IMAGE_SCALE_Y_HP")]
    ScaleY = 33110,

    [NativeName("GL_IMAGE_TRANSLATE_X_HP")]
    TranslateX = 33111,

    [NativeName("GL_IMAGE_TRANSLATE_Y_HP")]
    TranslateY = 33112,

    [NativeName("GL_IMAGE_ROTATE_ANGLE_HP")]
    RotateAngle = 33113,

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_X_HP")]
    RotateOriginX = 33114,

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
    RotateOriginY = 33115,

    [NativeName("GL_IMAGE_MAG_FILTER_HP")]
    MagFilter = 33116,

    [NativeName("GL_IMAGE_MIN_FILTER_HP")]
    MinFilter = 33117,

    [NativeName("GL_IMAGE_CUBIC_WEIGHT_HP")]
    CubicWeight = 33118,
}
