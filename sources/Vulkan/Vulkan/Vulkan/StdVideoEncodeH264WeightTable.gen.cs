// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264WeightTable")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264WeightTable
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableFlags Flags;

    [NativeName("luma_log2_weight_denom")]
    [SupportedApiProfile("vulkan")]
    public byte LumaLog2WeightDenom;

    [NativeName("chroma_log2_weight_denom")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaLog2WeightDenom;

    [NativeName("luma_weight_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableLumaWeightL0 LumaWeightL0;

    [NativeName("luma_offset_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableLumaOffsetL0 LumaOffsetL0;

    [NativeName("chroma_weight_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableChromaWeightL0 ChromaWeightL0;

    [NativeName("chroma_offset_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableChromaOffsetL0 ChromaOffsetL0;

    [NativeName("luma_weight_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableLumaWeightL1 LumaWeightL1;

    [NativeName("luma_offset_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableLumaOffsetL1 LumaOffsetL1;

    [NativeName("chroma_weight_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableChromaWeightL1 ChromaWeightL1;

    [NativeName("chroma_offset_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTableChromaOffsetL1 ChromaOffsetL1;
}
