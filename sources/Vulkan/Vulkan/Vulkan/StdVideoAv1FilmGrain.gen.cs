// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FilmGrain")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1FilmGrain
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainFlags Flags;

    [NativeName("grain_scaling_minus_8")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte GrainScalingMinus8;

    [NativeName("ar_coeff_lag")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ArCoeffLag;

    [NativeName("ar_coeff_shift_minus_6")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ArCoeffShiftMinus6;

    [NativeName("grain_scale_shift")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte GrainScaleShift;

    [NativeName("grain_seed")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort GrainSeed;

    [NativeName("film_grain_params_ref_idx")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte FilmGrainParamsRefIdx;

    [NativeName("num_y_points")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumYPoints;

    [NativeName("point_y_value")]
    [NativeTypeName("uint8_t[14]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainPointYValue PointYValue;

    [NativeName("point_y_scaling")]
    [NativeTypeName("uint8_t[14]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainPointYScaling PointYScaling;

    [NativeName("num_cb_points")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumCbPoints;

    [NativeName("point_cb_value")]
    [NativeTypeName("uint8_t[10]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainPointCbValue PointCbValue;

    [NativeName("point_cb_scaling")]
    [NativeTypeName("uint8_t[10]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainPointCbScaling PointCbScaling;

    [NativeName("num_cr_points")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumCrPoints;

    [NativeName("point_cr_value")]
    [NativeTypeName("uint8_t[10]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainPointCrValue PointCrValue;

    [NativeName("point_cr_scaling")]
    [NativeTypeName("uint8_t[10]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainPointCrScaling PointCrScaling;

    [NativeName("ar_coeffs_y_plus_128")]
    [NativeTypeName("int8_t[24]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainArCoeffsYPlus128 ArCoeffsYPlus128;

    [NativeName("ar_coeffs_cb_plus_128")]
    [NativeTypeName("int8_t[25]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainArCoeffsCbPlus128 ArCoeffsCbPlus128;

    [NativeName("ar_coeffs_cr_plus_128")]
    [NativeTypeName("int8_t[25]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrainArCoeffsCrPlus128 ArCoeffsCrPlus128;

    [NativeName("cb_mult")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CbMult;

    [NativeName("cb_luma_mult")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CbLumaMult;

    [NativeName("cb_offset")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort CbOffset;

    [NativeName("cr_mult")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CrMult;

    [NativeName("cr_luma_mult")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CrLumaMult;

    [NativeName("cr_offset")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort CrOffset;
}
