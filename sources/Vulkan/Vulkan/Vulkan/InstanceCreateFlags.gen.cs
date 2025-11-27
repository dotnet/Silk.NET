// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkInstanceCreateFlagBits")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum InstanceCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_portability_enumeration"])]
    EnumeratePortabilityBitKHR = 0x1,
}
