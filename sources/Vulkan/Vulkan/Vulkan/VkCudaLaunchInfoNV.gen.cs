// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCudaLaunchInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public void* pNext;

    [NativeTypeName("VkCudaFunctionNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public VkCudaFunctionNV_T* function;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint gridDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint gridDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint gridDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint blockDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint blockDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint blockDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public uint sharedMemBytes;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public nuint paramCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public void** pParams;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public nuint extraCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public void** pExtras;
}
