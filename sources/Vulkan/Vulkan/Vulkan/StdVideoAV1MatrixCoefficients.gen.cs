// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1MatrixCoefficients")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1MatrixCoefficients : uint
{
    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY")]
    [SupportedApiProfile("vulkan")]
    Identity = 0,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709")]
    [SupportedApiProfile("vulkan")]
    Bt709 = 1,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    Unspecified = 2,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3")]
    [SupportedApiProfile("vulkan")]
    Reserved3 = 3,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC")]
    [SupportedApiProfile("vulkan")]
    Fcc = 4,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G")]
    [SupportedApiProfile("vulkan")]
    Bt470BG = 5,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601")]
    [SupportedApiProfile("vulkan")]
    Bt601 = 6,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    Smpte240 = 7,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO")]
    [SupportedApiProfile("vulkan")]
    SmpteYcgco = 8,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL")]
    [SupportedApiProfile("vulkan")]
    Bt2020Ncl = 9,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL")]
    [SupportedApiProfile("vulkan")]
    Bt2020Cl = 10,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085")]
    [SupportedApiProfile("vulkan")]
    Smpte2085 = 11,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL")]
    [SupportedApiProfile("vulkan")]
    ChromatNcl = 12,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL")]
    [SupportedApiProfile("vulkan")]
    ChromatCl = 13,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP")]
    [SupportedApiProfile("vulkan")]
    Ictcp = 14,
}
