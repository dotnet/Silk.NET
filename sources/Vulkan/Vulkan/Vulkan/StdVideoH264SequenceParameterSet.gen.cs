// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH264SequenceParameterSet
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SpsFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264ProfileIdc ProfileIdc;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264LevelIdc LevelIdc;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264ChromaFormatIdc ChromaFormatIdc;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthLumaMinus8;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthChromaMinus8;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxFrameNumMinus4;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264PocType PicOrderCntType;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int OffsetForNonRefPic;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int OffsetForTopToBottomField;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefFramesInPicOrderCntCycle;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxNumRefFrames;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PicWidthInMbsMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PicHeightInMapUnitsMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropLeftOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropRightOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropTopOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameCropBottomOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved2;

    [NativeTypeName("const int32_t *")]
    [SupportedApiProfile("vulkan")]
    public int* POffsetForRefFrame;

    [NativeTypeName("const StdVideoH264ScalingLists *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingLists* PScalingLists;

    [NativeTypeName("const StdVideoH264SequenceParameterSetVui *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SequenceParameterSetVui* PSequenceParameterSetVui;
}
