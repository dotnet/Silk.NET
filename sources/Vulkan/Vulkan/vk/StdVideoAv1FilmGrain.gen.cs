// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FilmGrain")]
public partial struct StdVideoAv1FilmGrain
{
    [NativeName("flags")]
    public StdVideoAv1FilmGrainFlags Flags;

    [NativeName("grain_scaling_minus_8")]
    public byte GrainScalingMinus8;

    [NativeName("ar_coeff_lag")]
    public byte ArCoeffLag;

    [NativeName("ar_coeff_shift_minus_6")]
    public byte ArCoeffShiftMinus6;

    [NativeName("grain_scale_shift")]
    public byte GrainScaleShift;

    [NativeName("grain_seed")]
    public ushort GrainSeed;

    [NativeName("film_grain_params_ref_idx")]
    public byte FilmGrainParamsRefIdx;

    [NativeName("num_y_points")]
    public byte NumYPoints;

    [NativeName("point_y_value")]
    public StdVideoAv1FilmGrainPointYValue PointYValue;

    [NativeName("point_y_scaling")]
    public StdVideoAv1FilmGrainPointYScaling PointYScaling;

    [NativeName("num_cb_points")]
    public byte NumCbPoints;

    [NativeName("point_cb_value")]
    public StdVideoAv1FilmGrainPointCbValue PointCbValue;

    [NativeName("point_cb_scaling")]
    public StdVideoAv1FilmGrainPointCbScaling PointCbScaling;

    [NativeName("num_cr_points")]
    public byte NumCrPoints;

    [NativeName("point_cr_value")]
    public StdVideoAv1FilmGrainPointCrValue PointCrValue;

    [NativeName("point_cr_scaling")]
    public StdVideoAv1FilmGrainPointCrScaling PointCrScaling;

    [NativeName("ar_coeffs_y_plus_128")]
    public StdVideoAv1FilmGrainArCoeffsYPlus128 ArCoeffsYPlus128;

    [NativeName("ar_coeffs_cb_plus_128")]
    public StdVideoAv1FilmGrainArCoeffsCbPlus128 ArCoeffsCbPlus128;

    [NativeName("ar_coeffs_cr_plus_128")]
    public StdVideoAv1FilmGrainArCoeffsCrPlus128 ArCoeffsCrPlus128;

    [NativeName("cb_mult")]
    public byte CbMult;

    [NativeName("cb_luma_mult")]
    public byte CbLumaMult;

    [NativeName("cb_offset")]
    public ushort CbOffset;

    [NativeName("cr_mult")]
    public byte CrMult;

    [NativeName("cr_luma_mult")]
    public byte CrLumaMult;

    [NativeName("cr_offset")]
    public ushort CrOffset;
}
