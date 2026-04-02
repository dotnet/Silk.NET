// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264PictureInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH264PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264PictureInfoFlags Flags;

    [NativeName("seq_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeName("pic_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte PicParameterSetId;

    [NativeName("idr_pic_id")]
    [SupportedApiProfile("vulkan")]
    public ushort IdrPicId;

    [NativeName("primary_pic_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264PictureType PrimaryPicType;

    [NativeName("frame_num")]
    [SupportedApiProfile("vulkan")]
    public uint FrameNum;

    [NativeName("PicOrderCnt")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCnt;

    [NativeName("temporal_id")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264PictureInfoReserved1 Reserved1;

    [NativeName("pRefLists")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfo* PRefLists;
}
