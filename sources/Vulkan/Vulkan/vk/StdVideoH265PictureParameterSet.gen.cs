// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265PictureParameterSet")]
public unsafe partial struct StdVideoH265PictureParameterSet
{
    [NativeName("flags")]
    public StdVideoH265PpsFlags Flags;

    [NativeName("pps_pic_parameter_set_id")]
    public byte PpsPicParameterSetId;

    [NativeName("pps_seq_parameter_set_id")]
    public byte PpsSeqParameterSetId;

    [NativeName("sps_video_parameter_set_id")]
    public byte SpsVideoParameterSetId;

    [NativeName("num_extra_slice_header_bits")]
    public byte NumExtraSliceHeaderBits;

    [NativeName("num_ref_idx_l0_default_active_minus1")]
    public byte NumRefIdxL0DefaultActiveMinus1;

    [NativeName("num_ref_idx_l1_default_active_minus1")]
    public byte NumRefIdxL1DefaultActiveMinus1;

    [NativeName("init_qp_minus26")]
    public sbyte InitQpMinus26;

    [NativeName("diff_cu_qp_delta_depth")]
    public byte DiffCuQpDeltaDepth;

    [NativeName("pps_cb_qp_offset")]
    public sbyte PpsCbQpOffset;

    [NativeName("pps_cr_qp_offset")]
    public sbyte PpsCrQpOffset;

    [NativeName("pps_beta_offset_div2")]
    public sbyte PpsBetaOffsetDiv2;

    [NativeName("pps_tc_offset_div2")]
    public sbyte PpsTcOffsetDiv2;

    [NativeName("log2_parallel_merge_level_minus2")]
    public byte Log2ParallelMergeLevelMinus2;

    [NativeName("log2_max_transform_skip_block_size_minus2")]
    public byte Log2MaxTransformSkipBlockSizeMinus2;

    [NativeName("diff_cu_chroma_qp_offset_depth")]
    public byte DiffCuChromaQpOffsetDepth;

    [NativeName("chroma_qp_offset_list_len_minus1")]
    public byte ChromaQpOffsetListLenMinus1;

    [NativeName("cb_qp_offset_list")]
    public StdVideoH265PictureParameterSetCbQpOffsetList CbQpOffsetList;

    [NativeName("cr_qp_offset_list")]
    public StdVideoH265PictureParameterSetCrQpOffsetList CrQpOffsetList;

    [NativeName("log2_sao_offset_scale_luma")]
    public byte Log2SaoOffsetScaleLuma;

    [NativeName("log2_sao_offset_scale_chroma")]
    public byte Log2SaoOffsetScaleChroma;

    [NativeName("pps_act_y_qp_offset_plus5")]
    public sbyte PpsActYQpOffsetPlus5;

    [NativeName("pps_act_cb_qp_offset_plus5")]
    public sbyte PpsActCbQpOffsetPlus5;

    [NativeName("pps_act_cr_qp_offset_plus3")]
    public sbyte PpsActCrQpOffsetPlus3;

    [NativeName("pps_num_palette_predictor_initializers")]
    public byte PpsNumPalettePredictorInitializers;

    [NativeName("luma_bit_depth_entry_minus8")]
    public byte LumaBitDepthEntryMinus8;

    [NativeName("chroma_bit_depth_entry_minus8")]
    public byte ChromaBitDepthEntryMinus8;

    [NativeName("num_tile_columns_minus1")]
    public byte NumTileColumnsMinus1;

    [NativeName("num_tile_rows_minus1")]
    public byte NumTileRowsMinus1;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("reserved2")]
    public byte Reserved2;

    [NativeName("column_width_minus1")]
    public StdVideoH265PictureParameterSetColumnWidthMinus1 ColumnWidthMinus1;

    [NativeName("row_height_minus1")]
    public StdVideoH265PictureParameterSetRowHeightMinus1 RowHeightMinus1;

    [NativeName("reserved3")]
    public uint Reserved3;

    [NativeName("pScalingLists")]
    public StdVideoH265ScalingLists* PScalingLists;

    [NativeName("pPredictorPaletteEntries")]
    public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
}
