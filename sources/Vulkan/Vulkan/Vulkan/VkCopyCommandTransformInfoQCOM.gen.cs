// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCopyCommandTransformInfoQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_rotated_copy_commands"],
        ImpliesSets = [
            "VK_QCOM_rotated_copy_commands+VK_KHR_copy_commands2",
            "VK_QCOM_rotated_copy_commands+VK_VERSION_1_3",
        ]
    )]
    public VkSurfaceTransformFlagsKHR transform;
}
