// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLipExpressionBD")]
[SupportedApiProfile("openxr")]
public enum LipExpressionBD : uint
{
    [NativeName("XR_LIP_EXPRESSION_PP_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Pp = 0,

    [NativeName("XR_LIP_EXPRESSION_CH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Ch = 1,

    [NativeName("XR_LIP_EXPRESSION_LO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Lo = 2,

    [NativeName("XR_LIP_EXPRESSION_O_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    O = 3,

    [NativeName("XR_LIP_EXPRESSION_I_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    I = 4,

    [NativeName("XR_LIP_EXPRESSION_LU_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Lu = 5,

    [NativeName("XR_LIP_EXPRESSION_RR_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Rr = 6,

    [NativeName("XR_LIP_EXPRESSION_XX_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Xx = 7,

    [NativeName("XR_LIP_EXPRESSION_LAA_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Laa = 8,

    [NativeName("XR_LIP_EXPRESSION_LI_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Li = 9,

    [NativeName("XR_LIP_EXPRESSION_FF_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Ff = 10,

    [NativeName("XR_LIP_EXPRESSION_U_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    U = 11,

    [NativeName("XR_LIP_EXPRESSION_TH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Th = 12,

    [NativeName("XR_LIP_EXPRESSION_LKK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Lkk = 13,

    [NativeName("XR_LIP_EXPRESSION_SS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Ss = 14,

    [NativeName("XR_LIP_EXPRESSION_LE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Le = 15,

    [NativeName("XR_LIP_EXPRESSION_DD_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Dd = 16,

    [NativeName("XR_LIP_EXPRESSION_E_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    E = 17,

    [NativeName("XR_LIP_EXPRESSION_LNN_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Lnn = 18,

    [NativeName("XR_LIP_EXPRESSION_SIL_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Sil = 19,
}
