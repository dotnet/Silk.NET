// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264WeightTableFlags")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264WeightTableFlags
{
    [NativeName("luma_weight_l0_flag")]
    [SupportedApiProfile("vulkan")]
    public uint LumaWeightL0Flag;

    [NativeName("chroma_weight_l0_flag")]
    [SupportedApiProfile("vulkan")]
    public uint ChromaWeightL0Flag;

    [NativeName("luma_weight_l1_flag")]
    [SupportedApiProfile("vulkan")]
    public uint LumaWeightL1Flag;

    [NativeName("chroma_weight_l1_flag")]
    [SupportedApiProfile("vulkan")]
    public uint ChromaWeightL1Flag;
}
