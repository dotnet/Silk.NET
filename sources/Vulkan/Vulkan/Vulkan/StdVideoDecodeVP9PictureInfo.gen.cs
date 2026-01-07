// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeVP9PictureInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoDecodeVP9PictureInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeVP9PictureInfoFlags Flags;

    [NativeName("profile")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9Profile Profile;

    [NativeName("frame_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9FrameType FrameType;

    [NativeName("frame_context_idx")]
    [SupportedApiProfile("vulkan")]
    public byte FrameContextIdx;

    [NativeName("reset_frame_context")]
    [SupportedApiProfile("vulkan")]
    public byte ResetFrameContext;

    [NativeName("refresh_frame_flags")]
    [SupportedApiProfile("vulkan")]
    public byte RefreshFrameFlags;

    [NativeName("ref_frame_sign_bias_mask")]
    [SupportedApiProfile("vulkan")]
    public byte RefFrameSignBiasMask;

    [NativeName("interpolation_filter")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9InterpolationFilter InterpolationFilter;

    [NativeName("base_q_idx")]
    [SupportedApiProfile("vulkan")]
    public byte BaseQIdx;

    [NativeName("delta_q_y_dc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQYDc;

    [NativeName("delta_q_uv_dc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQUvDc;

    [NativeName("delta_q_uv_ac")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQUvAc;

    [NativeName("tile_cols_log2")]
    [SupportedApiProfile("vulkan")]
    public byte TileColsLog2;

    [NativeName("tile_rows_log2")]
    [SupportedApiProfile("vulkan")]
    public byte TileRowsLog2;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeVP9PictureInfoReserved1 Reserved1;

    [NativeName("pColorConfig")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9ColorConfig* PColorConfig;

    [NativeName("pLoopFilter")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9LoopFilter* PLoopFilter;

    [NativeName("pSegmentation")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9Segmentation* PSegmentation;
}
