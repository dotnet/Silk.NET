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
    [NativeName("Name", "StdVideoH265SpsFlags")]
    public unsafe partial struct StdVideoH265SpsFlags
    {
        public StdVideoH265SpsFlags
        (
            uint? spsTemporalIdNestingFlag = null,
            uint? separateColourPlaneFlag = null,
            uint? scalingListEnabledFlag = null,
            uint? spsScalingListDataPresentFlag = null,
            uint? ampEnabledFlag = null,
            uint? sampleAdaptiveOffsetEnabledFlag = null,
            uint? pcmEnabledFlag = null,
            uint? pcmLoopFilterDisabledFlag = null,
            uint? longTermRefPicsPresentFlag = null,
            uint? spsTemporalMvpEnabledFlag = null,
            uint? strongIntraSmoothingEnabledFlag = null,
            uint? vuiParametersPresentFlag = null,
            uint? spsExtensionPresentFlag = null,
            uint? spsRangeExtensionFlag = null,
            uint? transformSkipRotationEnabledFlag = null,
            uint? transformSkipContextEnabledFlag = null,
            uint? implicitRdpcmEnabledFlag = null,
            uint? explicitRdpcmEnabledFlag = null,
            uint? extendedPrecisionProcessingFlag = null,
            uint? intraSmoothingDisabledFlag = null,
            uint? highPrecisionOffsetsEnabledFlag = null,
            uint? persistentRiceAdaptationEnabledFlag = null,
            uint? cabacBypassAlignmentEnabledFlag = null,
            uint? spsCurrPicRefEnabledFlag = null,
            uint? paletteModeEnabledFlag = null,
            uint? spsPalettePredictorInitializerPresentFlag = null,
            uint? intraBoundaryFilteringDisabledFlag = null
        ) : this()
        {
            if (spsTemporalIdNestingFlag is not null)
            {
                SpsTemporalIdNestingFlag = spsTemporalIdNestingFlag.Value;
            }

            if (separateColourPlaneFlag is not null)
            {
                SeparateColourPlaneFlag = separateColourPlaneFlag.Value;
            }

            if (scalingListEnabledFlag is not null)
            {
                ScalingListEnabledFlag = scalingListEnabledFlag.Value;
            }

            if (spsScalingListDataPresentFlag is not null)
            {
                SpsScalingListDataPresentFlag = spsScalingListDataPresentFlag.Value;
            }

            if (ampEnabledFlag is not null)
            {
                AmpEnabledFlag = ampEnabledFlag.Value;
            }

            if (sampleAdaptiveOffsetEnabledFlag is not null)
            {
                SampleAdaptiveOffsetEnabledFlag = sampleAdaptiveOffsetEnabledFlag.Value;
            }

            if (pcmEnabledFlag is not null)
            {
                PcmEnabledFlag = pcmEnabledFlag.Value;
            }

            if (pcmLoopFilterDisabledFlag is not null)
            {
                PcmLoopFilterDisabledFlag = pcmLoopFilterDisabledFlag.Value;
            }

            if (longTermRefPicsPresentFlag is not null)
            {
                LongTermRefPicsPresentFlag = longTermRefPicsPresentFlag.Value;
            }

            if (spsTemporalMvpEnabledFlag is not null)
            {
                SpsTemporalMvpEnabledFlag = spsTemporalMvpEnabledFlag.Value;
            }

            if (strongIntraSmoothingEnabledFlag is not null)
            {
                StrongIntraSmoothingEnabledFlag = strongIntraSmoothingEnabledFlag.Value;
            }

            if (vuiParametersPresentFlag is not null)
            {
                VuiParametersPresentFlag = vuiParametersPresentFlag.Value;
            }

            if (spsExtensionPresentFlag is not null)
            {
                SpsExtensionPresentFlag = spsExtensionPresentFlag.Value;
            }

            if (spsRangeExtensionFlag is not null)
            {
                SpsRangeExtensionFlag = spsRangeExtensionFlag.Value;
            }

            if (transformSkipRotationEnabledFlag is not null)
            {
                TransformSkipRotationEnabledFlag = transformSkipRotationEnabledFlag.Value;
            }

            if (transformSkipContextEnabledFlag is not null)
            {
                TransformSkipContextEnabledFlag = transformSkipContextEnabledFlag.Value;
            }

            if (implicitRdpcmEnabledFlag is not null)
            {
                ImplicitRdpcmEnabledFlag = implicitRdpcmEnabledFlag.Value;
            }

            if (explicitRdpcmEnabledFlag is not null)
            {
                ExplicitRdpcmEnabledFlag = explicitRdpcmEnabledFlag.Value;
            }

            if (extendedPrecisionProcessingFlag is not null)
            {
                ExtendedPrecisionProcessingFlag = extendedPrecisionProcessingFlag.Value;
            }

            if (intraSmoothingDisabledFlag is not null)
            {
                IntraSmoothingDisabledFlag = intraSmoothingDisabledFlag.Value;
            }

            if (highPrecisionOffsetsEnabledFlag is not null)
            {
                HighPrecisionOffsetsEnabledFlag = highPrecisionOffsetsEnabledFlag.Value;
            }

            if (persistentRiceAdaptationEnabledFlag is not null)
            {
                PersistentRiceAdaptationEnabledFlag = persistentRiceAdaptationEnabledFlag.Value;
            }

            if (cabacBypassAlignmentEnabledFlag is not null)
            {
                CabacBypassAlignmentEnabledFlag = cabacBypassAlignmentEnabledFlag.Value;
            }

            if (spsCurrPicRefEnabledFlag is not null)
            {
                SpsCurrPicRefEnabledFlag = spsCurrPicRefEnabledFlag.Value;
            }

            if (paletteModeEnabledFlag is not null)
            {
                PaletteModeEnabledFlag = paletteModeEnabledFlag.Value;
            }

            if (spsPalettePredictorInitializerPresentFlag is not null)
            {
                SpsPalettePredictorInitializerPresentFlag = spsPalettePredictorInitializerPresentFlag.Value;
            }

            if (intraBoundaryFilteringDisabledFlag is not null)
            {
                IntraBoundaryFilteringDisabledFlag = intraBoundaryFilteringDisabledFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_temporal_id_nesting_flag")]
        public uint SpsTemporalIdNestingFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "separate_colour_plane_flag")]
        public uint SeparateColourPlaneFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "scaling_list_enabled_flag")]
        public uint ScalingListEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_scaling_list_data_present_flag")]
        public uint SpsScalingListDataPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "amp_enabled_flag")]
        public uint AmpEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sample_adaptive_offset_enabled_flag")]
        public uint SampleAdaptiveOffsetEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pcm_enabled_flag")]
        public uint PcmEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pcm_loop_filter_disabled_flag")]
        public uint PcmLoopFilterDisabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "long_term_ref_pics_present_flag")]
        public uint LongTermRefPicsPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_temporal_mvp_enabled_flag")]
        public uint SpsTemporalMvpEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "strong_intra_smoothing_enabled_flag")]
        public uint StrongIntraSmoothingEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vui_parameters_present_flag")]
        public uint VuiParametersPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_extension_present_flag")]
        public uint SpsExtensionPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_range_extension_flag")]
        public uint SpsRangeExtensionFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "transform_skip_rotation_enabled_flag")]
        public uint TransformSkipRotationEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "transform_skip_context_enabled_flag")]
        public uint TransformSkipContextEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "implicit_rdpcm_enabled_flag")]
        public uint ImplicitRdpcmEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "explicit_rdpcm_enabled_flag")]
        public uint ExplicitRdpcmEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "extended_precision_processing_flag")]
        public uint ExtendedPrecisionProcessingFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "intra_smoothing_disabled_flag")]
        public uint IntraSmoothingDisabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "high_precision_offsets_enabled_flag")]
        public uint HighPrecisionOffsetsEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "persistent_rice_adaptation_enabled_flag")]
        public uint PersistentRiceAdaptationEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cabac_bypass_alignment_enabled_flag")]
        public uint CabacBypassAlignmentEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_curr_pic_ref_enabled_flag")]
        public uint SpsCurrPicRefEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "palette_mode_enabled_flag")]
        public uint PaletteModeEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sps_palette_predictor_initializer_present_flag")]
        public uint SpsPalettePredictorInitializerPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "intra_boundary_filtering_disabled_flag")]
        public uint IntraBoundaryFilteringDisabledFlag;
    }
}
