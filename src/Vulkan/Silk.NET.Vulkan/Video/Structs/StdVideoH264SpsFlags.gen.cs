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
    [NativeName("Name", "StdVideoH264SpsFlags")]
    public unsafe partial struct StdVideoH264SpsFlags
    {
        public StdVideoH264SpsFlags
        (
            uint? constraintSet0Flag = null,
            uint? constraintSet1Flag = null,
            uint? constraintSet2Flag = null,
            uint? constraintSet3Flag = null,
            uint? constraintSet4Flag = null,
            uint? constraintSet5Flag = null,
            uint? direct8x8InferenceFlag = null,
            uint? mbAdaptiveFrameFieldFlag = null,
            uint? frameMbsOnlyFlag = null,
            uint? deltaPicOrderAlwaysZeroFlag = null,
            uint? residualColourTransformFlag = null,
            uint? gapsInFrameNumValueAllowedFlag = null,
            uint? firstPictureAfterSeekFlag = null,
            uint? qpprimeYZeroTransformBypassFlag = null,
            uint? frameCroppingFlag = null,
            uint? scalingMatrixPresentFlag = null,
            uint? vuiParametersPresentFlag = null
        ) : this()
        {
            if (constraintSet0Flag is not null)
            {
                ConstraintSet0Flag = constraintSet0Flag.Value;
            }

            if (constraintSet1Flag is not null)
            {
                ConstraintSet1Flag = constraintSet1Flag.Value;
            }

            if (constraintSet2Flag is not null)
            {
                ConstraintSet2Flag = constraintSet2Flag.Value;
            }

            if (constraintSet3Flag is not null)
            {
                ConstraintSet3Flag = constraintSet3Flag.Value;
            }

            if (constraintSet4Flag is not null)
            {
                ConstraintSet4Flag = constraintSet4Flag.Value;
            }

            if (constraintSet5Flag is not null)
            {
                ConstraintSet5Flag = constraintSet5Flag.Value;
            }

            if (direct8x8InferenceFlag is not null)
            {
                Direct8x8InferenceFlag = direct8x8InferenceFlag.Value;
            }

            if (mbAdaptiveFrameFieldFlag is not null)
            {
                MbAdaptiveFrameFieldFlag = mbAdaptiveFrameFieldFlag.Value;
            }

            if (frameMbsOnlyFlag is not null)
            {
                FrameMbsOnlyFlag = frameMbsOnlyFlag.Value;
            }

            if (deltaPicOrderAlwaysZeroFlag is not null)
            {
                DeltaPicOrderAlwaysZeroFlag = deltaPicOrderAlwaysZeroFlag.Value;
            }

            if (residualColourTransformFlag is not null)
            {
                ResidualColourTransformFlag = residualColourTransformFlag.Value;
            }

            if (gapsInFrameNumValueAllowedFlag is not null)
            {
                GapsInFrameNumValueAllowedFlag = gapsInFrameNumValueAllowedFlag.Value;
            }

            if (firstPictureAfterSeekFlag is not null)
            {
                FirstPictureAfterSeekFlag = firstPictureAfterSeekFlag.Value;
            }

            if (qpprimeYZeroTransformBypassFlag is not null)
            {
                QpprimeYZeroTransformBypassFlag = qpprimeYZeroTransformBypassFlag.Value;
            }

            if (frameCroppingFlag is not null)
            {
                FrameCroppingFlag = frameCroppingFlag.Value;
            }

            if (scalingMatrixPresentFlag is not null)
            {
                ScalingMatrixPresentFlag = scalingMatrixPresentFlag.Value;
            }

            if (vuiParametersPresentFlag is not null)
            {
                VuiParametersPresentFlag = vuiParametersPresentFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constraint_set0_flag")]
        public uint ConstraintSet0Flag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constraint_set1_flag")]
        public uint ConstraintSet1Flag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constraint_set2_flag")]
        public uint ConstraintSet2Flag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constraint_set3_flag")]
        public uint ConstraintSet3Flag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constraint_set4_flag")]
        public uint ConstraintSet4Flag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constraint_set5_flag")]
        public uint ConstraintSet5Flag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "direct_8x8_inference_flag")]
        public uint Direct8x8InferenceFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mb_adaptive_frame_field_flag")]
        public uint MbAdaptiveFrameFieldFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_mbs_only_flag")]
        public uint FrameMbsOnlyFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "delta_pic_order_always_zero_flag")]
        public uint DeltaPicOrderAlwaysZeroFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "residual_colour_transform_flag")]
        public uint ResidualColourTransformFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gaps_in_frame_num_value_allowed_flag")]
        public uint GapsInFrameNumValueAllowedFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "first_picture_after_seek_flag")]
        public uint FirstPictureAfterSeekFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "qpprime_y_zero_transform_bypass_flag")]
        public uint QpprimeYZeroTransformBypassFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_cropping_flag")]
        public uint FrameCroppingFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "scaling_matrix_present_flag")]
        public uint ScalingMatrixPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_parameters_present_flag")]
        public uint VuiParametersPresentFlag;
    }
}
