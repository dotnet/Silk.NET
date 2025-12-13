// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLipExpressionBD")]
    public enum LipExpressionBD : int
    {
        [Obsolete("Deprecated in favour of \"PPBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_PP_BD")]
        LipExpressionPPBD = 0,
        [Obsolete("Deprecated in favour of \"CHBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_CH_BD")]
        LipExpressionCHBD = 1,
        [Obsolete("Deprecated in favour of \"LOBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LO_BD")]
        LipExpressionLOBD = 2,
        [Obsolete("Deprecated in favour of \"OBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_O_BD")]
        LipExpressionOBD = 3,
        [Obsolete("Deprecated in favour of \"IBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_I_BD")]
        LipExpressionIBD = 4,
        [Obsolete("Deprecated in favour of \"LUBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LU_BD")]
        LipExpressionLUBD = 5,
        [Obsolete("Deprecated in favour of \"RRBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_RR_BD")]
        LipExpressionRRBD = 6,
        [Obsolete("Deprecated in favour of \"XXBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_XX_BD")]
        LipExpressionXXBD = 7,
        [Obsolete("Deprecated in favour of \"LaaBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LAA_BD")]
        LipExpressionLaaBD = 8,
        [Obsolete("Deprecated in favour of \"LIBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LI_BD")]
        LipExpressionLIBD = 9,
        [Obsolete("Deprecated in favour of \"FFBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_FF_BD")]
        LipExpressionFFBD = 10,
        [Obsolete("Deprecated in favour of \"UBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_U_BD")]
        LipExpressionUBD = 11,
        [Obsolete("Deprecated in favour of \"THBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TH_BD")]
        LipExpressionTHBD = 12,
        [Obsolete("Deprecated in favour of \"LkkBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LKK_BD")]
        LipExpressionLkkBD = 13,
        [Obsolete("Deprecated in favour of \"SSBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_SS_BD")]
        LipExpressionSSBD = 14,
        [Obsolete("Deprecated in favour of \"LEBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LE_BD")]
        LipExpressionLEBD = 15,
        [Obsolete("Deprecated in favour of \"DDBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_DD_BD")]
        LipExpressionDDBD = 16,
        [Obsolete("Deprecated in favour of \"EBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_E_BD")]
        LipExpressionEBD = 17,
        [Obsolete("Deprecated in favour of \"LnnBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_LNN_BD")]
        LipExpressionLnnBD = 18,
        [Obsolete("Deprecated in favour of \"SilBD\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_SIL_BD")]
        LipExpressionSilBD = 19,
        [NativeName("Name", "XR_LIP_EXPRESSION_PP_BD")]
        PPBD = 0,
        [NativeName("Name", "XR_LIP_EXPRESSION_CH_BD")]
        CHBD = 1,
        [NativeName("Name", "XR_LIP_EXPRESSION_LO_BD")]
        LOBD = 2,
        [NativeName("Name", "XR_LIP_EXPRESSION_O_BD")]
        OBD = 3,
        [NativeName("Name", "XR_LIP_EXPRESSION_I_BD")]
        IBD = 4,
        [NativeName("Name", "XR_LIP_EXPRESSION_LU_BD")]
        LUBD = 5,
        [NativeName("Name", "XR_LIP_EXPRESSION_RR_BD")]
        RRBD = 6,
        [NativeName("Name", "XR_LIP_EXPRESSION_XX_BD")]
        XXBD = 7,
        [NativeName("Name", "XR_LIP_EXPRESSION_LAA_BD")]
        LaaBD = 8,
        [NativeName("Name", "XR_LIP_EXPRESSION_LI_BD")]
        LIBD = 9,
        [NativeName("Name", "XR_LIP_EXPRESSION_FF_BD")]
        FFBD = 10,
        [NativeName("Name", "XR_LIP_EXPRESSION_U_BD")]
        UBD = 11,
        [NativeName("Name", "XR_LIP_EXPRESSION_TH_BD")]
        THBD = 12,
        [NativeName("Name", "XR_LIP_EXPRESSION_LKK_BD")]
        LkkBD = 13,
        [NativeName("Name", "XR_LIP_EXPRESSION_SS_BD")]
        SSBD = 14,
        [NativeName("Name", "XR_LIP_EXPRESSION_LE_BD")]
        LEBD = 15,
        [NativeName("Name", "XR_LIP_EXPRESSION_DD_BD")]
        DDBD = 16,
        [NativeName("Name", "XR_LIP_EXPRESSION_E_BD")]
        EBD = 17,
        [NativeName("Name", "XR_LIP_EXPRESSION_LNN_BD")]
        LnnBD = 18,
        [NativeName("Name", "XR_LIP_EXPRESSION_SIL_BD")]
        SilBD = 19,
    }
}
