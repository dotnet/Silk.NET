// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalMemoryHandleTypeFlagsKHR")]
    public enum ExternalMemoryHandleTypeFlagsKHR : int
    {
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalMemoryHandleTypeOpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalMemoryHandleTypeOpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalMemoryHandleTypeOpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT")]
        ExternalMemoryHandleTypeD3D11TextureBit = 8,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT")]
        ExternalMemoryHandleTypeD3D11TextureKmtBit = 16,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT")]
        ExternalMemoryHandleTypeD3D12HeapBit = 32,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT")]
        ExternalMemoryHandleTypeD3D12ResourceBit = 64,
    }
}
