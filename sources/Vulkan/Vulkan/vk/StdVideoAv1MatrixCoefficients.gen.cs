// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1MatrixCoefficients")]
public enum StdVideoAv1MatrixCoefficients : uint
{
    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY")]
    Identity = 0,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709")]
    Bt709 = 1,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED")]
    Unspecified = 2,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3")]
    Reserved3 = 3,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC")]
    Fcc = 4,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G")]
    Bt470BG = 5,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601")]
    Bt601 = 6,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240")]
    Smpte240 = 7,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO")]
    SmpteYcgco = 8,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL")]
    Bt2020Ncl = 9,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL")]
    Bt2020Cl = 10,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085")]
    Smpte2085 = 11,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL")]
    ChromatNcl = 12,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL")]
    ChromatCl = 13,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP")]
    Ictcp = 14,
}
