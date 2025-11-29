// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH265PictureInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265PictureInfoFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH265PictureType PicType;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PpsSeqParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PpsPicParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ShortTermRefPicSetIdx;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int PicOrderCntVal;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TemporalId;

    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265PictureInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeH265ReferenceListsInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfo* PRefLists;

    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeTypeName("const StdVideoEncodeH265LongTermRefPics *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPics* PLongTermRefPics;
}
