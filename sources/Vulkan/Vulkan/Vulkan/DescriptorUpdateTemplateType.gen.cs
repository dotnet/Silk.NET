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
public enum DescriptorUpdateTemplateType : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    DescriptorSet = 0,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    PushDescriptors = 1,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_push_descriptor+VK_KHR_descriptor_update_template",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ],
        ImpliesSets = [
            "VK_KHR_push_descriptor+VK_KHR_get_physical_device_properties2",
            "VK_KHR_push_descriptor+VK_VERSION_1_1",
        ]
    )]
    PushDescriptorsKHR = PushDescriptors,

    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    DescriptorSetKHR = DescriptorSet,
}
