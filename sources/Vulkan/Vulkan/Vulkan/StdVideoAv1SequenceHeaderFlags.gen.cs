// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1SequenceHeaderFlags")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1SequenceHeaderFlags
{
    [NativeName("_bitfield")]
    [SupportedApiProfile("vulkan")]
    public uint Bitfield;

    [NativeName("still_picture")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint StillPicture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeName("reduced_still_picture_header")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint ReducedStillPictureHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeName("use_128x128_superblock")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint Use128x128Superblock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
    }

    [NativeName("enable_filter_intra")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableFilterIntra
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 3) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
    }

    [NativeName("enable_intra_edge_filter")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableIntraEdgeFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 4) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
    }

    [NativeName("enable_interintra_compound")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableInterintraCompound
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 5) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5); }
    }

    [NativeName("enable_masked_compound")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableMaskedCompound
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 6) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6); }
    }

    [NativeName("enable_warped_motion")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableWarpedMotion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 7) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7); }
    }

    [NativeName("enable_dual_filter")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableDualFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 8) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
    }

    [NativeName("enable_order_hint")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableOrderHint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9); }
    }

    [NativeName("enable_jnt_comp")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableJntComp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 10) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10); }
    }

    [NativeName("enable_ref_frame_mvs")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableRefFrameMvs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 11) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11); }
    }

    [NativeName("frame_id_numbers_present_flag")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint FrameIdNumbersPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 12) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12); }
    }

    [NativeName("enable_superres")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableSuperres
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 13) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13); }
    }

    [NativeName("enable_cdef")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableCdef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 14) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14); }
    }

    [NativeName("enable_restoration")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint EnableRestoration
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 15) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
    }

    [NativeName("film_grain_params_present")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint FilmGrainParamsPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 16) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16); }
    }

    [NativeName("timing_info_present_flag")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint TimingInfoPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 17) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17); }
    }

    [NativeName("initial_display_delay_present_flag")]
    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint InitialDisplayDelayPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 18) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18); }
    }

    [NativeName("reserved")]
    [NativeTypeName("uint32_t : 13")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 19) & 0x1FFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1FFFu << 19)) | ((value & 0x1FFFu) << 19); }
    }
}
