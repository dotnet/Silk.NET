// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVP9ColorSpace : uint
{
    [SupportedApiProfile("vulkan")]
    Unknown = 0,

    [SupportedApiProfile("vulkan")]
    Bt601 = 1,

    [SupportedApiProfile("vulkan")]
    Bt709 = 2,

    [SupportedApiProfile("vulkan")]
    Smpte170 = 3,

    [SupportedApiProfile("vulkan")]
    Smpte240 = 4,

    [SupportedApiProfile("vulkan")]
    Bt2020 = 5,

    [SupportedApiProfile("vulkan")]
    Reserved = 6,

    [SupportedApiProfile("vulkan")]
    Rgb = 7,
}
