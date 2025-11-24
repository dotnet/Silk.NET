// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1TransferCharacteristics
{
    [SupportedApiProfile("vulkan")]
    Reserved0 = 0,

    [SupportedApiProfile("vulkan")]
    Bt709 = 1,

    [SupportedApiProfile("vulkan")]
    Unspecified = 2,

    [SupportedApiProfile("vulkan")]
    Reserved3 = 3,

    [SupportedApiProfile("vulkan")]
    Bt470M = 4,

    [SupportedApiProfile("vulkan")]
    Bt470BG = 5,

    [SupportedApiProfile("vulkan")]
    Bt601 = 6,

    [SupportedApiProfile("vulkan")]
    Smpte240 = 7,

    [SupportedApiProfile("vulkan")]
    Linear = 8,

    [SupportedApiProfile("vulkan")]
    Log100 = 9,

    [SupportedApiProfile("vulkan")]
    Log100Sqrt10 = 10,

    [SupportedApiProfile("vulkan")]
    Iec61966 = 11,

    [SupportedApiProfile("vulkan")]
    Bt1361 = 12,

    [SupportedApiProfile("vulkan")]
    Srgb = 13,

    [SupportedApiProfile("vulkan")]
    Bt2020X10Bit = 14,

    [SupportedApiProfile("vulkan")]
    Bt2020X12Bit = 15,

    [SupportedApiProfile("vulkan")]
    Smpte2084 = 16,

    [SupportedApiProfile("vulkan")]
    Smpte428 = 17,

    [SupportedApiProfile("vulkan")]
    Hlg = 18,
}
