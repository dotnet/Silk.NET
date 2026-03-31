// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAmigoProfilingSubmitInfoSEC")]
[NameAffix("Suffix", "KhronosVendor", "SEC")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkAmigoProfilingSubmitInfoSEC
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("firstDrawTimestamp")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    public ulong FirstDrawTimestamp;

    [NativeName("swapBufferTimestamp")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_SEC_amigo_profiling"],
        ImpliesSets = [
            "VK_SEC_amigo_profiling+VK_KHR_get_physical_device_properties2",
            "VK_SEC_amigo_profiling+VK_VERSION_1_1",
        ]
    )]
    public ulong SwapBufferTimestamp;
}
