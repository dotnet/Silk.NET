// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureEnvParameter")]
public enum TextureEnvParameter : uint
{
    [NativeName("GL_TEXTURE_ENV_MODE")]
    TextureEnvMode = 8704,

    [NativeName("GL_TEXTURE_ENV_COLOR")]
    TextureEnvColor = 8705,

    [NativeName("GL_COMBINE")]
    Combine = 34160,

    [NativeName("GL_COMBINE_RGB")]
    CombineRgb = 34161,

    [NativeName("GL_COMBINE_ALPHA")]
    CombineAlpha = 34162,

    [NativeName("GL_RGB_SCALE")]
    RgbScale = 34163,

    [NativeName("GL_ADD_SIGNED")]
    AddSigned = 34164,

    [NativeName("GL_INTERPOLATE")]
    Interpolate = 34165,

    [NativeName("GL_CONSTANT")]
    Constant = 34166,

    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = 34167,

    [NativeName("GL_PREVIOUS")]
    Previous = 34168,

    [NativeName("GL_OPERAND0_RGB")]
    Operand0Rgb = 34192,

    [NativeName("GL_OPERAND1_RGB")]
    Operand1Rgb = 34193,

    [NativeName("GL_OPERAND2_RGB")]
    Operand2Rgb = 34194,

    [NativeName("GL_OPERAND0_ALPHA")]
    Operand0Alpha = 34200,

    [NativeName("GL_OPERAND1_ALPHA")]
    Operand1Alpha = 34201,

    [NativeName("GL_OPERAND2_ALPHA")]
    Operand2Alpha = 34202,

    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = 3356,

    [NativeName("GL_SRC0_RGB")]
    Src0Rgb = 34176,

    [NativeName("GL_SRC1_RGB")]
    Src1Rgb = 34177,

    [NativeName("GL_SRC2_RGB")]
    Src2Rgb = 34178,

    [NativeName("GL_SRC0_ALPHA")]
    Src0Alpha = 34184,

    [NativeName("GL_SRC1_ALPHA")]
    Src1Alpha = 34185,

    [NativeName("GL_SRC2_ALPHA")]
    Src2Alpha = 34186,

    [NativeName("GL_SOURCE0_RGB")]
    Source0Rgb = 34176,

    [NativeName("GL_SOURCE1_RGB")]
    Source1Rgb = 34177,

    [NativeName("GL_SOURCE2_RGB")]
    Source2Rgb = 34178,

    [NativeName("GL_SOURCE0_ALPHA")]
    Source0Alpha = 34184,

    [NativeName("GL_SOURCE1_ALPHA")]
    Source1Alpha = 34185,

    [NativeName("GL_SOURCE2_ALPHA")]
    Source2Alpha = 34186,

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    TextureLodBias = 34049,

    [NativeName("GL_COORD_REPLACE")]
    CoordReplace = 34914,

    [NativeName("GL_COMBINE_ARB")]
    CombineARB = 34160,

    [NativeName("GL_COMBINE_RGB_ARB")]
    CombineRgbARB = 34161,

    [NativeName("GL_COMBINE_ALPHA_ARB")]
    CombineAlphaARB = 34162,

    [NativeName("GL_SOURCE0_RGB_ARB")]
    Source0RgbARB = 34176,

    [NativeName("GL_SOURCE1_RGB_ARB")]
    Source1RgbARB = 34177,

    [NativeName("GL_SOURCE2_RGB_ARB")]
    Source2RgbARB = 34178,

    [NativeName("GL_SOURCE0_ALPHA_ARB")]
    Source0AlphaARB = 34184,

    [NativeName("GL_SOURCE1_ALPHA_ARB")]
    Source1AlphaARB = 34185,

    [NativeName("GL_SOURCE2_ALPHA_ARB")]
    Source2AlphaARB = 34186,

    [NativeName("GL_OPERAND0_RGB_ARB")]
    Operand0RgbARB = 34192,

