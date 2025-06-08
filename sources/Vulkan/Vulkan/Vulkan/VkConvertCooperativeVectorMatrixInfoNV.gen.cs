// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkConvertCooperativeVectorMatrixInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public void* pNext;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint srcSize;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkDeviceOrHostAddressConstKHR srcData;

    [NativeTypeName("size_t *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint* pDstSize;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkDeviceOrHostAddressKHR dstData;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR srcComponentType;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkComponentTypeKHR dstComponentType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint numRows;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint numColumns;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkCooperativeVectorMatrixLayoutNV srcLayout;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint srcStride;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public VkCooperativeVectorMatrixLayoutNV dstLayout;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint dstStride;
}
