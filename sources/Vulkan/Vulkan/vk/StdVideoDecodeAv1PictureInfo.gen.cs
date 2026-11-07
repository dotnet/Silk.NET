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
    public StdVideoAv1InterpolationFilter InterpolationFilter;

    [NativeName("TxMode")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TxMode TxMode;

    [NativeName("delta_q_res")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaQRes;

    [NativeName("delta_lf_res")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaLfRes;

    [NativeName("SkipModeFrame")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoSkipModeFrame SkipModeFrame;

    [NativeName("coded_denom")]
    [SupportedApiProfile("vulkan")]
    public byte CodedDenom;

    [NativeName("reserved2")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoReserved2 Reserved2;

    [NativeName("OrderHints")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoOrderHints OrderHints;

    [NativeName("expectedFrameId")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAv1PictureInfoExpectedFrameId ExpectedFrameId;

    [NativeName("pTileInfo")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TileInfo* PTileInfo;

    [NativeName("pQuantization")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Quantization* PQuantization;

    [NativeName("pSegmentation")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Segmentation* PSegmentation;

    [NativeName("pLoopFilter")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopFilter* PLoopFilter;

    [NativeName("pCDEF")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Cdef* PCdef;

    [NativeName("pLoopRestoration")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopRestoration* PLoopRestoration;

    [NativeName("pGlobalMotion")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1GlobalMotion* PGlobalMotion;

    [NativeName("pFilmGrain")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FilmGrain* PFilmGrain;
}
