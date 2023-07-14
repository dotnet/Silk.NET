// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FragmentShaderGenericSourceATI")]
    public enum FragmentShaderGenericSourceATI : int
    {
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PRIMARY_COLOR")]
        PrimaryColor = 0x8577,
        [NativeName("Name", "GL_PRIMARY_COLOR_ARB")]
        PrimaryColorArb = 0x8577,
        [NativeName("Name", "GL_PRIMARY_COLOR_EXT")]
        PrimaryColorExt = 0x8577,
        [NativeName("Name", "GL_REG_0_ATI")]
        Reg0Ati = 0x8921,
        [NativeName("Name", "GL_REG_1_ATI")]
        Reg1Ati = 0x8922,
        [NativeName("Name", "GL_REG_2_ATI")]
        Reg2Ati = 0x8923,
        [NativeName("Name", "GL_REG_3_ATI")]
        Reg3Ati = 0x8924,
        [NativeName("Name", "GL_REG_4_ATI")]
        Reg4Ati = 0x8925,
        [NativeName("Name", "GL_REG_5_ATI")]
        Reg5Ati = 0x8926,
        [NativeName("Name", "GL_REG_6_ATI")]
        Reg6Ati = 0x8927,
        [NativeName("Name", "GL_REG_7_ATI")]
        Reg7Ati = 0x8928,
        [NativeName("Name", "GL_REG_8_ATI")]
        Reg8Ati = 0x8929,
        [NativeName("Name", "GL_REG_9_ATI")]
        Reg9Ati = 0x892A,
        [NativeName("Name", "GL_REG_10_ATI")]
        Reg10Ati = 0x892B,
        [NativeName("Name", "GL_REG_11_ATI")]
        Reg11Ati = 0x892C,
        [NativeName("Name", "GL_REG_12_ATI")]
        Reg12Ati = 0x892D,
        [NativeName("Name", "GL_REG_13_ATI")]
        Reg13Ati = 0x892E,
        [NativeName("Name", "GL_REG_14_ATI")]
        Reg14Ati = 0x892F,
        [NativeName("Name", "GL_REG_15_ATI")]
        Reg15Ati = 0x8930,
        [NativeName("Name", "GL_REG_16_ATI")]
        Reg16Ati = 0x8931,
        [NativeName("Name", "GL_REG_17_ATI")]
        Reg17Ati = 0x8932,
        [NativeName("Name", "GL_REG_18_ATI")]
        Reg18Ati = 0x8933,
        [NativeName("Name", "GL_REG_19_ATI")]
        Reg19Ati = 0x8934,
        [NativeName("Name", "GL_REG_20_ATI")]
        Reg20Ati = 0x8935,
        [NativeName("Name", "GL_REG_21_ATI")]
        Reg21Ati = 0x8936,
        [NativeName("Name", "GL_REG_22_ATI")]
        Reg22Ati = 0x8937,
        [NativeName("Name", "GL_REG_23_ATI")]
        Reg23Ati = 0x8938,
        [NativeName("Name", "GL_REG_24_ATI")]
        Reg24Ati = 0x8939,
        [NativeName("Name", "GL_REG_25_ATI")]
        Reg25Ati = 0x893A,
        [NativeName("Name", "GL_REG_26_ATI")]
        Reg26Ati = 0x893B,
        [NativeName("Name", "GL_REG_27_ATI")]
        Reg27Ati = 0x893C,
        [NativeName("Name", "GL_REG_28_ATI")]
        Reg28Ati = 0x893D,
        [NativeName("Name", "GL_REG_29_ATI")]
        Reg29Ati = 0x893E,
        [NativeName("Name", "GL_REG_30_ATI")]
        Reg30Ati = 0x893F,
        [NativeName("Name", "GL_REG_31_ATI")]
        Reg31Ati = 0x8940,
        [NativeName("Name", "GL_CON_0_ATI")]
        Con0Ati = 0x8941,
        [NativeName("Name", "GL_CON_1_ATI")]
        Con1Ati = 0x8942,
        [NativeName("Name", "GL_CON_2_ATI")]
        Con2Ati = 0x8943,
        [NativeName("Name", "GL_CON_3_ATI")]
        Con3Ati = 0x8944,
        [NativeName("Name", "GL_CON_4_ATI")]
        Con4Ati = 0x8945,
        [NativeName("Name", "GL_CON_5_ATI")]
        Con5Ati = 0x8946,
        [NativeName("Name", "GL_CON_6_ATI")]
        Con6Ati = 0x8947,
        [NativeName("Name", "GL_CON_7_ATI")]
        Con7Ati = 0x8948,
        [NativeName("Name", "GL_CON_8_ATI")]
        Con8Ati = 0x8949,
        [NativeName("Name", "GL_CON_9_ATI")]
        Con9Ati = 0x894A,
        [NativeName("Name", "GL_CON_10_ATI")]
        Con10Ati = 0x894B,
        [NativeName("Name", "GL_CON_11_ATI")]
        Con11Ati = 0x894C,
        [NativeName("Name", "GL_CON_12_ATI")]
        Con12Ati = 0x894D,
        [NativeName("Name", "GL_CON_13_ATI")]
        Con13Ati = 0x894E,
        [NativeName("Name", "GL_CON_14_ATI")]
        Con14Ati = 0x894F,
        [NativeName("Name", "GL_CON_15_ATI")]
        Con15Ati = 0x8950,
        [NativeName("Name", "GL_CON_16_ATI")]
        Con16Ati = 0x8951,
        [NativeName("Name", "GL_CON_17_ATI")]
        Con17Ati = 0x8952,
        [NativeName("Name", "GL_CON_18_ATI")]
        Con18Ati = 0x8953,
        [NativeName("Name", "GL_CON_19_ATI")]
        Con19Ati = 0x8954,
        [NativeName("Name", "GL_CON_20_ATI")]
        Con20Ati = 0x8955,
        [NativeName("Name", "GL_CON_21_ATI")]
        Con21Ati = 0x8956,
        [NativeName("Name", "GL_CON_22_ATI")]
        Con22Ati = 0x8957,
        [NativeName("Name", "GL_CON_23_ATI")]
        Con23Ati = 0x8958,
        [NativeName("Name", "GL_CON_24_ATI")]
        Con24Ati = 0x8959,
        [NativeName("Name", "GL_CON_25_ATI")]
        Con25Ati = 0x895A,
        [NativeName("Name", "GL_CON_26_ATI")]
        Con26Ati = 0x895B,
        [NativeName("Name", "GL_CON_27_ATI")]
        Con27Ati = 0x895C,
        [NativeName("Name", "GL_CON_28_ATI")]
        Con28Ati = 0x895D,
        [NativeName("Name", "GL_CON_29_ATI")]
        Con29Ati = 0x895E,
        [NativeName("Name", "GL_CON_30_ATI")]
        Con30Ati = 0x895F,
        [NativeName("Name", "GL_CON_31_ATI")]
        Con31Ati = 0x8960,
        [NativeName("Name", "GL_SECONDARY_INTERPOLATOR_ATI")]
        SecondaryInterpolatorAti = 0x896D,
    }
}
