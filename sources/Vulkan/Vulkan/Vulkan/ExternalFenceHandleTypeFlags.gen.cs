// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalFenceHandleTypeFlags")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ExternalFenceHandleTypeFlags : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    OpaqueFdBit = 0x1,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    OpaqueWin32Bit = 0x2,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    OpaqueWin32KmtBit = 0x4,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    SyncFdBit = 0x8,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    OpaqueFdBitKHR = OpaqueFdBit,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    OpaqueWin32BitKHR = OpaqueWin32Bit,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_fence_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_fence_capabilities+VK_VERSION_1_1",
        ]
    )]
    SyncFdBitKHR = SyncFdBit,
}
