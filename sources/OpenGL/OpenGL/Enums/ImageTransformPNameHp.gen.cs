// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "HP", 0)]
[NativeName("ImageTransformPNameHP")]
[Transformed]
public enum ImageTransformPNameHp : uint
{
    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_SCALE_X_HP")]
    ScaleXhp = unchecked((uint)0x8155),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_SCALE_Y_HP")]
    ScaleYhp = unchecked((uint)0x8156),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_TRANSLATE_X_HP")]
    TranslateXhp = unchecked((uint)0x8157),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_TRANSLATE_Y_HP")]
    TranslateYhp = unchecked((uint)0x8158),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_ROTATE_ANGLE_HP")]
    RotateAnglehp = unchecked((uint)0x8159),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_ROTATE_ORIGIN_X_HP")]
    RotateOriginXhp = unchecked((uint)0x815A),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_ROTATE_ORIGIN_Y_HP")]
    RotateOriginYhp = unchecked((uint)0x815B),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_MAG_FILTER_HP")]
    MagFilterhp = unchecked((uint)0x815C),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_MIN_FILTER_HP")]
    MinFilterhp = unchecked((uint)0x815D),

    [NameAffix("Suffix", "HP", 0)]
    [NativeName("GL_IMAGE_CUBIC_WEIGHT_HP")]
    CubicWeighthp = unchecked((uint)0x815E),
}
