// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkIndirectExecutionSetInfoEXT
{
    [FieldOffset(0)]
    [NativeTypeName("const VkIndirectExecutionSetPipelineInfoEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkIndirectExecutionSetPipelineInfoEXT* pPipelineInfo;

    [FieldOffset(0)]
    [NativeTypeName("const VkIndirectExecutionSetShaderInfoEXT *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public VkIndirectExecutionSetShaderInfoEXT* pShaderInfo;
}
