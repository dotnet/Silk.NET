// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceVulkan14Properties
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint lineSubPixelPrecisionBits;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint maxVertexAttribDivisor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint supportsNonZeroFirstInstance;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint maxPushDescriptors;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint dynamicRenderingLocalReadDepthStencilAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint dynamicRenderingLocalReadMultisampledAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint earlyFragmentMultisampleCoverageAfterSampleCounting;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint earlyFragmentSampleMaskTestBeforeSampleCounting;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint depthStencilSwizzleOneSupport;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint polygonModePointSize;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint nonStrictSinglePixelWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint nonStrictWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint blockTexelViewCompatibleMultipleLayers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint maxCombinedImageSamplerDescriptorCount;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint fragmentShadingRateClampCombinerInputs;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessBufferBehavior defaultRobustnessStorageBuffers;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessBufferBehavior defaultRobustnessUniformBuffers;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessBufferBehavior defaultRobustnessVertexInputs;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineRobustnessImageBehavior defaultRobustnessImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint copySrcLayoutCount;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkImageLayout* pCopySrcLayouts;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint copyDstLayoutCount;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkImageLayout* pCopyDstLayouts;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPhysicalDeviceVulkan14Properties_optimalTilingLayoutUUID optimalTilingLayoutUUID;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint identicalMemoryTypeRequirements;
}
