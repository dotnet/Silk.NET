// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265PictureInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH265PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265PictureInfoFlags Flags;

    [NativeName("pic_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265PictureType PicType;

    [NativeName("sps_video_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte SpsVideoParameterSetId;

    [NativeName("pps_seq_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte PpsSeqParameterSetId;

    [NativeName("pps_pic_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte PpsPicParameterSetId;

    [NativeName("short_term_ref_pic_set_idx")]
    [SupportedApiProfile("vulkan")]
    public byte ShortTermRefPicSetIdx;

    [NativeName("PicOrderCntVal")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCntVal;

    [NativeName("TemporalId")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265PictureInfoReserved1 Reserved1;

    [NativeName("pRefLists")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfo* PRefLists;

    [NativeName("pShortTermRefPicSet")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeName("pLongTermRefPics")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPics* PLongTermRefPics;
}
