// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264ReferenceInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceInfoFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264PictureType PrimaryPicType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameNum;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCnt;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermPicNum;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermFrameIdx;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;
}
