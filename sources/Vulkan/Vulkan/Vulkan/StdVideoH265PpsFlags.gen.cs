// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265PpsFlags
{
    [SupportedApiProfile("vulkan")]
    public uint Bitfield;

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint dependent_slice_segments_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint output_flag_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint sign_data_hiding_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint cabac_init_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 3) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint constrained_intra_pred_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 4) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint transform_skip_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 5) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint cu_qp_delta_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 6) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_slice_chroma_qp_offsets_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 7) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint weighted_pred_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 8) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint weighted_bipred_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint transquant_bypass_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 10) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint tiles_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 11) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint entropy_coding_sync_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 12) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint uniform_spacing_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 13) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint loop_filter_across_tiles_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 14) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_loop_filter_across_slices_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 15) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint deblocking_filter_control_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 16) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint deblocking_filter_override_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 17) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_deblocking_filter_disabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 18) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_scaling_list_data_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 19) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint lists_modification_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 20) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint slice_segment_header_extension_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 21) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_extension_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 22) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint cross_component_prediction_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 23) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint chroma_qp_offset_list_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 24) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 24)) | ((value & 0x1u) << 24); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_curr_pic_ref_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 25) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 25)) | ((value & 0x1u) << 25); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint residual_adaptive_colour_transform_enabled_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 26) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 26)) | ((value & 0x1u) << 26); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_slice_act_qp_offsets_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 27) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 27)) | ((value & 0x1u) << 27); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_palette_predictor_initializers_present_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 28) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint monochrome_palette_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 29) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 29)) | ((value & 0x1u) << 29); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint pps_range_extension_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 30) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 30)) | ((value & 0x1u) << 30); }
    }
}
