// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ColorConfig")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoVp9ColorConfig
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9ColorConfigFlags Flags;

    [NativeName("BitDepth")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepth;

    [NativeName("subsampling_x")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingX;

    [NativeName("subsampling_y")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingY;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("color_space")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9ColorSpace ColorSpace;
}
