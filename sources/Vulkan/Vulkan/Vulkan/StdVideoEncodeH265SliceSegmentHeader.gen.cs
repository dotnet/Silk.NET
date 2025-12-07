// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265SliceSegmentHeader")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265SliceSegmentHeaderFlags Flags;

    [NativeName("slice_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SliceType SliceType;

    [NativeName("slice_segment_address")]
    [SupportedApiProfile("vulkan")]
    public uint SliceSegmentAddress;

    [NativeName("collocated_ref_idx")]
    [SupportedApiProfile("vulkan")]
    public byte CollocatedRefIdx;

    [NativeName("MaxNumMergeCand")]
    [SupportedApiProfile("vulkan")]
    public byte MaxNumMergeCand;

    [NativeName("slice_cb_qp_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceCbQpOffset;

    [NativeName("slice_cr_qp_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceCrQpOffset;

    [NativeName("slice_beta_offset_div2")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeName("slice_tc_offset_div2")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceTcOffsetDiv2;

    [NativeName("slice_act_y_qp_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceActYQpOffset;

    [NativeName("slice_act_cb_qp_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceActCbQpOffset;

    [NativeName("slice_act_cr_qp_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceActCrQpOffset;

    [NativeName("slice_qp_delta")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceQpDelta;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved1;

    [NativeName("pWeightTable")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTable* PWeightTable;
}
