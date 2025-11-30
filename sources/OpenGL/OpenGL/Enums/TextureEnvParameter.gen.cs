// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureEnvParameter")]
[Transformed]
public enum TextureEnvParameter : uint
{
    [NativeName("GL_TEXTURE_ENV_MODE")]
    TextureEnvMode = unchecked((uint)0x2200),

    [NativeName("GL_TEXTURE_ENV_COLOR")]
    TextureEnvColor = unchecked((uint)0x2201),

    [NativeName("GL_COMBINE")]
    Combine = unchecked((uint)0x8570),

    [NativeName("GL_COMBINE_RGB")]
    CombineRgb = unchecked((uint)0x8571),

    [NativeName("GL_COMBINE_ALPHA")]
    CombineAlpha = unchecked((uint)0x8572),

    [NativeName("GL_RGB_SCALE")]
    RgbScale = unchecked((uint)0x8573),

    [NativeName("GL_ADD_SIGNED")]
    AddSigned = unchecked((uint)0x8574),

    [NativeName("GL_INTERPOLATE")]
    Interpolate = unchecked((uint)0x8575),

    [NativeName("GL_CONSTANT")]
    Constant = unchecked((uint)0x8576),

    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = unchecked((uint)0x8577),

    [NativeName("GL_PREVIOUS")]
    Previous = unchecked((uint)0x8578),

    [NativeName("GL_OPERAND0_RGB")]
    Operand0Rgb = unchecked((uint)0x8590),

    [NativeName("GL_OPERAND1_RGB")]
    Operand1Rgb = unchecked((uint)0x8591),

    [NativeName("GL_OPERAND2_RGB")]
    Operand2Rgb = unchecked((uint)0x8592),

    [NativeName("GL_OPERAND0_ALPHA")]
    Operand0Alpha = unchecked((uint)0x8598),

    [NativeName("GL_OPERAND1_ALPHA")]
    Operand1Alpha = unchecked((uint)0x8599),

    [NativeName("GL_OPERAND2_ALPHA")]
    Operand2Alpha = unchecked((uint)0x859A),

    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = unchecked((uint)0x0D1C),

    [NativeName("GL_SRC0_RGB")]
    Src0Rgb = unchecked((uint)0x8580),

    [NativeName("GL_SRC1_RGB")]
    Src1Rgb = unchecked((uint)0x8581),

    [NativeName("GL_SRC2_RGB")]
    Src2Rgb = unchecked((uint)0x8582),

    [NativeName("GL_SRC0_ALPHA")]
    Src0Alpha = unchecked((uint)0x8588),

    [NativeName("GL_SRC1_ALPHA")]
    Src1Alpha = unchecked((uint)0x8589),

    [NativeName("GL_SRC2_ALPHA")]
    Src2Alpha = unchecked((uint)0x858A),

    [NativeName("GL_SOURCE0_RGB")]
    Source0Rgb = unchecked((uint)0x8580),

    [NativeName("GL_SOURCE1_RGB")]
    Source1Rgb = unchecked((uint)0x8581),

    [NativeName("GL_SOURCE2_RGB")]
    Source2Rgb = unchecked((uint)0x8582),

    [NativeName("GL_SOURCE0_ALPHA")]
    Source0Alpha = unchecked((uint)0x8588),

    [NativeName("GL_SOURCE1_ALPHA")]
    Source1Alpha = unchecked((uint)0x8589),

    [NativeName("GL_SOURCE2_ALPHA")]
    Source2Alpha = unchecked((uint)0x858A),

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    TextureLodBias = unchecked((uint)0x8501),

