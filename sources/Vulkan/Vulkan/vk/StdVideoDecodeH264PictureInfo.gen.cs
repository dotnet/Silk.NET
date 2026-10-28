// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeH264PictureInfo")]
public partial struct StdVideoDecodeH264PictureInfo
{
    [NativeName("flags")]
    public StdVideoDecodeH264PictureInfoFlags Flags;

    [NativeName("seq_parameter_set_id")]
    public byte SeqParameterSetId;

    [NativeName("pic_parameter_set_id")]
    public byte PicParameterSetId;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("reserved2")]
    public byte Reserved2;

    [NativeName("frame_num")]
    public ushort FrameNum;

    [NativeName("idr_pic_id")]
    public ushort IdrPicId;

    [NativeName("PicOrderCnt")]
    public StdVideoDecodeH264PictureInfoPicOrderCnt PicOrderCnt;
}
