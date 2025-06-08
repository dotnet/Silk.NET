// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPushDescriptorSetWithTemplateInfo
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public void* pNext;

    [NativeTypeName("VkDescriptorUpdateTemplate")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkDescriptorUpdateTemplate_T* descriptorUpdateTemplate;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public VkPipelineLayout_T* layout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public uint set;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    public void* pData;
}
