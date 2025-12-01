// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentShaderGenericSourceATI")]
public enum FragmentShaderGenericSourceATI : uint
{
    [NativeName("GL_ZERO")]
    Zero = unchecked((uint)0),

    [NativeName("GL_ONE")]
    One = unchecked((uint)1),

    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = unchecked((uint)0x8577),

    [NativeName("GL_PRIMARY_COLOR_ARB")]
    PrimaryColorARB = unchecked((uint)0x8577),

    [NativeName("GL_REG_0_ATI")]
    Reg0ATI = unchecked((uint)0x8921),

    [NativeName("GL_REG_1_ATI")]
    Reg1ATI = unchecked((uint)0x8922),

    [NativeName("GL_REG_2_ATI")]
    Reg2ATI = unchecked((uint)0x8923),

    [NativeName("GL_REG_3_ATI")]
    Reg3ATI = unchecked((uint)0x8924),

    [NativeName("GL_REG_4_ATI")]
    Reg4ATI = unchecked((uint)0x8925),

    [NativeName("GL_REG_5_ATI")]
    Reg5ATI = unchecked((uint)0x8926),

    [NativeName("GL_REG_6_ATI")]
    Reg6ATI = unchecked((uint)0x8927),

    [NativeName("GL_REG_7_ATI")]
    Reg7ATI = unchecked((uint)0x8928),

    [NativeName("GL_REG_8_ATI")]
    Reg8ATI = unchecked((uint)0x8929),

    [NativeName("GL_REG_9_ATI")]
    Reg9ATI = unchecked((uint)0x892A),

    [NativeName("GL_REG_10_ATI")]
    Reg10ATI = unchecked((uint)0x892B),

    [NativeName("GL_REG_11_ATI")]
    Reg11ATI = unchecked((uint)0x892C),

    [NativeName("GL_REG_12_ATI")]
    Reg12ATI = unchecked((uint)0x892D),

    [NativeName("GL_REG_13_ATI")]
    Reg13ATI = unchecked((uint)0x892E),

    [NativeName("GL_REG_14_ATI")]
    Reg14ATI = unchecked((uint)0x892F),

    [NativeName("GL_REG_15_ATI")]
    Reg15ATI = unchecked((uint)0x8930),

    [NativeName("GL_REG_16_ATI")]
    Reg16ATI = unchecked((uint)0x8931),

    [NativeName("GL_REG_17_ATI")]
    Reg17ATI = unchecked((uint)0x8932),

    [NativeName("GL_REG_18_ATI")]
    Reg18ATI = unchecked((uint)0x8933),

    [NativeName("GL_REG_19_ATI")]
    Reg19ATI = unchecked((uint)0x8934),

    [NativeName("GL_REG_20_ATI")]
    Reg20ATI = unchecked((uint)0x8935),

    [NativeName("GL_REG_21_ATI")]
    Reg21ATI = unchecked((uint)0x8936),

    [NativeName("GL_REG_22_ATI")]
    Reg22ATI = unchecked((uint)0x8937),

    [NativeName("GL_REG_23_ATI")]
    Reg23ATI = unchecked((uint)0x8938),

    [NativeName("GL_REG_24_ATI")]
    Reg24ATI = unchecked((uint)0x8939),

    [NativeName("GL_REG_25_ATI")]
    Reg25ATI = unchecked((uint)0x893A),

    [NativeName("GL_REG_26_ATI")]
    Reg26ATI = unchecked((uint)0x893B),

    [NativeName("GL_REG_27_ATI")]
    Reg27ATI = unchecked((uint)0x893C),

    [NativeName("GL_REG_28_ATI")]
    Reg28ATI = unchecked((uint)0x893D),

    [NativeName("GL_REG_29_ATI")]
    Reg29ATI = unchecked((uint)0x893E),

    [NativeName("GL_REG_30_ATI")]
    Reg30ATI = unchecked((uint)0x893F),

