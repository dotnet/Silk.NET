// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkThrottleHintTypeSEC")]
[SupportedApiProfile("vulkan")]
public enum ThrottleHintTypeSEC : uint
{
    [NativeName("VK_THROTTLE_HINT_TYPE_DEFAULT_SEC")]
    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    Default = 0,

    [NativeName("VK_THROTTLE_HINT_TYPE_LOW_SEC")]
    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    Low = 1,

    [NativeName("VK_THROTTLE_HINT_TYPE_HIGH_SEC")]
    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    High = 2,
}
