// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH264PictureInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264PictureInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PicParameterSetId;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort IdrPicId;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264PictureType PrimaryPicType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameNum;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCnt;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;

    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264PictureInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeH264ReferenceListsInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfo* PRefLists;
}
