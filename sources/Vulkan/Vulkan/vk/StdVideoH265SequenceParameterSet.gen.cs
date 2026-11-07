// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SequenceParameterSet")]
public unsafe partial struct StdVideoH265SequenceParameterSet
{
    [NativeName("flags")]
    public StdVideoH265SpsFlags Flags;

    [NativeName("chroma_format_idc")]
    public StdVideoH265ChromaFormatIdc ChromaFormatIdc;

    [NativeName("pic_width_in_luma_samples")]
    public uint PicWidthInLumaSamples;

    [NativeName("pic_height_in_luma_samples")]
    public uint PicHeightInLumaSamples;

    [NativeName("sps_video_parameter_set_id")]
    public byte SpsVideoParameterSetId;

    [NativeName("sps_max_sub_layers_minus1")]
    public byte SpsMaxSubLayersMinus1;

    [NativeName("sps_seq_parameter_set_id")]
    public byte SpsSeqParameterSetId;

    [NativeName("bit_depth_luma_minus8")]
    public byte BitDepthLumaMinus8;

    [NativeName("bit_depth_chroma_minus8")]
    public byte BitDepthChromaMinus8;

    [NativeName("log2_max_pic_order_cnt_lsb_minus4")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeName("log2_min_luma_coding_block_size_minus3")]
    public byte Log2MinLumaCodingBlockSizeMinus3;

    [NativeName("log2_diff_max_min_luma_coding_block_size")]
    public byte Log2DiffMaxMinLumaCodingBlockSize;

    [NativeName("log2_min_luma_transform_block_size_minus2")]
    public byte Log2MinLumaTransformBlockSizeMinus2;

    [NativeName("log2_diff_max_min_luma_transform_block_size")]
    public byte Log2DiffMaxMinLumaTransformBlockSize;

    [NativeName("max_transform_hierarchy_depth_inter")]
    public byte MaxTransformHierarchyDepthInter;

    [NativeName("max_transform_hierarchy_depth_intra")]
    public byte MaxTransformHierarchyDepthIntra;

    [NativeName("num_short_term_ref_pic_sets")]
    public byte NumShortTermRefPicSets;

    [NativeName("num_long_term_ref_pics_sps")]
    public byte NumLongTermRefPicsSps;

    [NativeName("pcm_sample_bit_depth_luma_minus1")]
    public byte PcmSampleBitDepthLumaMinus1;

    [NativeName("pcm_sample_bit_depth_chroma_minus1")]
    public byte PcmSampleBitDepthChromaMinus1;

    [NativeName("log2_min_pcm_luma_coding_block_size_minus3")]
    public byte Log2MinPcmLumaCodingBlockSizeMinus3;

    [NativeName("log2_diff_max_min_pcm_luma_coding_block_size")]
    public byte Log2DiffMaxMinPcmLumaCodingBlockSize;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("reserved2")]
    public byte Reserved2;

    [NativeName("palette_max_size")]
    public byte PaletteMaxSize;

    [NativeName("delta_palette_max_predictor_size")]
    public byte DeltaPaletteMaxPredictorSize;

    [NativeName("motion_vector_resolution_control_idc")]
    public byte MotionVectorResolutionControlIdc;

    [NativeName("sps_num_palette_predictor_initializers_minus1")]
    public byte SpsNumPalettePredictorInitializersMinus1;

    [NativeName("conf_win_left_offset")]
    public uint ConfWinLeftOffset;

    [NativeName("conf_win_right_offset")]
    public uint ConfWinRightOffset;

    [NativeName("conf_win_top_offset")]
    public uint ConfWinTopOffset;

    [NativeName("conf_win_bottom_offset")]
    public uint ConfWinBottomOffset;

    [NativeName("pProfileTierLevel")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;

    [NativeName("pDecPicBufMgr")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeName("pScalingLists")]
    public StdVideoH265ScalingLists* PScalingLists;

    [NativeName("pShortTermRefPicSet")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeName("pLongTermRefPicsSps")]
    public StdVideoH265LongTermRefPicsSps* PLongTermRefPicsSps;

    [NativeName("pSequenceParameterSetVui")]
    public StdVideoH265SequenceParameterSetVui* PSequenceParameterSetVui;

    [NativeName("pPredictorPaletteEntries")]
    public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
}
