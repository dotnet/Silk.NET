// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1MatrixCoefficients")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1MatrixCoefficients : uint
{
    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsIdentity = 0,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsBt709 = 1,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsUnspecified = 2,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsReserved3 = 3,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsFcc = 4,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsBt470BG = 5,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsBt601 = 6,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsSmpte240 = 7,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsSmpteYcgco = 8,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsBt2020Ncl = 9,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsBt2020Cl = 10,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsSmpte2085 = 11,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsChromatNcl = 12,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsChromatCl = 13,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsIctcp = 14,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_MATRIX_COEFFICIENTS_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1MatrixCoefficientsMaxEnum = 0x7FFFFFFF,
}
