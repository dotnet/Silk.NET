// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265WeightTableFlags")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265WeightTableFlags
{
    [NativeName("luma_weight_l0_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort LumaWeightL0Flag;

    [NativeName("chroma_weight_l0_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort ChromaWeightL0Flag;

    [NativeName("luma_weight_l1_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort LumaWeightL1Flag;

    [NativeName("chroma_weight_l1_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort ChromaWeightL1Flag;
}
