// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1FilmGrain")]
    public unsafe partial struct StdVideoAV1FilmGrain
    {
        public StdVideoAV1FilmGrain
        (
            StdVideoAV1FilmGrainFlags? flags = null,
            byte? grainScalingMinus8 = null,
            byte? arCoeffLag = null,
            byte? arCoeffShiftMinus6 = null,
            byte? grainScaleShift = null,
            ushort? grainSeed = null,
            byte? filmGrainParamsRefIdx = null,
            byte? numYPoints = null,
            byte? numCbPoints = null,
            byte? numCrPoints = null,
            byte? cbMult = null,
            byte? cbLumaMult = null,
            ushort? cbOffset = null,
            byte? crMult = null,
            byte? crLumaMult = null,
            ushort? crOffset = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (grainScalingMinus8 is not null)
            {
                GrainScalingMinus8 = grainScalingMinus8.Value;
            }

            if (arCoeffLag is not null)
            {
                ArCoeffLag = arCoeffLag.Value;
            }

            if (arCoeffShiftMinus6 is not null)
            {
                ArCoeffShiftMinus6 = arCoeffShiftMinus6.Value;
            }

            if (grainScaleShift is not null)
            {
                GrainScaleShift = grainScaleShift.Value;
            }

            if (grainSeed is not null)
            {
                GrainSeed = grainSeed.Value;
            }

            if (filmGrainParamsRefIdx is not null)
            {
                FilmGrainParamsRefIdx = filmGrainParamsRefIdx.Value;
            }

            if (numYPoints is not null)
            {
                NumYPoints = numYPoints.Value;
            }

            if (numCbPoints is not null)
            {
                NumCbPoints = numCbPoints.Value;
            }

            if (numCrPoints is not null)
            {
                NumCrPoints = numCrPoints.Value;
            }

            if (cbMult is not null)
            {
                CbMult = cbMult.Value;
            }

            if (cbLumaMult is not null)
            {
                CbLumaMult = cbLumaMult.Value;
            }

            if (cbOffset is not null)
            {
                CbOffset = cbOffset.Value;
            }

            if (crMult is not null)
            {
                CrMult = crMult.Value;
            }

            if (crLumaMult is not null)
            {
                CrLumaMult = crLumaMult.Value;
            }

            if (crOffset is not null)
            {
                CrOffset = crOffset.Value;
            }
        }


        [NativeName("Type", "StdVideoAV1FilmGrainFlags")]
        [NativeName("Type.Name", "StdVideoAV1FilmGrainFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1FilmGrainFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "grain_scaling_minus_8")]
        public byte GrainScalingMinus8;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "ar_coeff_lag")]
        public byte ArCoeffLag;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "ar_coeff_shift_minus_6")]
        public byte ArCoeffShiftMinus6;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "grain_scale_shift")]
        public byte GrainScaleShift;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "grain_seed")]
        public ushort GrainSeed;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "film_grain_params_ref_idx")]
        public byte FilmGrainParamsRefIdx;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_y_points")]
        public byte NumYPoints;
        [NativeName("Type", "uint8_t[14]")]
        [NativeName("Type.Name", "uint8_t[14]")]
        [NativeName("Name", "point_y_value")]
        public fixed byte PointYValue[14];
        [NativeName("Type", "uint8_t[14]")]
        [NativeName("Type.Name", "uint8_t[14]")]
        [NativeName("Name", "point_y_scaling")]
        public fixed byte PointYScaling[14];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_cb_points")]
        public byte NumCbPoints;
        [NativeName("Type", "uint8_t[10]")]
        [NativeName("Type.Name", "uint8_t[10]")]
        [NativeName("Name", "point_cb_value")]
        public fixed byte PointCbValue[10];
        [NativeName("Type", "uint8_t[10]")]
        [NativeName("Type.Name", "uint8_t[10]")]
        [NativeName("Name", "point_cb_scaling")]
        public fixed byte PointCbScaling[10];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_cr_points")]
        public byte NumCrPoints;
        [NativeName("Type", "uint8_t[10]")]
        [NativeName("Type.Name", "uint8_t[10]")]
        [NativeName("Name", "point_cr_value")]
        public fixed byte PointCrValue[10];
        [NativeName("Type", "uint8_t[10]")]
        [NativeName("Type.Name", "uint8_t[10]")]
        [NativeName("Name", "point_cr_scaling")]
        public fixed byte PointCrScaling[10];
        [NativeName("Type", "int8_t[24]")]
        [NativeName("Type.Name", "int8_t[24]")]
        [NativeName("Name", "ar_coeffs_y_plus_128")]
        public fixed byte ArCoeffsYPlus128[24];
        [NativeName("Type", "int8_t[25]")]
        [NativeName("Type.Name", "int8_t[25]")]
        [NativeName("Name", "ar_coeffs_cb_plus_128")]
        public fixed byte ArCoeffsCbPlus128[25];
        [NativeName("Type", "int8_t[25]")]
        [NativeName("Type.Name", "int8_t[25]")]
        [NativeName("Name", "ar_coeffs_cr_plus_128")]
        public fixed byte ArCoeffsCrPlus128[25];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cb_mult")]
        public byte CbMult;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cb_luma_mult")]
        public byte CbLumaMult;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "cb_offset")]
        public ushort CbOffset;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cr_mult")]
        public byte CrMult;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cr_luma_mult")]
        public byte CrLumaMult;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "cr_offset")]
        public ushort CrOffset;
    }
}
