// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeH265PictureInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoDecodeH265PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH265PictureInfoFlags Flags;

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

    [NativeName("NumDeltaPocsOfRefRpsIdx")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumDeltaPocsOfRefRpsIdx;

    [NativeName("PicOrderCntVal")]
    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCntVal;

    [NativeName("NumBitsForSTRefPicSetInSlice")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort NumBitsForSTRefPicSetInSlice;

    [NativeName("reserved")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved;

    [NativeName("RefPicSetStCurrBefore")]
    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH265PictureInfoRefPicSetStCurrBefore RefPicSetStCurrBefore;

    [NativeName("RefPicSetStCurrAfter")]
    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH265PictureInfoRefPicSetStCurrAfter RefPicSetStCurrAfter;

    [NativeName("RefPicSetLtCurr")]
    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeH265PictureInfoRefPicSetLtCurr RefPicSetLtCurr;
}
