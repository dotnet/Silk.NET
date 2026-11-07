// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsMessageTypeFlagsEXT")]
[Flags]
public enum DebugUtilsMessageTypeFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
    GeneralBit = 0x1,

    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
    ValidationBit = 0x2,

    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
    PerformanceBit = 0x4,

    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT")]
    DeviceAddressBindingBit = 0x8,
}
