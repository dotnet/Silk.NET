// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLipExpressionBD")]
public enum LipExpressionBD : uint
{
    [NativeName("XR_LIP_EXPRESSION_PP_BD")]
    Pp = 0,

    [NativeName("XR_LIP_EXPRESSION_CH_BD")]
    Ch = 1,

    [NativeName("XR_LIP_EXPRESSION_LO_BD")]
    Lo = 2,

    [NativeName("XR_LIP_EXPRESSION_O_BD")]
    O = 3,

    [NativeName("XR_LIP_EXPRESSION_I_BD")]
    I = 4,

    [NativeName("XR_LIP_EXPRESSION_LU_BD")]
    Lu = 5,

    [NativeName("XR_LIP_EXPRESSION_RR_BD")]
    Rr = 6,

    [NativeName("XR_LIP_EXPRESSION_XX_BD")]
    Xx = 7,

    [NativeName("XR_LIP_EXPRESSION_LAA_BD")]
    Laa = 8,

    [NativeName("XR_LIP_EXPRESSION_LI_BD")]
    Li = 9,

    [NativeName("XR_LIP_EXPRESSION_FF_BD")]
    Ff = 10,

    [NativeName("XR_LIP_EXPRESSION_U_BD")]
    U = 11,

    [NativeName("XR_LIP_EXPRESSION_TH_BD")]
    Th = 12,

    [NativeName("XR_LIP_EXPRESSION_LKK_BD")]
    Lkk = 13,

    [NativeName("XR_LIP_EXPRESSION_SS_BD")]
    Ss = 14,

    [NativeName("XR_LIP_EXPRESSION_LE_BD")]
    Le = 15,

    [NativeName("XR_LIP_EXPRESSION_DD_BD")]
    Dd = 16,

    [NativeName("XR_LIP_EXPRESSION_E_BD")]
    E = 17,

    [NativeName("XR_LIP_EXPRESSION_LNN_BD")]
    Lnn = 18,

    [NativeName("XR_LIP_EXPRESSION_SIL_BD")]
    Sil = 19,
}
