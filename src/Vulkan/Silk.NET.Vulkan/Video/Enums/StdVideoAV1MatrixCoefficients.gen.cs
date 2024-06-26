// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1MatrixCoefficients")]
    public enum StdVideoAV1MatrixCoefficients : int
    {
        [Obsolete("Deprecated in favour of \"Identity\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY")]
        StdVideoAV1MatrixCoefficientsIdentity = 0x0,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709")]
        StdVideoAV1MatrixCoefficientsBT709 = 0x1,
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED")]
        StdVideoAV1MatrixCoefficientsUnspecified = 0x2,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3")]
        StdVideoAV1MatrixCoefficientsReserved3 = 0x3,
        [Obsolete("Deprecated in favour of \"Fcc\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC")]
        StdVideoAV1MatrixCoefficientsFcc = 0x4,
        [Obsolete("Deprecated in favour of \"BT470BG\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G")]
        StdVideoAV1MatrixCoefficientsBT470BG = 0x5,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601")]
        StdVideoAV1MatrixCoefficientsBT601 = 0x6,
        [Obsolete("Deprecated in favour of \"Smpte240\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240")]
        StdVideoAV1MatrixCoefficientsSmpte240 = 0x7,
        [Obsolete("Deprecated in favour of \"SmpteYcgco\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO")]
        StdVideoAV1MatrixCoefficientsSmpteYcgco = 0x8,
        [Obsolete("Deprecated in favour of \"BT2020Ncl\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL")]
        StdVideoAV1MatrixCoefficientsBT2020Ncl = 0x9,
        [Obsolete("Deprecated in favour of \"BT2020CL\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL")]
        StdVideoAV1MatrixCoefficientsBT2020CL = 0xA,
        [Obsolete("Deprecated in favour of \"Smpte2085\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085")]
        StdVideoAV1MatrixCoefficientsSmpte2085 = 0xB,
        [Obsolete("Deprecated in favour of \"ChromatNcl\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL")]
        StdVideoAV1MatrixCoefficientsChromatNcl = 0xC,
        [Obsolete("Deprecated in favour of \"ChromatCL\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL")]
        StdVideoAV1MatrixCoefficientsChromatCL = 0xD,
        [Obsolete("Deprecated in favour of \"Ictcp\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP")]
        StdVideoAV1MatrixCoefficientsIctcp = 0xE,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_INVALID")]
        StdVideoAV1MatrixCoefficientsInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_MAX_ENUM")]
        StdVideoAV1MatrixCoefficientsMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_IDENTITY")]
        Identity = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_709")]
        BT709 = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_UNSPECIFIED")]
        Unspecified = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_RESERVED_3")]
        Reserved3 = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_FCC")]
        Fcc = 0x4,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_470_B_G")]
        BT470BG = 0x5,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_601")]
        BT601 = 0x6,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_240")]
        Smpte240 = 0x7,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_YCGCO")]
        SmpteYcgco = 0x8,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_NCL")]
        BT2020Ncl = 0x9,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_BT_2020_CL")]
        BT2020CL = 0xA,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_SMPTE_2085")]
        Smpte2085 = 0xB,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_NCL")]
        ChromatNcl = 0xC,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_CHROMAT_CL")]
        ChromatCL = 0xD,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_ICTCP")]
        Ictcp = 0xE,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_MATRIX_COEFFICIENTS_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
