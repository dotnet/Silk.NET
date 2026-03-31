// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SequenceParameterSet")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265SequenceParameterSet
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SpsFlags Flags;

    [NativeName("chroma_format_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ChromaFormatIdc ChromaFormatIdc;

    [NativeName("pic_width_in_luma_samples")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PicWidthInLumaSamples;

    [NativeName("pic_height_in_luma_samples")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PicHeightInLumaSamples;

    [NativeName("sps_video_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsVideoParameterSetId;

    [NativeName("sps_max_sub_layers_minus1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsMaxSubLayersMinus1;

    [NativeName("sps_seq_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsSeqParameterSetId;

    [NativeName("bit_depth_luma_minus8")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthLumaMinus8;

    [NativeName("bit_depth_chroma_minus8")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthChromaMinus8;

    [NativeName("log2_max_pic_order_cnt_lsb_minus4")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeName("log2_min_luma_coding_block_size_minus3")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MinLumaCodingBlockSizeMinus3;

    [NativeName("log2_diff_max_min_luma_coding_block_size")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2DiffMaxMinLumaCodingBlockSize;

    [NativeName("log2_min_luma_transform_block_size_minus2")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MinLumaTransformBlockSizeMinus2;

    [NativeName("log2_diff_max_min_luma_transform_block_size")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2DiffMaxMinLumaTransformBlockSize;

    [NativeName("max_transform_hierarchy_depth_inter")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxTransformHierarchyDepthInter;

    [NativeName("max_transform_hierarchy_depth_intra")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxTransformHierarchyDepthIntra;

    [NativeName("num_short_term_ref_pic_sets")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumShortTermRefPicSets;

    [NativeName("num_long_term_ref_pics_sps")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumLongTermRefPicsSps;

    [NativeName("pcm_sample_bit_depth_luma_minus1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PcmSampleBitDepthLumaMinus1;

    [NativeName("pcm_sample_bit_depth_chroma_minus1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PcmSampleBitDepthChromaMinus1;

    [NativeName("log2_min_pcm_luma_coding_block_size_minus3")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MinPcmLumaCodingBlockSizeMinus3;

    [NativeName("log2_diff_max_min_pcm_luma_coding_block_size")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2DiffMaxMinPcmLumaCodingBlockSize;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("reserved2")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeName("palette_max_size")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PaletteMaxSize;

    [NativeName("delta_palette_max_predictor_size")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaPaletteMaxPredictorSize;

    [NativeName("motion_vector_resolution_control_idc")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MotionVectorResolutionControlIdc;

    [NativeName("sps_num_palette_predictor_initializers_minus1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsNumPalettePredictorInitializersMinus1;

    [NativeName("conf_win_left_offset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinLeftOffset;

    [NativeName("conf_win_right_offset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinRightOffset;

    [NativeName("conf_win_top_offset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinTopOffset;

    [NativeName("conf_win_bottom_offset")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinBottomOffset;

    [NativeName("pProfileTierLevel")]
    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;

    [NativeName("pDecPicBufMgr")]
    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeName("pScalingLists")]
    [NativeTypeName("const StdVideoH265ScalingLists *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingLists* PScalingLists;

    [NativeName("pShortTermRefPicSet")]
    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeName("pLongTermRefPicsSps")]
    [NativeTypeName("const StdVideoH265LongTermRefPicsSps *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265LongTermRefPicsSps* PLongTermRefPicsSps;

    [NativeName("pSequenceParameterSetVui")]
    [NativeTypeName("const StdVideoH265SequenceParameterSetVui *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SequenceParameterSetVui* PSequenceParameterSetVui;

    [NativeName("pPredictorPaletteEntries")]
    [NativeTypeName("const StdVideoH265PredictorPaletteEntries *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
}
