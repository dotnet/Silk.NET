// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeAV1PictureInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeAV1PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoFlags Flags;

    [NativeName("frame_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FrameType FrameType;

    [NativeName("frame_presentation_time")]
    [SupportedApiProfile("vulkan")]
    public uint FramePresentationTime;

    [NativeName("current_frame_id")]
    [SupportedApiProfile("vulkan")]
    public uint CurrentFrameId;

    [NativeName("order_hint")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeName("primary_ref_frame")]
    [SupportedApiProfile("vulkan")]
    public byte PrimaryRefFrame;

    [NativeName("refresh_frame_flags")]
    [SupportedApiProfile("vulkan")]
    public byte RefreshFrameFlags;

    [NativeName("coded_denom")]
    [SupportedApiProfile("vulkan")]
    public byte CodedDenom;

    [NativeName("render_width_minus_1")]
    [SupportedApiProfile("vulkan")]
    public ushort RenderWidthMinus1;

    [NativeName("render_height_minus_1")]
    [SupportedApiProfile("vulkan")]
    public ushort RenderHeightMinus1;

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

    [NativeName("ref_order_hint")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoRefOrderHint RefOrderHint;

    [NativeName("ref_frame_idx")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoRefFrameIdx RefFrameIdx;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoReserved1 Reserved1;

    [NativeName("delta_frame_id_minus_1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfoDeltaFrameIdMinus1 DeltaFrameIdMinus1;

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

    [NativeName("pExtensionHeader")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;

    [NativeName("pBufferRemovalTimes")]
    [SupportedApiProfile("vulkan")]
    public uint* PBufferRemovalTimes;
}
