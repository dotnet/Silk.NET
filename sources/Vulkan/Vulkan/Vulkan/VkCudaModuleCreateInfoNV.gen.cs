// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCudaModuleCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public void* pNext;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public nuint dataSize;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public void* pData;
}
