// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum PresentScalingFlagsKHR : uint
{
    [SupportedApiProfile("vulkan")]
    OneToOneBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    AspectRatioStretchBitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    StretchBitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    OneToOneBitEXT = OneToOneBitKHR,

    [SupportedApiProfile("vulkan")]
    AspectRatioStretchBitEXT = AspectRatioStretchBitKHR,

    [SupportedApiProfile("vulkan")]
    StretchBitEXT = StretchBitKHR,
}
