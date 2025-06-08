// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkExternalImageFormatPropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public VkImageFormatProperties imageFormatProperties;

    [NativeTypeName("VkExternalMemoryFeatureFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public uint externalMemoryFeatures;

    [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public uint exportFromImportedHandleTypes;

    [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    public uint compatibleHandleTypes;
}
