// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkExternalMemoryHandleTypeFlagBitsNV")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkExternalMemoryHandleTypeFlagsNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryHandleTypeOpaqueWin32Bit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryHandleTypeOpaqueWin32KmtBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryHandleTypeD3D11ImageBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryHandleTypeD3D11ImageKmtBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_FLAG_BITS_MAX_ENUM_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VkExternalMemoryHandleTypeFlagBitsMaxEnum = 0x7FFFFFFF,
}
