// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeH265PictureInfo")]
public partial struct StdVideoDecodeH265PictureInfo
{
    [NativeName("flags")]
    public StdVideoDecodeH265PictureInfoFlags Flags;

    [NativeName("sps_video_parameter_set_id")]
    public byte SpsVideoParameterSetId;

    [NativeName("pps_seq_parameter_set_id")]
    public byte PpsSeqParameterSetId;

    [NativeName("pps_pic_parameter_set_id")]
    public byte PpsPicParameterSetId;

    [NativeName("NumDeltaPocsOfRefRpsIdx")]
    public byte NumDeltaPocsOfRefRpsIdx;

    [NativeName("PicOrderCntVal")]
    public int PicOrderCntVal;

    [NativeName("NumBitsForSTRefPicSetInSlice")]
    public ushort NumBitsForSTRefPicSetInSlice;

    [NativeName("reserved")]
    public ushort Reserved;

    [NativeName("RefPicSetStCurrBefore")]
    public StdVideoDecodeH265PictureInfoRefPicSetStCurrBefore RefPicSetStCurrBefore;

    [NativeName("RefPicSetStCurrAfter")]
    public StdVideoDecodeH265PictureInfoRefPicSetStCurrAfter RefPicSetStCurrAfter;

    [NativeName("RefPicSetLtCurr")]
    public StdVideoDecodeH265PictureInfoRefPicSetLtCurr RefPicSetLtCurr;
}
