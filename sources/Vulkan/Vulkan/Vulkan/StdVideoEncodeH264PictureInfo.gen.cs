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
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeName("pic_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PicParameterSetId;

    [NativeName("idr_pic_id")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort IdrPicId;

    [NativeName("primary_pic_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264PictureType PrimaryPicType;

    [NativeName("frame_num")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameNum;

    [NativeName("PicOrderCnt")]
    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCnt;

    [NativeName("temporal_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264PictureInfoReserved1 Reserved1;

    [NativeName("pRefLists")]
    [NativeTypeName("const StdVideoEncodeH264ReferenceListsInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfo* PRefLists;
}
