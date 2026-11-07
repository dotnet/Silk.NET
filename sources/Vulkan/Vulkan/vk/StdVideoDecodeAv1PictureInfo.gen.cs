// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeAV1PictureInfo")]
public unsafe partial struct StdVideoDecodeAv1PictureInfo
{
    [NativeName("flags")]
    public StdVideoDecodeAv1PictureInfoFlags Flags;

    [NativeName("frame_type")]
    public StdVideoAv1FrameType FrameType;

    [NativeName("current_frame_id")]
    public uint CurrentFrameId;

    [NativeName("OrderHint")]
    public byte OrderHint;

    [NativeName("primary_ref_frame")]
    public byte PrimaryRefFrame;

    [NativeName("refresh_frame_flags")]
    public byte RefreshFrameFlags;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("interpolation_filter")]
    public StdVideoAv1InterpolationFilter InterpolationFilter;

    [NativeName("TxMode")]
    public StdVideoAv1TxMode TxMode;

    [NativeName("delta_q_res")]
    public byte DeltaQRes;

    [NativeName("delta_lf_res")]
    public byte DeltaLfRes;

    [NativeName("SkipModeFrame")]
    public StdVideoDecodeAv1PictureInfoSkipModeFrame SkipModeFrame;

    [NativeName("coded_denom")]
    public byte CodedDenom;

    [NativeName("reserved2")]
    public StdVideoDecodeAv1PictureInfoReserved2 Reserved2;

    [NativeName("OrderHints")]
    public StdVideoDecodeAv1PictureInfoOrderHints OrderHints;

    [NativeName("expectedFrameId")]
    public StdVideoDecodeAv1PictureInfoExpectedFrameId ExpectedFrameId;

    [NativeName("pTileInfo")]
    public StdVideoAv1TileInfo* PTileInfo;

    [NativeName("pQuantization")]
    public StdVideoAv1Quantization* PQuantization;

    [NativeName("pSegmentation")]
    public StdVideoAv1Segmentation* PSegmentation;

    [NativeName("pLoopFilter")]
    public StdVideoAv1LoopFilter* PLoopFilter;

    [NativeName("pCDEF")]
    public StdVideoAv1Cdef* PCdef;

    [NativeName("pLoopRestoration")]
    public StdVideoAv1LoopRestoration* PLoopRestoration;

    [NativeName("pGlobalMotion")]
    public StdVideoAv1GlobalMotion* PGlobalMotion;

    [NativeName("pFilmGrain")]
    public StdVideoAv1FilmGrain* PFilmGrain;
}
