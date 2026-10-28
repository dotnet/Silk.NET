// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264SequenceParameterSet")]
public unsafe partial struct StdVideoH264SequenceParameterSet
{
    [NativeName("flags")]
    public StdVideoH264SpsFlags Flags;

    [NativeName("profile_idc")]
    public StdVideoH264ProfileIdc ProfileIdc;

    [NativeName("level_idc")]
    public StdVideoH264LevelIdc LevelIdc;

    [NativeName("chroma_format_idc")]
    public StdVideoH264ChromaFormatIdc ChromaFormatIdc;

    [NativeName("seq_parameter_set_id")]
    public byte SeqParameterSetId;

    [NativeName("bit_depth_luma_minus8")]
    public byte BitDepthLumaMinus8;

    [NativeName("bit_depth_chroma_minus8")]
    public byte BitDepthChromaMinus8;

    [NativeName("log2_max_frame_num_minus4")]
    public byte Log2MaxFrameNumMinus4;

    [NativeName("pic_order_cnt_type")]
    public StdVideoH264PocType PicOrderCntType;

    [NativeName("offset_for_non_ref_pic")]
    public int OffsetForNonRefPic;

    [NativeName("offset_for_top_to_bottom_field")]
    public int OffsetForTopToBottomField;

    [NativeName("log2_max_pic_order_cnt_lsb_minus4")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeName("num_ref_frames_in_pic_order_cnt_cycle")]
    public byte NumRefFramesInPicOrderCntCycle;

    [NativeName("max_num_ref_frames")]
    public byte MaxNumRefFrames;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("pic_width_in_mbs_minus1")]
    public uint PicWidthInMbsMinus1;

    [NativeName("pic_height_in_map_units_minus1")]
    public uint PicHeightInMapUnitsMinus1;

    [NativeName("frame_crop_left_offset")]
    public uint FrameCropLeftOffset;

    [NativeName("frame_crop_right_offset")]
    public uint FrameCropRightOffset;

    [NativeName("frame_crop_top_offset")]
    public uint FrameCropTopOffset;

    [NativeName("frame_crop_bottom_offset")]
    public uint FrameCropBottomOffset;

    [NativeName("reserved2")]
    public uint Reserved2;

    [NativeName("pOffsetForRefFrame")]
    public int* POffsetForRefFrame;

    [NativeName("pScalingLists")]
    public StdVideoH264ScalingLists* PScalingLists;

    [NativeName("pSequenceParameterSetVui")]
    public StdVideoH264SequenceParameterSetVui* PSequenceParameterSetVui;
}
