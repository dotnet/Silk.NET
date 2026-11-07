// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeVP9PictureInfo")]
public unsafe partial struct StdVideoDecodeVp9PictureInfo
{
    [NativeName("flags")]
    public StdVideoDecodeVp9PictureInfoFlags Flags;

    [NativeName("profile")]
    public StdVideoVp9Profile Profile;

    [NativeName("frame_type")]
    public StdVideoVp9FrameType FrameType;

    [NativeName("frame_context_idx")]
    public byte FrameContextIdx;

    [NativeName("reset_frame_context")]
    public byte ResetFrameContext;

    [NativeName("refresh_frame_flags")]
    public byte RefreshFrameFlags;

    [NativeName("ref_frame_sign_bias_mask")]
    public byte RefFrameSignBiasMask;

    [NativeName("interpolation_filter")]
    public StdVideoVp9InterpolationFilter InterpolationFilter;

    [NativeName("base_q_idx")]
    public byte BaseQIdx;

    [NativeName("delta_q_y_dc")]
    public sbyte DeltaQYDc;

    [NativeName("delta_q_uv_dc")]
    public sbyte DeltaQUvDc;

    [NativeName("delta_q_uv_ac")]
    public sbyte DeltaQUvAc;

    [NativeName("tile_cols_log2")]
    public byte TileColsLog2;

    [NativeName("tile_rows_log2")]
    public byte TileRowsLog2;

    [NativeName("reserved1")]
    public StdVideoDecodeVp9PictureInfoReserved1 Reserved1;

    [NativeName("pColorConfig")]
    public StdVideoVp9ColorConfig* PColorConfig;

    [NativeName("pLoopFilter")]
    public StdVideoVp9LoopFilter* PLoopFilter;

    [NativeName("pSegmentation")]
    public StdVideoVp9Segmentation* PSegmentation;
}
