// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FilmGrain")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAV1FilmGrain
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainFlags Flags;

    [NativeName("grain_scaling_minus_8")]
    [SupportedApiProfile("vulkan")]
    public byte GrainScalingMinus8;

    [NativeName("ar_coeff_lag")]
    [SupportedApiProfile("vulkan")]
    public byte ArCoeffLag;

    [NativeName("ar_coeff_shift_minus_6")]
    [SupportedApiProfile("vulkan")]
    public byte ArCoeffShiftMinus6;

    [NativeName("grain_scale_shift")]
    [SupportedApiProfile("vulkan")]
    public byte GrainScaleShift;

    [NativeName("grain_seed")]
    [SupportedApiProfile("vulkan")]
    public ushort GrainSeed;

    [NativeName("film_grain_params_ref_idx")]
    [SupportedApiProfile("vulkan")]
    public byte FilmGrainParamsRefIdx;

    [NativeName("num_y_points")]
    [SupportedApiProfile("vulkan")]
    public byte NumYPoints;

    [NativeName("point_y_value")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainPointYValue PointYValue;

    [NativeName("point_y_scaling")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainPointYScaling PointYScaling;

    [NativeName("num_cb_points")]
    [SupportedApiProfile("vulkan")]
    public byte NumCbPoints;

    [NativeName("point_cb_value")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainPointCbValue PointCbValue;

    [NativeName("point_cb_scaling")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainPointCbScaling PointCbScaling;

    [NativeName("num_cr_points")]
    [SupportedApiProfile("vulkan")]
    public byte NumCrPoints;

    [NativeName("point_cr_value")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainPointCrValue PointCrValue;

    [NativeName("point_cr_scaling")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainPointCrScaling PointCrScaling;

    [NativeName("ar_coeffs_y_plus_128")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainArCoeffsYPlus128 ArCoeffsYPlus128;

    [NativeName("ar_coeffs_cb_plus_128")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainArCoeffsCbPlus128 ArCoeffsCbPlus128;

    [NativeName("ar_coeffs_cr_plus_128")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrainArCoeffsCrPlus128 ArCoeffsCrPlus128;

    [NativeName("cb_mult")]
    [SupportedApiProfile("vulkan")]
    public byte CbMult;

    [NativeName("cb_luma_mult")]
    [SupportedApiProfile("vulkan")]
    public byte CbLumaMult;

    [NativeName("cb_offset")]
    [SupportedApiProfile("vulkan")]
    public ushort CbOffset;

    [NativeName("cr_mult")]
    [SupportedApiProfile("vulkan")]
    public byte CrMult;

    [NativeName("cr_luma_mult")]
    [SupportedApiProfile("vulkan")]
    public byte CrLumaMult;

    [NativeName("cr_offset")]
    [SupportedApiProfile("vulkan")]
    public ushort CrOffset;
}
