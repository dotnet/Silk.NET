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
    [NativeName("Name", "StdVideoH265PpsFlags")]
    public unsafe partial struct StdVideoH265PpsFlags
    {
        public StdVideoH265PpsFlags
        (
            uint? dependentSliceSegmentsEnabledFlag = null,
            uint? outputFlagPresentFlag = null,
            uint? signDataHidingEnabledFlag = null,
            uint? cabacInitPresentFlag = null,
            uint? constrainedIntraPredFlag = null,
            uint? transformSkipEnabledFlag = null,
            uint? cuQpDeltaEnabledFlag = null,
            uint? ppsSliceChromaQpOffsetsPresentFlag = null,
            uint? weightedPredFlag = null,
            uint? weightedBipredFlag = null,
            uint? transquantBypassEnabledFlag = null,
            uint? tilesEnabledFlag = null,
            uint? entropyCodingSyncEnabledFlag = null,
            uint? uniformSpacingFlag = null,
            uint? loopFilterAcrossTilesEnabledFlag = null,
            uint? ppsLoopFilterAcrossSlicesEnabledFlag = null,
            uint? deblockingFilterControlPresentFlag = null,
            uint? deblockingFilterOverrideEnabledFlag = null,
            uint? ppsDeblockingFilterDisabledFlag = null,
            uint? ppsScalingListDataPresentFlag = null,
            uint? listsModificationPresentFlag = null,
            uint? sliceSegmentHeaderExtensionPresentFlag = null,
            uint? ppsExtensionPresentFlag = null,
            uint? crossComponentPredictionEnabledFlag = null,
            uint? chromaQpOffsetListEnabledFlag = null,
            uint? ppsCurrPicRefEnabledFlag = null,
            uint? residualAdaptiveColourTransformEnabledFlag = null,
            uint? ppsSliceActQpOffsetsPresentFlag = null,
            uint? ppsPalettePredictorInitializerPresentFlag = null,
            uint? monochromePaletteFlag = null,
            uint? ppsRangeExtensionFlag = null
        ) : this()
        {
            if (dependentSliceSegmentsEnabledFlag is not null)
            {
                DependentSliceSegmentsEnabledFlag = dependentSliceSegmentsEnabledFlag.Value;
            }

            if (outputFlagPresentFlag is not null)
            {
                OutputFlagPresentFlag = outputFlagPresentFlag.Value;
            }

            if (signDataHidingEnabledFlag is not null)
            {
                SignDataHidingEnabledFlag = signDataHidingEnabledFlag.Value;
            }

            if (cabacInitPresentFlag is not null)
            {
                CabacInitPresentFlag = cabacInitPresentFlag.Value;
            }

            if (constrainedIntraPredFlag is not null)
            {
                ConstrainedIntraPredFlag = constrainedIntraPredFlag.Value;
            }

            if (transformSkipEnabledFlag is not null)
            {
                TransformSkipEnabledFlag = transformSkipEnabledFlag.Value;
            }

            if (cuQpDeltaEnabledFlag is not null)
            {
                CuQpDeltaEnabledFlag = cuQpDeltaEnabledFlag.Value;
            }

            if (ppsSliceChromaQpOffsetsPresentFlag is not null)
            {
                PpsSliceChromaQpOffsetsPresentFlag = ppsSliceChromaQpOffsetsPresentFlag.Value;
            }

            if (weightedPredFlag is not null)
            {
                WeightedPredFlag = weightedPredFlag.Value;
            }

            if (weightedBipredFlag is not null)
            {
                WeightedBipredFlag = weightedBipredFlag.Value;
            }

            if (transquantBypassEnabledFlag is not null)
            {
                TransquantBypassEnabledFlag = transquantBypassEnabledFlag.Value;
            }

            if (tilesEnabledFlag is not null)
            {
                TilesEnabledFlag = tilesEnabledFlag.Value;
            }

            if (entropyCodingSyncEnabledFlag is not null)
            {
                EntropyCodingSyncEnabledFlag = entropyCodingSyncEnabledFlag.Value;
            }

            if (uniformSpacingFlag is not null)
            {
                UniformSpacingFlag = uniformSpacingFlag.Value;
            }

            if (loopFilterAcrossTilesEnabledFlag is not null)
            {
                LoopFilterAcrossTilesEnabledFlag = loopFilterAcrossTilesEnabledFlag.Value;
            }

            if (ppsLoopFilterAcrossSlicesEnabledFlag is not null)
            {
                PpsLoopFilterAcrossSlicesEnabledFlag = ppsLoopFilterAcrossSlicesEnabledFlag.Value;
            }

            if (deblockingFilterControlPresentFlag is not null)
            {
                DeblockingFilterControlPresentFlag = deblockingFilterControlPresentFlag.Value;
            }

            if (deblockingFilterOverrideEnabledFlag is not null)
            {
                DeblockingFilterOverrideEnabledFlag = deblockingFilterOverrideEnabledFlag.Value;
            }

            if (ppsDeblockingFilterDisabledFlag is not null)
            {
                PpsDeblockingFilterDisabledFlag = ppsDeblockingFilterDisabledFlag.Value;
            }

            if (ppsScalingListDataPresentFlag is not null)
            {
                PpsScalingListDataPresentFlag = ppsScalingListDataPresentFlag.Value;
            }

            if (listsModificationPresentFlag is not null)
            {
                ListsModificationPresentFlag = listsModificationPresentFlag.Value;
            }

            if (sliceSegmentHeaderExtensionPresentFlag is not null)
            {
                SliceSegmentHeaderExtensionPresentFlag = sliceSegmentHeaderExtensionPresentFlag.Value;
            }

            if (ppsExtensionPresentFlag is not null)
            {
                PpsExtensionPresentFlag = ppsExtensionPresentFlag.Value;
            }

            if (crossComponentPredictionEnabledFlag is not null)
            {
                CrossComponentPredictionEnabledFlag = crossComponentPredictionEnabledFlag.Value;
            }

            if (chromaQpOffsetListEnabledFlag is not null)
            {
                ChromaQpOffsetListEnabledFlag = chromaQpOffsetListEnabledFlag.Value;
            }

            if (ppsCurrPicRefEnabledFlag is not null)
            {
                PpsCurrPicRefEnabledFlag = ppsCurrPicRefEnabledFlag.Value;
            }

            if (residualAdaptiveColourTransformEnabledFlag is not null)
            {
                ResidualAdaptiveColourTransformEnabledFlag = residualAdaptiveColourTransformEnabledFlag.Value;
            }

            if (ppsSliceActQpOffsetsPresentFlag is not null)
            {
                PpsSliceActQpOffsetsPresentFlag = ppsSliceActQpOffsetsPresentFlag.Value;
            }

            if (ppsPalettePredictorInitializerPresentFlag is not null)
            {
                PpsPalettePredictorInitializerPresentFlag = ppsPalettePredictorInitializerPresentFlag.Value;
            }

            if (monochromePaletteFlag is not null)
            {
                MonochromePaletteFlag = monochromePaletteFlag.Value;
            }

            if (ppsRangeExtensionFlag is not null)
            {
                PpsRangeExtensionFlag = ppsRangeExtensionFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dependent_slice_segments_enabled_flag")]
        public uint DependentSliceSegmentsEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "output_flag_present_flag")]
        public uint OutputFlagPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sign_data_hiding_enabled_flag")]
        public uint SignDataHidingEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cabac_init_present_flag")]
        public uint CabacInitPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constrained_intra_pred_flag")]
        public uint ConstrainedIntraPredFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "transform_skip_enabled_flag")]
        public uint TransformSkipEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cu_qp_delta_enabled_flag")]
        public uint CuQpDeltaEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_slice_chroma_qp_offsets_present_flag")]
        public uint PpsSliceChromaQpOffsetsPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "weighted_pred_flag")]
        public uint WeightedPredFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "weighted_bipred_flag")]
        public uint WeightedBipredFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "transquant_bypass_enabled_flag")]
        public uint TransquantBypassEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "tiles_enabled_flag")]
        public uint TilesEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entropy_coding_sync_enabled_flag")]
        public uint EntropyCodingSyncEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uniform_spacing_flag")]
        public uint UniformSpacingFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "loop_filter_across_tiles_enabled_flag")]
        public uint LoopFilterAcrossTilesEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_loop_filter_across_slices_enabled_flag")]
        public uint PpsLoopFilterAcrossSlicesEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deblocking_filter_control_present_flag")]
        public uint DeblockingFilterControlPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deblocking_filter_override_enabled_flag")]
        public uint DeblockingFilterOverrideEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_deblocking_filter_disabled_flag")]
        public uint PpsDeblockingFilterDisabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_scaling_list_data_present_flag")]
        public uint PpsScalingListDataPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "lists_modification_present_flag")]
        public uint ListsModificationPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "slice_segment_header_extension_present_flag")]
        public uint SliceSegmentHeaderExtensionPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_extension_present_flag")]
        public uint PpsExtensionPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cross_component_prediction_enabled_flag")]
        public uint CrossComponentPredictionEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "chroma_qp_offset_list_enabled_flag")]
        public uint ChromaQpOffsetListEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_curr_pic_ref_enabled_flag")]
        public uint PpsCurrPicRefEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "residual_adaptive_colour_transform_enabled_flag")]
        public uint ResidualAdaptiveColourTransformEnabledFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_slice_act_qp_offsets_present_flag")]
        public uint PpsSliceActQpOffsetsPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_palette_predictor_initializer_present_flag")]
        public uint PpsPalettePredictorInitializerPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "monochrome_palette_flag")]
        public uint MonochromePaletteFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pps_range_extension_flag")]
        public uint PpsRangeExtensionFlag;
    }
}
