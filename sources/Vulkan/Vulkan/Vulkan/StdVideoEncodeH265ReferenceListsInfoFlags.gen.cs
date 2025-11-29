// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265ReferenceListsInfoFlags")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265ReferenceListsInfoFlags
{
    [NativeName("_bitfield")]
    [SupportedApiProfile("vulkan")]
    public uint Bitfield;

    [NativeName("ref_pic_list_modification_flag_l0")]
    [SupportedApiProfile("vulkan")]
    public uint FPicListModificationFlagL0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeName("ref_pic_list_modification_flag_l1")]
    [SupportedApiProfile("vulkan")]
    public uint FPicListModificationFlagL1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeName("reserved")]
    [SupportedApiProfile("vulkan")]
    public uint Served
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x3FFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2); }
    }
}
