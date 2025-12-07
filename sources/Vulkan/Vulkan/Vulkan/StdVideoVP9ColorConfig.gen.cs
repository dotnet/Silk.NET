// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoVP9ColorConfig
{
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9ColorConfigFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepth;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingX;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingY;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [SupportedApiProfile("vulkan")]
    public StdVideoVP9ColorSpace ColorSpace;
}
