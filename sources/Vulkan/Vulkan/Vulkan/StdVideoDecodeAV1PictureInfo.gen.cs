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
public unsafe partial struct StdVideoDecodeAV1PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoFlags Flags;

    [NativeName("frame_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FrameType FrameType;

    [NativeName("current_frame_id")]
    [SupportedApiProfile("vulkan")]
    public uint CurrentFrameId;

    [NativeName("OrderHint")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeName("primary_ref_frame")]
    [SupportedApiProfile("vulkan")]
    public byte PrimaryRefFrame;

    [NativeName("refresh_frame_flags")]
    [SupportedApiProfile("vulkan")]
    public byte RefreshFrameFlags;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("interpolation_filter")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1InterpolationFilter InterpolationFilter;

    [NativeName("TxMode")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TxMode TxMode;

    [NativeName("delta_q_res")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaQRes;

    [NativeName("delta_lf_res")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaLfRes;

    [NativeName("SkipModeFrame")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoSkipModeFrame SkipModeFrame;

    [NativeName("coded_denom")]
    [SupportedApiProfile("vulkan")]
    public byte CodedDenom;

    [NativeName("reserved2")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoReserved2 Reserved2;

    [NativeName("OrderHints")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoOrderHints OrderHints;

    [NativeName("expectedFrameId")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfoExpectedFrameId ExpectedFrameId;

    [NativeName("pTileInfo")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TileInfo* PTileInfo;

    [NativeName("pQuantization")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1Quantization* PQuantization;

    [NativeName("pSegmentation")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1Segmentation* PSegmentation;

    [NativeName("pLoopFilter")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopFilter* PLoopFilter;

    [NativeName("pCDEF")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEF* Pcdef;

    [NativeName("pLoopRestoration")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopRestoration* PLoopRestoration;

    [NativeName("pGlobalMotion")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1GlobalMotion* PGlobalMotion;

    [NativeName("pFilmGrain")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FilmGrain* PFilmGrain;
}
