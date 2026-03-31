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
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BaseQIdx;

    [NativeName("DeltaQYDc")]
    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQYDc;

    [NativeName("DeltaQUDc")]
    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQUDc;

    [NativeName("DeltaQUAc")]
    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQUAc;

    [NativeName("DeltaQVDc")]
    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQVDc;

    [NativeName("DeltaQVAc")]
    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQVAc;

    [NativeName("qm_y")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte QmY;

    [NativeName("qm_u")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte QmU;

    [NativeName("qm_v")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte QmV;
}
