// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCuLaunchInfoNVX
{
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* pNext;

    [NativeTypeName("VkCuFunctionNVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkCuFunctionNVX_T* function;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint gridDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint gridDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint gridDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint blockDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint blockDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint blockDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint sharedMemBytes;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint paramCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** pParams;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint extraCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** pExtras;
}
