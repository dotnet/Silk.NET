// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265WeightTable")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265WeightTable
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableFlags Flags;

    [NativeName("luma_log2_weight_denom")]
    [SupportedApiProfile("vulkan")]
    public byte LumaLog2WeightDenom;

    [NativeName("delta_chroma_log2_weight_denom")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaChromaLog2WeightDenom;

    [NativeName("delta_luma_weight_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableDeltaLumaWeightL0 DeltaLumaWeightL0;

    [NativeName("luma_offset_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableLumaOffsetL0 LumaOffsetL0;

    [NativeName("delta_chroma_weight_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableDeltaChromaWeightL0 DeltaChromaWeightL0;

    [NativeName("delta_chroma_offset_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableDeltaChromaOffsetL0 DeltaChromaOffsetL0;

    [NativeName("delta_luma_weight_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableDeltaLumaWeightL1 DeltaLumaWeightL1;

    [NativeName("luma_offset_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableLumaOffsetL1 LumaOffsetL1;

    [NativeName("delta_chroma_weight_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableDeltaChromaWeightL1 DeltaChromaWeightL1;

    [NativeName("delta_chroma_offset_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTableDeltaChromaOffsetL1 DeltaChromaOffsetL1;
}
