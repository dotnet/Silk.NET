// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SequenceParameterSetVui")]
public unsafe partial struct StdVideoH265SequenceParameterSetVui
{
    [NativeName("flags")]
    public StdVideoH265SpsVuiFlags Flags;

    [NativeName("aspect_ratio_idc")]
    public StdVideoH265AspectRatioIdc AspectRatioIdc;

    [NativeName("sar_width")]
    public ushort SarWidth;

    [NativeName("sar_height")]
    public ushort SarHeight;

    [NativeName("video_format")]
    public byte VideoFormat;

    [NativeName("colour_primaries")]
    public byte ColourPrimaries;

    [NativeName("transfer_characteristics")]
    public byte TransferCharacteristics;

    [NativeName("matrix_coeffs")]
    public byte MatrixCoeffs;

    [NativeName("chroma_sample_loc_type_top_field")]
    public byte ChromaSampleLocTypeTopField;

    [NativeName("chroma_sample_loc_type_bottom_field")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("reserved2")]
    public byte Reserved2;

    [NativeName("def_disp_win_left_offset")]
    public ushort DefDispWinLeftOffset;

    [NativeName("def_disp_win_right_offset")]
    public ushort DefDispWinRightOffset;

    [NativeName("def_disp_win_top_offset")]
    public ushort DefDispWinTopOffset;

    [NativeName("def_disp_win_bottom_offset")]
    public ushort DefDispWinBottomOffset;

    [NativeName("vui_num_units_in_tick")]
    public uint VuiNumUnitsInTick;

    [NativeName("vui_time_scale")]
    public uint VuiTimeScale;

    [NativeName("vui_num_ticks_poc_diff_one_minus1")]
    public uint VuiNumTicksPocDiffOneMinus1;

    [NativeName("min_spatial_segmentation_idc")]
    public ushort MinSpatialSegmentationIdc;

    [NativeName("reserved3")]
    public ushort Reserved3;

    [NativeName("max_bytes_per_pic_denom")]
    public byte MaxBytesPerPicDenom;

    [NativeName("max_bits_per_min_cu_denom")]
    public byte MaxBitsPerMinCuDenom;

    [NativeName("log2_max_mv_length_horizontal")]
    public byte Log2MaxMvLengthHorizontal;

    [NativeName("log2_max_mv_length_vertical")]
    public byte Log2MaxMvLengthVertical;

    [NativeName("pHrdParameters")]
    public StdVideoH265HrdParameters* PHrdParameters;
}
