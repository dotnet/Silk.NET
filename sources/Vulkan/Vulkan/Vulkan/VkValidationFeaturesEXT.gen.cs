// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkValidationFeaturesEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public uint enabledValidationFeatureCount;

    [NativeTypeName("const VkValidationFeatureEnableEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public uint disabledValidationFeatureCount;

    [NativeTypeName("const VkValidationFeatureDisableEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
}
