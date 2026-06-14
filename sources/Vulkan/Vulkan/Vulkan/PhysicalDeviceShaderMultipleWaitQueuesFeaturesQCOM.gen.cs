// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_shader_multiple_wait_queues"],
        ImpliesSets = [
            "VK_QCOM_shader_multiple_wait_queues+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_shader_multiple_wait_queues+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_shader_multiple_wait_queues"],
        ImpliesSets = [
            "VK_QCOM_shader_multiple_wait_queues+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_shader_multiple_wait_queues+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderMultipleWaitQueues")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_shader_multiple_wait_queues"],
        ImpliesSets = [
            "VK_QCOM_shader_multiple_wait_queues+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_shader_multiple_wait_queues+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ShaderMultipleWaitQueues;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_shader_multiple_wait_queues"],
        ImpliesSets = [
            "VK_QCOM_shader_multiple_wait_queues+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_shader_multiple_wait_queues+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM() { }
}
