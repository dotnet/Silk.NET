// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeH264PictureInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoDecodeH264PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH264PictureInfoFlags Flags;

    [NativeName("seq_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeName("pic_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PicParameterSetId;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("reserved2")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeName("frame_num")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort FrameNum;

    [NativeName("idr_pic_id")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort IdrPicId;

    [NativeName("PicOrderCnt")]
    [NativeTypeName("int32_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH264PictureInfoPicOrderCnt PicOrderCnt;
}
