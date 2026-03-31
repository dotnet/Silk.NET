// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkValidationFeaturesEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkValidationFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public void* PNext;

    [NativeName("enabledValidationFeatureCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public uint EnabledValidationFeatureCount;

    [NativeName("pEnabledValidationFeatures")]
    [NativeTypeName("const VkValidationFeatureEnableEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public VkValidationFeatureEnableEXT* PEnabledValidationFeatures;

    [NativeName("disabledValidationFeatureCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public uint DisabledValidationFeatureCount;

    [NativeName("pDisabledValidationFeatures")]
    [NativeTypeName("const VkValidationFeatureDisableEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public VkValidationFeatureDisableEXT* PDisabledValidationFeatures;
}
