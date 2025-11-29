// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265HrdFlags")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265HrdFlags
{
    [NativeName("_bitfield")]
    [SupportedApiProfile("vulkan")]
    public uint Bitfield;

    [NativeName("nal_hrd_parameters_present_flag")]
    [SupportedApiProfile("vulkan")]
    public uint NalHrdParametersPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeName("vcl_hrd_parameters_present_flag")]
    [SupportedApiProfile("vulkan")]
    public uint VclHrdParametersPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeName("sub_pic_hrd_params_present_flag")]
    [SupportedApiProfile("vulkan")]
    public uint SubPicHrdParamsPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
    }

    [NativeName("sub_pic_cpb_params_in_pic_timing_sei_flag")]
    [SupportedApiProfile("vulkan")]
    public uint SubPicCpbParamsInPicTimingSeiFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 3) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
    }

    [NativeName("fixed_pic_rate_general_flag")]
    [SupportedApiProfile("vulkan")]
    public uint FixedPicRateGeneralFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 4) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFFu << 4)) | ((value & 0xFFu) << 4); }
    }

    [NativeName("fixed_pic_rate_within_cvs_flag")]
    [SupportedApiProfile("vulkan")]
    public uint FixedPicRateWithinCvsFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 12) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFFu << 12)) | ((value & 0xFFu) << 12); }
    }

    [NativeName("low_delay_hrd_flag")]
    [SupportedApiProfile("vulkan")]
    public uint LowDelayHrdFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 20) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFFu << 20)) | ((value & 0xFFu) << 20); }
    }
}
