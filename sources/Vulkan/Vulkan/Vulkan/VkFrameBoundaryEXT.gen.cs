// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkFrameBoundaryEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public void* pNext;

    [NativeTypeName("VkFrameBoundaryFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public uint flags;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public ulong frameID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public uint imageCount;

    [NativeTypeName("const VkImage *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public VkImage_T** pImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public uint bufferCount;

    [NativeTypeName("const VkBuffer *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public VkBuffer_T** pBuffers;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public ulong tagName;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public nuint tagSize;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    public void* pTag;
}
