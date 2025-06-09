// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum PresentModeKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    ImmediateKHR = 0,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    MailboxKHR = 1,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    FifoKHR = 2,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    FifoRelaxedKHR = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    SharedDemandRefreshKHR = 1000111000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    SharedContinuousRefreshKHR = 1000111001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    FifoLatestReadyEXT = 1000361000,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    MaxEnumKHR = 0x7FFFFFFF,
}
