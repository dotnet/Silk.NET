// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_replicated_composites"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_EXT_shader_replicated_composites"])]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_replicated_composites"])]
    public uint shaderReplicatedComposites;
}
