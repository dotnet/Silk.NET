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
    ScaleX = unchecked((uint)0x8155),

    [NativeName("GL_IMAGE_SCALE_Y_HP")]
    ScaleY = unchecked((uint)0x8156),

    [NativeName("GL_IMAGE_TRANSLATE_X_HP")]
    TranslateX = unchecked((uint)0x8157),

    [NativeName("GL_IMAGE_TRANSLATE_Y_HP")]
    TranslateY = unchecked((uint)0x8158),

    [NativeName("GL_IMAGE_ROTATE_ANGLE_HP")]
    RotateAngle = unchecked((uint)0x8159),

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_X_HP")]
    RotateOriginX = unchecked((uint)0x815A),

    [NativeName("GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
    RotateOriginY = unchecked((uint)0x815B),

    [NativeName("GL_IMAGE_MAG_FILTER_HP")]
    MagFilter = unchecked((uint)0x815C),

    [NativeName("GL_IMAGE_MIN_FILTER_HP")]
    MinFilter = unchecked((uint)0x815D),

    [NativeName("GL_IMAGE_CUBIC_WEIGHT_HP")]
    CubicWeight = unchecked((uint)0x815E),
}
