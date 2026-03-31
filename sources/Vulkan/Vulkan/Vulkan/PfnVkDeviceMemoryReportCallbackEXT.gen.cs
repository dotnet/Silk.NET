// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkDeviceMemoryReportCallbackEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct PfnVkDeviceMemoryReportCallbackEXT : IDisposable
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    private readonly void* Pointer;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> Handle =>
        (delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void>)Pointer;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public PfnVkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public PfnVkDeviceMemoryReportCallbackEXT(PfnVkDeviceMemoryReportCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public static implicit operator PfnVkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void> pfn
    ) => new(pfn);

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public static implicit operator delegate* unmanaged<
        VkDeviceMemoryReportCallbackDataEXT*,
        void*,
        void>(PfnVkDeviceMemoryReportCallbackEXT pfn) =>
        (delegate* unmanaged<VkDeviceMemoryReportCallbackDataEXT*, void*, void>)pfn.Pointer;
}
