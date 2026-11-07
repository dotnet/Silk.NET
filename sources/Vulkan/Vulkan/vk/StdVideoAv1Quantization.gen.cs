// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Quantization")]
public partial struct StdVideoAv1Quantization
{
    [NativeName("flags")]
    public StdVideoAv1QuantizationFlags Flags;

    [NativeName("base_q_idx")]
    public byte BaseQIdx;

    [NativeName("DeltaQYDc")]
    public sbyte DeltaQYDc;

    [NativeName("DeltaQUDc")]
    public sbyte DeltaQUDc;

    [NativeName("DeltaQUAc")]
    public sbyte DeltaQUAc;

    [NativeName("DeltaQVDc")]
    public sbyte DeltaQVDc;

    [NativeName("DeltaQVAc")]
    public sbyte DeltaQVAc;

    [NativeName("qm_y")]
    public byte QmY;

    [NativeName("qm_u")]
    public byte QmU;

    [NativeName("qm_v")]
    public byte QmV;
}
