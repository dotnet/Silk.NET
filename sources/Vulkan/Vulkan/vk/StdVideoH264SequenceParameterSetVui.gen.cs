// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264SequenceParameterSetVui")]
public unsafe partial struct StdVideoH264SequenceParameterSetVui
{
    [NativeName("flags")]
    public StdVideoH264SpsVuiFlags Flags;

    [NativeName("aspect_ratio_idc")]
    public StdVideoH264AspectRatioIdc AspectRatioIdc;

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

    [NativeName("matrix_coefficients")]
    public byte MatrixCoefficients;

    [NativeName("num_units_in_tick")]
    public uint NumUnitsInTick;

    [NativeName("time_scale")]
    public uint TimeScale;

    [NativeName("max_num_reorder_frames")]
    public byte MaxNumReorderFrames;

    [NativeName("max_dec_frame_buffering")]
    public byte MaxDecFrameBuffering;

    [NativeName("chroma_sample_loc_type_top_field")]
    public byte ChromaSampleLocTypeTopField;

    [NativeName("chroma_sample_loc_type_bottom_field")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeName("reserved1")]
    public uint Reserved1;

    [NativeName("pHrdParameters")]
    public StdVideoH264HrdParameters* PHrdParameters;
}
