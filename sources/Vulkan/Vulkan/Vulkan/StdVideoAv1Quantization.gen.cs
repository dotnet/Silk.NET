// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Quantization")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1Quantization
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1QuantizationFlags Flags;

    [NativeName("base_q_idx")]
    [SupportedApiProfile("vulkan")]
    public byte BaseQIdx;

    [NativeName("DeltaQYDc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQyDc;

    [NativeName("DeltaQUDc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQuDc;

    [NativeName("DeltaQUAc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQuAc;

    [NativeName("DeltaQVDc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQvDc;

    [NativeName("DeltaQVAc")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQvAc;

    [NativeName("qm_y")]
    [SupportedApiProfile("vulkan")]
    public byte QmY;

    [NativeName("qm_u")]
    [SupportedApiProfile("vulkan")]
    public byte QmU;

    [NativeName("qm_v")]
    [SupportedApiProfile("vulkan")]
    public byte QmV;
}
