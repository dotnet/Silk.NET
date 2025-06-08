// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkExternalMemoryHandleTypeFlagsNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
