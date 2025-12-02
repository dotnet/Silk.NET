// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", -1)]
[NativeName("FragmentShaderGenericSourceATI")]
public enum FragmentShaderGenericSource : uint
{
    [NativeName("GL_ZERO")]
    Zero = 0,

    [NativeName("GL_ONE")]
    One = 1,

    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = 34167,

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorARB = 34167,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_0_ATI")]
    Reg0ATI = 35105,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_1_ATI")]
    Reg1ATI = 35106,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_2_ATI")]
    Reg2ATI = 35107,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_3_ATI")]
    Reg3ATI = 35108,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_4_ATI")]
    Reg4ATI = 35109,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_5_ATI")]
    Reg5ATI = 35110,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_6_ATI")]
    Reg6ATI = 35111,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_7_ATI")]
    Reg7ATI = 35112,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_8_ATI")]
    Reg8ATI = 35113,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_9_ATI")]
    Reg9ATI = 35114,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_10_ATI")]
    Reg10ATI = 35115,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_11_ATI")]
    Reg11ATI = 35116,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_12_ATI")]
    Reg12ATI = 35117,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_13_ATI")]
    Reg13ATI = 35118,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_14_ATI")]
    Reg14ATI = 35119,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_15_ATI")]
    Reg15ATI = 35120,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_16_ATI")]
    Reg16ATI = 35121,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_17_ATI")]
    Reg17ATI = 35122,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_18_ATI")]
    Reg18ATI = 35123,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_19_ATI")]
    Reg19ATI = 35124,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_20_ATI")]
    Reg20ATI = 35125,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_21_ATI")]
    Reg21ATI = 35126,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_22_ATI")]
    Reg22ATI = 35127,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_23_ATI")]
    Reg23ATI = 35128,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_24_ATI")]
    Reg24ATI = 35129,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_25_ATI")]
    Reg25ATI = 35130,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_26_ATI")]
    Reg26ATI = 35131,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_27_ATI")]
    Reg27ATI = 35132,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_28_ATI")]
    Reg28ATI = 35133,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_29_ATI")]
    Reg29ATI = 35134,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_30_ATI")]
    Reg30ATI = 35135,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_REG_31_ATI")]
    Reg31ATI = 35136,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_0_ATI")]
    Con0ATI = 35137,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_1_ATI")]
    Con1ATI = 35138,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_2_ATI")]
    Con2ATI = 35139,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_3_ATI")]
    Con3ATI = 35140,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_4_ATI")]
    Con4ATI = 35141,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_5_ATI")]
    Con5ATI = 35142,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_6_ATI")]
    Con6ATI = 35143,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_7_ATI")]
    Con7ATI = 35144,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_8_ATI")]
    Con8ATI = 35145,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_9_ATI")]
    Con9ATI = 35146,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_10_ATI")]
    Con10ATI = 35147,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_11_ATI")]
    Con11ATI = 35148,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_12_ATI")]
    Con12ATI = 35149,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_13_ATI")]
    Con13ATI = 35150,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_14_ATI")]
    Con14ATI = 35151,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_15_ATI")]
    Con15ATI = 35152,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_16_ATI")]
    Con16ATI = 35153,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_17_ATI")]
    Con17ATI = 35154,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_18_ATI")]
    Con18ATI = 35155,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_19_ATI")]
    Con19ATI = 35156,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_20_ATI")]
    Con20ATI = 35157,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_21_ATI")]
    Con21ATI = 35158,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_22_ATI")]
    Con22ATI = 35159,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_23_ATI")]
    Con23ATI = 35160,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_24_ATI")]
    Con24ATI = 35161,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_25_ATI")]
    Con25ATI = 35162,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_26_ATI")]
    Con26ATI = 35163,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_27_ATI")]
    Con27ATI = 35164,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_28_ATI")]
    Con28ATI = 35165,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_29_ATI")]
    Con29ATI = 35166,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_30_ATI")]
    Con30ATI = 35167,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_CON_31_ATI")]
    Con31ATI = 35168,

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SECONDARY_INTERPOLATOR_ATI")]
    SecondaryInterpolatorATI = 35181,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorEXT = 34167,
}
