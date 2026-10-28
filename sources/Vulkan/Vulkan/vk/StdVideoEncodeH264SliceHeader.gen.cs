// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264SliceHeader")]
public unsafe partial struct StdVideoEncodeH264SliceHeader
{
    [NativeName("flags")]
    public StdVideoEncodeH264SliceHeaderFlags Flags;

    [NativeName("first_mb_in_slice")]
    public uint FirstMbInSlice;

    [NativeName("slice_type")]
    public StdVideoH264SliceType SliceType;

    [NativeName("slice_alpha_c0_offset_div2")]
    public sbyte SliceAlphaC0OffsetDiv2;

    [NativeName("slice_beta_offset_div2")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeName("slice_qp_delta")]
    public sbyte SliceQpDelta;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("cabac_init_idc")]
    public StdVideoH264CabacInitIdc CabacInitIdc;

    [NativeName("disable_deblocking_filter_idc")]
    public StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc;

    [NativeName("pWeightTable")]
    public StdVideoEncodeH264WeightTable* PWeightTable;
}
