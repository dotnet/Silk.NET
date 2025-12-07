// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoDecodeAV1PictureInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FrameType FrameType;

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
    public byte Reserved1;

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

    [NativeTypeName("uint8_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoSkipModeFrame SkipModeFrame;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CodedDenom;

    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoReserved2 Reserved2;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoOrderHints OrderHints;

    [NativeTypeName("uint32_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoExpectedFrameId ExpectedFrameId;

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

    [NativeTypeName("const StdVideoAV1FilmGrain *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrain* PFilmGrain;
}
