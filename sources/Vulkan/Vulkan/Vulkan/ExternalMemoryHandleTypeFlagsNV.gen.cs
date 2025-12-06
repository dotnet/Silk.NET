// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalMemoryHandleTypeFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ExternalMemoryHandleTypeFlagsNV : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    OpaqueWin32Bit = 0x1,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    OpaqueWin32KmtBit = 0x2,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    D3D11ImageBit = 0x4,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    D3D11ImageKmtBit = 0x8,
}
