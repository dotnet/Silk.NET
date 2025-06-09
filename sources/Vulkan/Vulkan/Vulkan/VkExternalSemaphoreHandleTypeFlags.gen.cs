// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkExternalSemaphoreHandleTypeFlags : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_external_semaphore"],
        ImpliesSets = ["VK_KHR_external_semaphore", "VK_KHR_external_semaphore_capabilities"]
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_ZIRCON_EVENT_BIT_FUCHSIA = 0x00000080,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT =
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR =
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR =
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR =
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT_KHR =
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_semaphore_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_semaphore_capabilities+VK_VERSION_1_1",
        ]
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT_KHR =
        VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
