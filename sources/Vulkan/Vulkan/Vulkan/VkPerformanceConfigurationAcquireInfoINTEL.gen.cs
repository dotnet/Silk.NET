// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPerformanceConfigurationAcquireInfoINTEL
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public void* pNext;

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public VkPerformanceConfigurationTypeINTEL type;
}
