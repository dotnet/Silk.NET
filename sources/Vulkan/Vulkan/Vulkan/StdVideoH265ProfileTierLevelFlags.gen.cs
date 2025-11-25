// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265ProfileTierLevelFlags
{
    [SupportedApiProfile("vulkan")]
    public uint Bitfield;

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint general_tier_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint general_progressive_source_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint general_interlaced_source_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint general_non_packed_constraint_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 3) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
    }

    [NativeTypeName("uint32_t : 1")]
    [SupportedApiProfile("vulkan")]
    public uint general_frame_only_constraint_flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 4) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
    }
}
