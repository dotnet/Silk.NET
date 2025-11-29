// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "HUAWEI", 0)]
[NativeName("VkSubpassShadingPipelineCreateInfoHUAWEI")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SubpassShadingPipelineCreateInfoHuawei
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public void* PNext;

    [NativeName("renderPass")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public RenderPass RenderPass;

    [NativeName("subpass")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_subpass_shading"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_create_renderpass2",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public uint Subpass;
}