    [NativeName("GL_REG_31_ATI")]
    Reg31ATI = unchecked((uint)0x8940),

    [NativeName("GL_CON_0_ATI")]
    Con0ATI = unchecked((uint)0x8941),

    [NativeName("GL_CON_1_ATI")]
    Con1ATI = unchecked((uint)0x8942),

    [NativeName("GL_CON_2_ATI")]
    Con2ATI = unchecked((uint)0x8943),

    [NativeName("GL_CON_3_ATI")]
    Con3ATI = unchecked((uint)0x8944),

    [NativeName("GL_CON_4_ATI")]
    Con4ATI = unchecked((uint)0x8945),

    [NativeName("GL_CON_5_ATI")]
    Con5ATI = unchecked((uint)0x8946),

    [NativeName("GL_CON_6_ATI")]
    Con6ATI = unchecked((uint)0x8947),

    [NativeName("GL_CON_7_ATI")]
    Con7ATI = unchecked((uint)0x8948),

    [NativeName("GL_CON_8_ATI")]
    Con8ATI = unchecked((uint)0x8949),

    [NativeName("GL_CON_9_ATI")]
    Con9ATI = unchecked((uint)0x894A),

    [NativeName("GL_CON_10_ATI")]
    Con10ATI = unchecked((uint)0x894B),

    [NativeName("GL_CON_11_ATI")]
    Con11ATI = unchecked((uint)0x894C),

    [NativeName("GL_CON_12_ATI")]
    Con12ATI = unchecked((uint)0x894D),

    [NativeName("GL_CON_13_ATI")]
    Con13ATI = unchecked((uint)0x894E),

    [NativeName("GL_CON_14_ATI")]
    Con14ATI = unchecked((uint)0x894F),

    [NativeName("GL_CON_15_ATI")]
    Con15ATI = unchecked((uint)0x8950),

    [NativeName("GL_CON_16_ATI")]
    Con16ATI = unchecked((uint)0x8951),

    [NativeName("GL_CON_17_ATI")]
    Con17ATI = unchecked((uint)0x8952),

    [NativeName("GL_CON_18_ATI")]
    Con18ATI = unchecked((uint)0x8953),

    [NativeName("GL_CON_19_ATI")]
    Con19ATI = unchecked((uint)0x8954),

    [NativeName("GL_CON_20_ATI")]
    Con20ATI = unchecked((uint)0x8955),

    [NativeName("GL_CON_21_ATI")]
    Con21ATI = unchecked((uint)0x8956),

    [NativeName("GL_CON_22_ATI")]
    Con22ATI = unchecked((uint)0x8957),

    [NativeName("GL_CON_23_ATI")]
    Con23ATI = unchecked((uint)0x8958),

    [NativeName("GL_CON_24_ATI")]
    Con24ATI = unchecked((uint)0x8959),

    [NativeName("GL_CON_25_ATI")]
    Con25ATI = unchecked((uint)0x895A),

    [NativeName("GL_CON_26_ATI")]
    Con26ATI = unchecked((uint)0x895B),

    [NativeName("GL_CON_27_ATI")]
    Con27ATI = unchecked((uint)0x895C),

    [NativeName("GL_CON_28_ATI")]
    Con28ATI = unchecked((uint)0x895D),

    [NativeName("GL_CON_29_ATI")]
    Con29ATI = unchecked((uint)0x895E),

    [NativeName("GL_CON_30_ATI")]
    Con30ATI = unchecked((uint)0x895F),

    [NativeName("GL_CON_31_ATI")]
    Con31ATI = unchecked((uint)0x8960),

    [NativeName("GL_SECONDARY_INTERPOLATOR_ATI")]
    SecondaryInterpolatorATI = unchecked((uint)0x896D),

    [NativeName("GL_PRIMARY_COLOR_EXT")]
    PrimaryColorEXT = unchecked((uint)0x8577),
}
