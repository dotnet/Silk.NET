// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SequenceParameterSetVui")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265SequenceParameterSetVui
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SpsVuiFlags Flags;

    [NativeName("aspect_ratio_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265AspectRatioIdc AspectRatioIdc;

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

    [NativeName("matrix_coeffs")]
    [SupportedApiProfile("vulkan")]
    public byte MatrixCoeffs;

    [NativeName("chroma_sample_loc_type_top_field")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeTopField;

    [NativeName("chroma_sample_loc_type_bottom_field")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("reserved2")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeName("def_disp_win_left_offset")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinLeftOffset;

    [NativeName("def_disp_win_right_offset")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinRightOffset;

    [NativeName("def_disp_win_top_offset")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinTopOffset;

    [NativeName("def_disp_win_bottom_offset")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinBottomOffset;

    [NativeName("vui_num_units_in_tick")]
    [SupportedApiProfile("vulkan")]
    public uint VuiNumUnitsInTick;

    [NativeName("vui_time_scale")]
    [SupportedApiProfile("vulkan")]
    public uint VuiTimeScale;

    [NativeName("vui_num_ticks_poc_diff_one_minus1")]
    [SupportedApiProfile("vulkan")]
    public uint VuiNumTicksPocDiffOneMinus1;

    [NativeName("min_spatial_segmentation_idc")]
    [SupportedApiProfile("vulkan")]
    public ushort MinSpatialSegmentationIdc;

    [NativeName("reserved3")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved3;

    [NativeName("max_bytes_per_pic_denom")]
    [SupportedApiProfile("vulkan")]
    public byte MaxBytesPerPicDenom;

    [NativeName("max_bits_per_min_cu_denom")]
    [SupportedApiProfile("vulkan")]
    public byte MaxBitsPerMinCuDenom;

    [NativeName("log2_max_mv_length_horizontal")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxMvLengthHorizontal;

    [NativeName("log2_max_mv_length_vertical")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxMvLengthVertical;

    [NativeName("pHrdParameters")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParameters* PHrdParameters;
}