    [NativeName("GL_OPERAND1_RGB_ARB")]
    Operand1RgbARB = 34193,

    [NativeName("GL_OPERAND2_RGB_ARB")]
    Operand2RgbARB = 34194,

    [NativeName("GL_OPERAND0_ALPHA_ARB")]
    Operand0AlphaARB = 34200,

    [NativeName("GL_OPERAND1_ALPHA_ARB")]
    Operand1AlphaARB = 34201,

    [NativeName("GL_OPERAND2_ALPHA_ARB")]
    Operand2AlphaARB = 34202,

    [NativeName("GL_RGB_SCALE_ARB")]
    RgbScaleARB = 34163,

    [NativeName("GL_ADD_SIGNED_ARB")]
    AddSignedARB = 34164,

    [NativeName("GL_INTERPOLATE_ARB")]
    InterpolateARB = 34165,

    [NativeName("GL_CONSTANT_ARB")]
    ConstantARB = 34166,

    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorARB = 34167,

    [NativeName("GL_PREVIOUS_ARB")]
    PreviousARB = 34168,

    [NativeName("GL_COMBINE_EXT")]
    CombineEXT = 34160,

    [NativeName("GL_COMBINE_RGB_EXT")]
    CombineRgbEXT = 34161,

    [NativeName("GL_COMBINE_ALPHA_EXT")]
    CombineAlphaEXT = 34162,

    [NativeName("GL_RGB_SCALE_EXT")]
    RgbScaleEXT = 34163,

    [NativeName("GL_ADD_SIGNED_EXT")]
    AddSignedEXT = 34164,

    [NativeName("GL_INTERPOLATE_EXT")]
    InterpolateEXT = 34165,

    [NativeName("GL_CONSTANT_EXT")]
    ConstantEXT = 34166,

    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorEXT = 34167,

    [NativeName("GL_PREVIOUS_EXT")]
    PreviousEXT = 34168,

    [NativeName("GL_SOURCE0_RGB_EXT")]
    Source0RgbEXT = 34176,

    [NativeName("GL_SOURCE1_RGB_EXT")]
    Source1RgbEXT = 34177,

    [NativeName("GL_SOURCE2_RGB_EXT")]
    Source2RgbEXT = 34178,

    [NativeName("GL_SOURCE0_ALPHA_EXT")]
    Source0AlphaEXT = 34184,

    [NativeName("GL_SOURCE1_ALPHA_EXT")]
    Source1AlphaEXT = 34185,

    [NativeName("GL_SOURCE2_ALPHA_EXT")]
    Source2AlphaEXT = 34186,

    [NativeName("GL_OPERAND0_RGB_EXT")]
    Operand0RgbEXT = 34192,

    [NativeName("GL_OPERAND1_RGB_EXT")]
    Operand1RgbEXT = 34193,

    [NativeName("GL_OPERAND2_RGB_EXT")]
    Operand2RgbEXT = 34194,

    [NativeName("GL_OPERAND0_ALPHA_EXT")]
    Operand0AlphaEXT = 34200,

    [NativeName("GL_OPERAND1_ALPHA_EXT")]
    Operand1AlphaEXT = 34201,

    [NativeName("GL_OPERAND2_ALPHA_EXT")]
    Operand2AlphaEXT = 34202,

    [NativeName("GL_CONSTANT_NV")]
    ConstantNV = 34166,

    [NativeName("GL_SOURCE3_RGB_NV")]
    Source3RgbNV = 34179,

    [NativeName("GL_SOURCE3_ALPHA_NV")]
    Source3AlphaNV = 34187,

    [NativeName("GL_OPERAND3_RGB_NV")]
    Operand3RgbNV = 34195,

    [NativeName("GL_OPERAND3_ALPHA_NV")]
    Operand3AlphaNV = 34203,

    [NativeName("GL_SRC1_ALPHA_EXT")]
    Src1AlphaEXT = 34185,
}