    [NativeName("GL_COORD_REPLACE")]
    CoordReplace = unchecked((uint)0x8862),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMBINE_ARB")]
    Combinearb = unchecked((uint)0x8570),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMBINE_RGB_ARB")]
    CombineRgbarb = unchecked((uint)0x8571),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_COMBINE_ALPHA_ARB")]
    CombineAlphaarb = unchecked((uint)0x8572),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE0_RGB_ARB")]
    Source0Rgbarb = unchecked((uint)0x8580),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE1_RGB_ARB")]
    Source1Rgbarb = unchecked((uint)0x8581),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE2_RGB_ARB")]
    Source2Rgbarb = unchecked((uint)0x8582),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE0_ALPHA_ARB")]
    Source0Alphaarb = unchecked((uint)0x8588),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE1_ALPHA_ARB")]
    Source1Alphaarb = unchecked((uint)0x8589),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SOURCE2_ALPHA_ARB")]
    Source2Alphaarb = unchecked((uint)0x858A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND0_RGB_ARB")]
    Operand0Rgbarb = unchecked((uint)0x8590),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND1_RGB_ARB")]
    Operand1Rgbarb = unchecked((uint)0x8591),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND2_RGB_ARB")]
    Operand2Rgbarb = unchecked((uint)0x8592),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND0_ALPHA_ARB")]
    Operand0Alphaarb = unchecked((uint)0x8598),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND1_ALPHA_ARB")]
    Operand1Alphaarb = unchecked((uint)0x8599),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_OPERAND2_ALPHA_ARB")]
    Operand2Alphaarb = unchecked((uint)0x859A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_RGB_SCALE_ARB")]
    RgbScalearb = unchecked((uint)0x8573),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_ADD_SIGNED_ARB")]
    AddSignedarb = unchecked((uint)0x8574),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_INTERPOLATE_ARB")]
    Interpolatearb = unchecked((uint)0x8575),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CONSTANT_ARB")]
    Constantarb = unchecked((uint)0x8576),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorarb = unchecked((uint)0x8577),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PREVIOUS_ARB")]
    Previousarb = unchecked((uint)0x8578),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMBINE_EXT")]
    Combineext = unchecked((uint)0x8570),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMBINE_RGB_EXT")]
    CombineRgbext = unchecked((uint)0x8571),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMBINE_ALPHA_EXT")]
    CombineAlphaext = unchecked((uint)0x8572),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RGB_SCALE_EXT")]
    RgbScaleext = unchecked((uint)0x8573),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ADD_SIGNED_EXT")]
    AddSignedext = unchecked((uint)0x8574),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INTERPOLATE_EXT")]
    Interpolateext = unchecked((uint)0x8575),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONSTANT_EXT")]
    Constantext = unchecked((uint)0x8576),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorext = unchecked((uint)0x8577),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PREVIOUS_EXT")]
    Previousext = unchecked((uint)0x8578),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE0_RGB_EXT")]
    Source0Rgbext = unchecked((uint)0x8580),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE1_RGB_EXT")]
    Source1Rgbext = unchecked((uint)0x8581),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE2_RGB_EXT")]
    Source2Rgbext = unchecked((uint)0x8582),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE0_ALPHA_EXT")]
    Source0Alphaext = unchecked((uint)0x8588),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE1_ALPHA_EXT")]
    Source1Alphaext = unchecked((uint)0x8589),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SOURCE2_ALPHA_EXT")]
    Source2Alphaext = unchecked((uint)0x858A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND0_RGB_EXT")]
    Operand0Rgbext = unchecked((uint)0x8590),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND1_RGB_EXT")]
    Operand1Rgbext = unchecked((uint)0x8591),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND2_RGB_EXT")]
    Operand2Rgbext = unchecked((uint)0x8592),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND0_ALPHA_EXT")]
    Operand0Alphaext = unchecked((uint)0x8598),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND1_ALPHA_EXT")]
    Operand1Alphaext = unchecked((uint)0x8599),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_OPERAND2_ALPHA_EXT")]
    Operand2Alphaext = unchecked((uint)0x859A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONSTANT_NV")]
    Constantnv = unchecked((uint)0x8576),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SOURCE3_RGB_NV")]
    Source3Rgbnv = unchecked((uint)0x8583),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SOURCE3_ALPHA_NV")]
    Source3Alphanv = unchecked((uint)0x858B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OPERAND3_RGB_NV")]
    Operand3Rgbnv = unchecked((uint)0x8593),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_OPERAND3_ALPHA_NV")]
    Operand3Alphanv = unchecked((uint)0x859B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SRC1_ALPHA_EXT")]
    Src1Alphaext = unchecked((uint)0x8589),
}
