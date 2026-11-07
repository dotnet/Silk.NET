// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeAV1PictureInfo")]
public unsafe partial struct StdVideoEncodeAv1PictureInfo
{
    [NativeName("flags")]
    public StdVideoEncodeAv1PictureInfoFlags Flags;

    [NativeName("frame_type")]
    public StdVideoAv1FrameType FrameType;

    [NativeName("frame_presentation_time")]
    public uint FramePresentationTime;

    [NativeName("current_frame_id")]
    public uint CurrentFrameId;

    [NativeName("order_hint")]
    public byte OrderHint;

    [NativeName("primary_ref_frame")]
    public byte PrimaryRefFrame;

    [NativeName("refresh_frame_flags")]
    public byte RefreshFrameFlags;

    [NativeName("coded_denom")]
    public byte CodedDenom;

    [NativeName("render_width_minus_1")]
    public ushort RenderWidthMinus1;

    [NativeName("render_height_minus_1")]
    public ushort RenderHeightMinus1;

    [NativeName("interpolation_filter")]
    public StdVideoAv1InterpolationFilter InterpolationFilter;

    [NativeName("TxMode")]
    public StdVideoAv1TxMode TxMode;

    [NativeName("delta_q_res")]
    public byte DeltaQRes;

    [NativeName("delta_lf_res")]
    public byte DeltaLfRes;

    [NativeName("ref_order_hint")]
    public StdVideoEncodeAv1PictureInfoRefOrderHint RefOrderHint;

    [NativeName("ref_frame_idx")]
    public StdVideoEncodeAv1PictureInfoRefFrameIdx RefFrameIdx;

    [NativeName("reserved1")]
    public StdVideoEncodeAv1PictureInfoReserved1 Reserved1;

    [NativeName("delta_frame_id_minus_1")]
    public StdVideoEncodeAv1PictureInfoDeltaFrameIdMinus1 DeltaFrameIdMinus1;

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

    [NativeName("pExtensionHeader")]
    public StdVideoEncodeAv1ExtensionHeader* PExtensionHeader;

    [NativeName("pBufferRemovalTimes")]
    public uint* PBufferRemovalTimes;
}
