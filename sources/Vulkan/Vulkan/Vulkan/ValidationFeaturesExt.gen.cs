// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkValidationFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ValidationFeaturesExt
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public void* PNext;

    [NativeName("enabledValidationFeatureCount")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public uint EnabledValidationFeatureCount;

    [NativeName("pEnabledValidationFeatures")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public ValidationFeatureEnableExt* PEnabledValidationFeatures;

    [NativeName("disabledValidationFeatureCount")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public uint DisabledValidationFeatureCount;

    [NativeName("pDisabledValidationFeatures")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    public ValidationFeatureDisableExt* PDisabledValidationFeatures;
}
