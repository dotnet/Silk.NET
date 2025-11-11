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
[Flags]
public enum DebugUtilsMessageTypeFlagsEXT : uint
{
    None = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    GeneralBitEXT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    ValidationBitEXT = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    PerformanceBitEXT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    DeviceAddressBindingBitEXT = 0x00000008,
}
