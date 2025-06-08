// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDevicePipelineRobustnessProperties
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public void* pNext;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessBufferBehavior defaultRobustnessStorageBuffers;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessBufferBehavior defaultRobustnessUniformBuffers;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessBufferBehavior defaultRobustnessVertexInputs;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessImageBehavior defaultRobustnessImages;
}
