// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264SequenceParameterSet")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH264SequenceParameterSet
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SpsFlags Flags;

    [NativeName("profile_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ProfileIdc ProfileIdc;

    [NativeName("level_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264LevelIdc LevelIdc;

    [NativeName("chroma_format_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ChromaFormatIdc ChromaFormatIdc;

    [NativeName("seq_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeName("bit_depth_luma_minus8")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthLumaMinus8;

    [NativeName("bit_depth_chroma_minus8")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthChromaMinus8;

    [NativeName("log2_max_frame_num_minus4")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxFrameNumMinus4;

    [NativeName("pic_order_cnt_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264PocType PicOrderCntType;

    [NativeName("offset_for_non_ref_pic")]
    [SupportedApiProfile("vulkan")]
    public int OffsetForNonRefPic;

    [NativeName("offset_for_top_to_bottom_field")]
    [SupportedApiProfile("vulkan")]
    public int OffsetForTopToBottomField;

    [NativeName("log2_max_pic_order_cnt_lsb_minus4")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeName("num_ref_frames_in_pic_order_cnt_cycle")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefFramesInPicOrderCntCycle;

    [NativeName("max_num_ref_frames")]
    [SupportedApiProfile("vulkan")]
    public byte MaxNumRefFrames;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("pic_width_in_mbs_minus1")]
    [SupportedApiProfile("vulkan")]
    public uint PicWidthInMbsMinus1;

    [NativeName("pic_height_in_map_units_minus1")]
    [SupportedApiProfile("vulkan")]
    public uint PicHeightInMapUnitsMinus1;

    [NativeName("frame_crop_left_offset")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropLeftOffset;

    [NativeName("frame_crop_right_offset")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropRightOffset;

    [NativeName("frame_crop_top_offset")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropTopOffset;

    [NativeName("frame_crop_bottom_offset")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropBottomOffset;

    [NativeName("reserved2")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved2;

    [NativeName("pOffsetForRefFrame")]
    [SupportedApiProfile("vulkan")]
    public int* POffsetForRefFrame;

    [NativeName("pScalingLists")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingLists* PScalingLists;

    [NativeName("pSequenceParameterSetVui")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SequenceParameterSetVui* PSequenceParameterSetVui;
}
