// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkThrottleHintSubmitInfoSEC")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ThrottleHintSubmitInfoSEC
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    public StructureType SType = StructureType.ThrottleHintSubmitInfoSEC;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    public void* PNext;

    [NativeName("throttleHint")]
    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    public ThrottleHintTypeSEC ThrottleHint;

    [SupportedApiProfile("vulkan", ["VK_SEC_throttle_hint"])]
    public ThrottleHintSubmitInfoSEC() { }
}
