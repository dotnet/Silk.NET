// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264SequenceParameterSetVui")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH264SequenceParameterSetVui
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SpsVuiFlags Flags;

    [NativeName("aspect_ratio_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264AspectRatioIdc AspectRatioIdc;

    [NativeName("sar_width")]
    [SupportedApiProfile("vulkan")]
    public ushort SarWidth;

    [NativeName("sar_height")]
    [SupportedApiProfile("vulkan")]
    public ushort SarHeight;

    [NativeName("video_format")]
    [SupportedApiProfile("vulkan")]
    public byte VideoFormat;

    [NativeName("colour_primaries")]
    [SupportedApiProfile("vulkan")]
    public byte ColourPrimaries;

    [NativeName("transfer_characteristics")]
    [SupportedApiProfile("vulkan")]
    public byte TransferCharacteristics;

    [NativeName("matrix_coefficients")]
    [SupportedApiProfile("vulkan")]
    public byte MatrixCoefficients;

    [NativeName("num_units_in_tick")]
    [SupportedApiProfile("vulkan")]
    public uint NumUnitsInTick;

    [NativeName("time_scale")]
    [SupportedApiProfile("vulkan")]
    public uint TimeScale;

    [NativeName("max_num_reorder_frames")]
    [SupportedApiProfile("vulkan")]
    public byte MaxNumReorderFrames;

    [NativeName("max_dec_frame_buffering")]
    [SupportedApiProfile("vulkan")]
    public byte MaxDecFrameBuffering;

    [NativeName("chroma_sample_loc_type_top_field")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeTopField;

    [NativeName("chroma_sample_loc_type_bottom_field")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved1;

    [NativeName("pHrdParameters")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264HrdParameters* PHrdParameters;
}
