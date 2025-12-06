// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264ReferenceInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264ReferenceInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceInfoFlags Flags;

    [NativeName("primary_pic_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264PictureType PrimaryPicType;

    [NativeName("FrameNum")]
    [SupportedApiProfile("vulkan")]
    public uint FrameNum;

    [NativeName("PicOrderCnt")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCnt;

    [NativeName("long_term_pic_num")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermPicNum;

    [NativeName("long_term_frame_idx")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermFrameIdx;

    [NativeName("temporal_id")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;
}
