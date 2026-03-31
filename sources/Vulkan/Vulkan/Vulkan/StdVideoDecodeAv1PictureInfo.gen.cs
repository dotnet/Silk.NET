// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeAV1PictureInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoDecodeAv1PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoFlags Flags;

    [NativeName("frame_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FrameType FrameType;

    [NativeName("current_frame_id")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CurrentFrameId;

    [NativeName("OrderHint")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeName("primary_ref_frame")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PrimaryRefFrame;

    [NativeName("refresh_frame_flags")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte RefreshFrameFlags;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("interpolation_filter")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1InterpolationFilter InterpolationFilter;

    [NativeName("TxMode")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TxMode TxMode;

    [NativeName("delta_q_res")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaQRes;

    [NativeName("delta_lf_res")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaLfRes;

    [NativeName("SkipModeFrame")]
    [NativeTypeName("uint8_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoSkipModeFrame SkipModeFrame;

    [NativeName("coded_denom")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CodedDenom;

    [NativeName("reserved2")]
    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoReserved2 Reserved2;

    [NativeName("OrderHints")]
    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoOrderHints OrderHints;

    [NativeName("expectedFrameId")]
    [NativeTypeName("uint32_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoExpectedFrameId ExpectedFrameId;

    [NativeName("pTileInfo")]
    [NativeTypeName("const StdVideoAV1TileInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TileInfo* PTileInfo;

    [NativeName("pQuantization")]
    [NativeTypeName("const StdVideoAV1Quantization *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Quantization* PQuantization;

    [NativeName("pSegmentation")]
    [NativeTypeName("const StdVideoAV1Segmentation *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Segmentation* PSegmentation;

    [NativeName("pLoopFilter")]
    [NativeTypeName("const StdVideoAV1LoopFilter *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopFilter* PLoopFilter;

    [NativeName("pCDEF")]
    [NativeTypeName("const StdVideoAV1CDEF *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Cdef* PCdef;

    [NativeName("pLoopRestoration")]
    [NativeTypeName("const StdVideoAV1LoopRestoration *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopRestoration* PLoopRestoration;

    [NativeName("pGlobalMotion")]
    [NativeTypeName("const StdVideoAV1GlobalMotion *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1GlobalMotion* PGlobalMotion;

    [NativeName("pFilmGrain")]
    [NativeTypeName("const StdVideoAV1FilmGrain *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrain* PFilmGrain;
}
