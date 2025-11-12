// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeAV1PictureInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FrameType FrameType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FramePresentationTime;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CurrentFrameId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PrimaryRefFrame;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte RefreshFrameFlags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CodedDenom;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort RenderWidthMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort RenderHeightMinus1;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1InterpolationFilter InterpolationFilter;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TxMode TxMode;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaQRes;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaLfRes;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoRefOrderHint RefOrderHint;

    [NativeTypeName("int8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoRefFrameIdx RefFrameIdx;

    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoReserved1 Reserved1;

    [NativeTypeName("uint32_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoDeltaFrameIdMinus1 DeltaFrameIdMinus1;

    [NativeTypeName("const StdVideoAV1TileInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TileInfo* PTileInfo;

    [NativeTypeName("const StdVideoAV1Quantization *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1Quantization* PQuantization;

    [NativeTypeName("const StdVideoAV1Segmentation *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1Segmentation* PSegmentation;

    [NativeTypeName("const StdVideoAV1LoopFilter *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopFilter* PLoopFilter;

    [NativeTypeName("const StdVideoAV1CDEF *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEF* Pcdef;

    [NativeTypeName("const StdVideoAV1LoopRestoration *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopRestoration* PLoopRestoration;

    [NativeTypeName("const StdVideoAV1GlobalMotion *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1GlobalMotion* PGlobalMotion;

    [NativeTypeName("const StdVideoEncodeAV1ExtensionHeader *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PBufferRemovalTimes;
}
