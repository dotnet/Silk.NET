// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264SliceHeader")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH264SliceHeader
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264SliceHeaderFlags Flags;

    [NativeName("first_mb_in_slice")]
    [SupportedApiProfile("vulkan")]
    public uint FirstMbInSlice;

    [NativeName("slice_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SliceType SliceType;

    [NativeName("slice_alpha_c0_offset_div2")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceAlphaC0OffsetDiv2;

    [NativeName("slice_beta_offset_div2")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeName("slice_qp_delta")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceQpDelta;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("cabac_init_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264CabacInitIdc CabacInitIdc;

    [NativeName("disable_deblocking_filter_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc;

    [NativeName("pWeightTable")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTable* PWeightTable;
}
