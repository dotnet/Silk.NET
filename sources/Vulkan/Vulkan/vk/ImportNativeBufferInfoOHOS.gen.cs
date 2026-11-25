// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImportNativeBufferInfoOHOS")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportNativeBufferInfoOHOS
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.ImportNativeBufferInfoOHOS;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("buffer")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public OHNativeBufferHandle Buffer;

    [SupportedApiProfile(
        "vulkan",
        ["VK_OHOS_external_memory"],
        ImpliesSets = [
            "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
            "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
        ]
    )]
    public ImportNativeBufferInfoOHOS() { }
}
