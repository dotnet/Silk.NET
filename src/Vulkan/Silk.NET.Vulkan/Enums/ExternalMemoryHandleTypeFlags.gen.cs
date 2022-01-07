// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalMemoryHandleTypeFlags")]
    public enum ExternalMemoryHandleTypeFlags : int
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
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT")]
        ExternalMemoryHandleTypeDmaBufBitExt = 512,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID")]
        ExternalMemoryHandleTypeAndroidHardwareBufferBitAndroid = 1024,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT")]
        ExternalMemoryHandleTypeHostAllocationBitExt = 128,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT")]
        ExternalMemoryHandleTypeHostMappedForeignMemoryBitExt = 256,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA")]
        ExternalMemoryHandleTypeZirconVmoBitFuchsia = 2048,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV")]
        ExternalMemoryHandleTypeRdmaAddressBitNV = 4096,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_RESERVED_13_BIT_NV")]
        ExternalMemoryHandleTypeReserved13BitNV = 8192,
    }
}
