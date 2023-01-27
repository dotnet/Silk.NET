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
    [NativeName("Name", "StdVideoH265PictureParameterSet")]
    public unsafe partial struct StdVideoH265PictureParameterSet
    {
        public StdVideoH265PictureParameterSet
        (
            StdVideoH265PpsFlags? flags = null,
            byte? ppsPicParameterSetId = null,
            byte? ppsSeqParameterSetId = null,
            byte? spsVideoParameterSetId = null,
            byte? numExtraSliceHeaderBits = null,
            byte? numRefIdxL0DefaultActiveMinus1 = null,
            byte? numRefIdxL1DefaultActiveMinus1 = null,
            byte? initQpMinus26 = null,
            byte? diffCuQpDeltaDepth = null,
            byte? ppsCbQpOffset = null,
            byte? ppsCrQpOffset = null,
            byte? ppsBetaOffsetDiv2 = null,
            byte? ppsTcOffsetDiv2 = null,
            byte? log2ParallelMergeLevelMinus2 = null,
            byte? log2MaxTransformSkipBlockSizeMinus2 = null,
            byte? diffCuChromaQpOffsetDepth = null,
            byte? chromaQpOffsetListLenMinus1 = null,
            byte? log2SaoOffsetScaleLuma = null,
            byte? log2SaoOffsetScaleChroma = null,
            byte? ppsActYQpOffsetPlus5 = null,
            byte? ppsActCbQpOffsetPlus5 = null,
            byte? ppsActCrQpOffsetPlus3 = null,
            byte? ppsNumPalettePredictorInitializers = null,
            byte? lumaBitDepthEntryMinus8 = null,
            byte? chromaBitDepthEntryMinus8 = null,
            byte? numTileColumnsMinus1 = null,
            byte? numTileRowsMinus1 = null,
            byte? reserved1 = null,
            byte? reserved2 = null,
            uint? reserved3 = null,
            StdVideoH265ScalingLists* pScalingLists = null,
            StdVideoH265PredictorPaletteEntries* pPredictorPaletteEntries = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (ppsPicParameterSetId is not null)
            {
                PpsPicParameterSetId = ppsPicParameterSetId.Value;
            }

            if (ppsSeqParameterSetId is not null)
            {
                PpsSeqParameterSetId = ppsSeqParameterSetId.Value;
            }

            if (spsVideoParameterSetId is not null)
            {
                SpsVideoParameterSetId = spsVideoParameterSetId.Value;
            }

            if (numExtraSliceHeaderBits is not null)
            {
                NumExtraSliceHeaderBits = numExtraSliceHeaderBits.Value;
            }

            if (numRefIdxL0DefaultActiveMinus1 is not null)
            {
                NumRefIdxL0DefaultActiveMinus1 = numRefIdxL0DefaultActiveMinus1.Value;
            }

            if (numRefIdxL1DefaultActiveMinus1 is not null)
            {
                NumRefIdxL1DefaultActiveMinus1 = numRefIdxL1DefaultActiveMinus1.Value;
            }

            if (initQpMinus26 is not null)
            {
                InitQpMinus26 = initQpMinus26.Value;
            }

            if (diffCuQpDeltaDepth is not null)
            {
                DiffCuQpDeltaDepth = diffCuQpDeltaDepth.Value;
            }

            if (ppsCbQpOffset is not null)
            {
                PpsCbQpOffset = ppsCbQpOffset.Value;
            }

            if (ppsCrQpOffset is not null)
            {
                PpsCrQpOffset = ppsCrQpOffset.Value;
            }

            if (ppsBetaOffsetDiv2 is not null)
            {
                PpsBetaOffsetDiv2 = ppsBetaOffsetDiv2.Value;
            }

            if (ppsTcOffsetDiv2 is not null)
            {
                PpsTcOffsetDiv2 = ppsTcOffsetDiv2.Value;
            }

            if (log2ParallelMergeLevelMinus2 is not null)
            {
                Log2ParallelMergeLevelMinus2 = log2ParallelMergeLevelMinus2.Value;
            }

            if (log2MaxTransformSkipBlockSizeMinus2 is not null)
            {
                Log2MaxTransformSkipBlockSizeMinus2 = log2MaxTransformSkipBlockSizeMinus2.Value;
            }

            if (diffCuChromaQpOffsetDepth is not null)
            {
                DiffCuChromaQpOffsetDepth = diffCuChromaQpOffsetDepth.Value;
            }

            if (chromaQpOffsetListLenMinus1 is not null)
            {
                ChromaQpOffsetListLenMinus1 = chromaQpOffsetListLenMinus1.Value;
            }

            if (log2SaoOffsetScaleLuma is not null)
            {
                Log2SaoOffsetScaleLuma = log2SaoOffsetScaleLuma.Value;
            }

            if (log2SaoOffsetScaleChroma is not null)
            {
                Log2SaoOffsetScaleChroma = log2SaoOffsetScaleChroma.Value;
            }

            if (ppsActYQpOffsetPlus5 is not null)
            {
                PpsActYQpOffsetPlus5 = ppsActYQpOffsetPlus5.Value;
            }

            if (ppsActCbQpOffsetPlus5 is not null)
            {
                PpsActCbQpOffsetPlus5 = ppsActCbQpOffsetPlus5.Value;
            }

            if (ppsActCrQpOffsetPlus3 is not null)
            {
                PpsActCrQpOffsetPlus3 = ppsActCrQpOffsetPlus3.Value;
            }

            if (ppsNumPalettePredictorInitializers is not null)
            {
                PpsNumPalettePredictorInitializers = ppsNumPalettePredictorInitializers.Value;
            }

            if (lumaBitDepthEntryMinus8 is not null)
            {
                LumaBitDepthEntryMinus8 = lumaBitDepthEntryMinus8.Value;
            }

            if (chromaBitDepthEntryMinus8 is not null)
            {
                ChromaBitDepthEntryMinus8 = chromaBitDepthEntryMinus8.Value;
            }

            if (numTileColumnsMinus1 is not null)
            {
                NumTileColumnsMinus1 = numTileColumnsMinus1.Value;
            }

            if (numTileRowsMinus1 is not null)
            {
                NumTileRowsMinus1 = numTileRowsMinus1.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (pScalingLists is not null)
            {
                PScalingLists = pScalingLists;
            }

            if (pPredictorPaletteEntries is not null)
            {
                PPredictorPaletteEntries = pPredictorPaletteEntries;
            }
        }


        [NativeName("Type", "StdVideoH265PpsFlags")]
        [NativeName("Type.Name", "StdVideoH265PpsFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265PpsFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pps_pic_parameter_set_id")]
        public byte PpsPicParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pps_seq_parameter_set_id")]
        public byte PpsSeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_video_parameter_set_id")]
        public byte SpsVideoParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_extra_slice_header_bits")]
        public byte NumExtraSliceHeaderBits;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l0_default_active_minus1")]
        public byte NumRefIdxL0DefaultActiveMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_ref_idx_l1_default_active_minus1")]
        public byte NumRefIdxL1DefaultActiveMinus1;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "init_qp_minus26")]
        public byte InitQpMinus26;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "diff_cu_qp_delta_depth")]
        public byte DiffCuQpDeltaDepth;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_cb_qp_offset")]
        public byte PpsCbQpOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_cr_qp_offset")]
        public byte PpsCrQpOffset;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_beta_offset_div2")]
        public byte PpsBetaOffsetDiv2;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_tc_offset_div2")]
        public byte PpsTcOffsetDiv2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_parallel_merge_level_minus2")]
        public byte Log2ParallelMergeLevelMinus2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_max_transform_skip_block_size_minus2")]
        public byte Log2MaxTransformSkipBlockSizeMinus2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "diff_cu_chroma_qp_offset_depth")]
        public byte DiffCuChromaQpOffsetDepth;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_qp_offset_list_len_minus1")]
        public byte ChromaQpOffsetListLenMinus1;
        [NativeName("Type", "int8_t[6]")]
        [NativeName("Type.Name", "int8_t[6]")]
        [NativeName("Name", "cb_qp_offset_list")]
        public fixed byte CbQpOffsetList[6];
        [NativeName("Type", "int8_t[6]")]
        [NativeName("Type.Name", "int8_t[6]")]
        [NativeName("Name", "cr_qp_offset_list")]
        public fixed byte CrQpOffsetList[6];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_sao_offset_scale_luma")]
        public byte Log2SaoOffsetScaleLuma;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "log2_sao_offset_scale_chroma")]
        public byte Log2SaoOffsetScaleChroma;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_act_y_qp_offset_plus5")]
        public byte PpsActYQpOffsetPlus5;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_act_cb_qp_offset_plus5")]
        public byte PpsActCbQpOffsetPlus5;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "pps_act_cr_qp_offset_plus3")]
        public byte PpsActCrQpOffsetPlus3;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pps_num_palette_predictor_initializers")]
        public byte PpsNumPalettePredictorInitializers;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "luma_bit_depth_entry_minus8")]
        public byte LumaBitDepthEntryMinus8;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_bit_depth_entry_minus8")]
        public byte ChromaBitDepthEntryMinus8;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_tile_columns_minus1")]
        public byte NumTileColumnsMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_tile_rows_minus1")]
        public byte NumTileRowsMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved2")]
        public byte Reserved2;
        [NativeName("Type", "uint16_t[19]")]
        [NativeName("Type.Name", "uint16_t[19]")]
        [NativeName("Name", "column_width_minus1")]
        public fixed ushort ColumnWidthMinus1[19];
        [NativeName("Type", "uint16_t[21]")]
        [NativeName("Type.Name", "uint16_t[21]")]
        [NativeName("Name", "row_height_minus1")]
        public fixed ushort RowHeightMinus1[21];

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "reserved3")]
        public uint Reserved3;

        [NativeName("Type", "const StdVideoH265ScalingLists *")]
        [NativeName("Type.Name", "const StdVideoH265ScalingLists *")]
        [NativeName("Name", "pScalingLists")]
        public StdVideoH265ScalingLists* PScalingLists;

        [NativeName("Type", "const StdVideoH265PredictorPaletteEntries *")]
        [NativeName("Type.Name", "const StdVideoH265PredictorPaletteEntries *")]
        [NativeName("Name", "pPredictorPaletteEntries")]
        public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
    }
}
