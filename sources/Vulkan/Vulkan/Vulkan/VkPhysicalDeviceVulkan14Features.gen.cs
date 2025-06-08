// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceVulkan14Features
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint globalPriorityQuery;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_rotate", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    public uint shaderSubgroupRotate;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint shaderSubgroupRotateClustered;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint shaderFloatControls2;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint shaderExpectAssume;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint rectangularLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint bresenhamLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint smoothLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint stippledRectangularLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint stippledBresenhamLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint stippledSmoothLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint vertexAttributeInstanceRateDivisor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint vertexAttributeInstanceRateZeroDivisor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint indexTypeUint8;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint dynamicRenderingLocalRead;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint maintenance5;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint maintenance6;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint pipelineProtectedAccess;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint pipelineRobustness;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_host_image_copy"],
        ImpliesSets = [
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_copy_commands2+VK_KHR_format_feature_flags2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    public uint hostImageCopy;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint pushDescriptor;
}
