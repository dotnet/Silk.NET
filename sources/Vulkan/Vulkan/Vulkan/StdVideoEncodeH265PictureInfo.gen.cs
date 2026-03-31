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
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsVideoParameterSetId;

    [NativeName("pps_seq_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PpsSeqParameterSetId;

    [NativeName("pps_pic_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PpsPicParameterSetId;

    [NativeName("short_term_ref_pic_set_idx")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ShortTermRefPicSetIdx;

    [NativeName("PicOrderCntVal")]
    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCntVal;

    [NativeName("TemporalId")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265PictureInfoReserved1 Reserved1;

    [NativeName("pRefLists")]
    [NativeTypeName("const StdVideoEncodeH265ReferenceListsInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfo* PRefLists;

    [NativeName("pShortTermRefPicSet")]
    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeName("pLongTermRefPics")]
    [NativeTypeName("const StdVideoEncodeH265LongTermRefPics *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPics* PLongTermRefPics;
}
