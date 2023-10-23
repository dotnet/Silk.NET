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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"OpaqueFDBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalMemoryHandleTypeOpaqueFDBit = 1,
        [Obsolete("Deprecated in favour of \"OpaqueWin32Bit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalMemoryHandleTypeOpaqueWin32Bit = 2,
        [Obsolete("Deprecated in favour of \"OpaqueWin32KmtBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalMemoryHandleTypeOpaqueWin32KmtBit = 4,
        [Obsolete("Deprecated in favour of \"D3D11TextureBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT")]
        ExternalMemoryHandleTypeD3D11TextureBit = 8,
        [Obsolete("Deprecated in favour of \"D3D11TextureKmtBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT")]
        ExternalMemoryHandleTypeD3D11TextureKmtBit = 16,
        [Obsolete("Deprecated in favour of \"D3D12HeapBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT")]
        ExternalMemoryHandleTypeD3D12HeapBit = 32,
        [Obsolete("Deprecated in favour of \"D3D12ResourceBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT")]
        ExternalMemoryHandleTypeD3D12ResourceBit = 64,
        [Obsolete("Deprecated in favour of \"DmaBufBitExt\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT")]
        ExternalMemoryHandleTypeDmaBufBitExt = 512,
        [Obsolete("Deprecated in favour of \"AndroidHardwareBufferBitAndroid\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID")]
        ExternalMemoryHandleTypeAndroidHardwareBufferBitAndroid = 1024,
        [Obsolete("Deprecated in favour of \"HostAllocationBitExt\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT")]
        ExternalMemoryHandleTypeHostAllocationBitExt = 128,
        [Obsolete("Deprecated in favour of \"HostMappedForeignMemoryBitExt\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT")]
        ExternalMemoryHandleTypeHostMappedForeignMemoryBitExt = 256,
        [Obsolete("Deprecated in favour of \"ZirconVmoBitFuchsia\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA")]
        ExternalMemoryHandleTypeZirconVmoBitFuchsia = 2048,
        [Obsolete("Deprecated in favour of \"RdmaAddressBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV")]
        ExternalMemoryHandleTypeRdmaAddressBitNV = 4096,
        [Obsolete("Deprecated in favour of \"ScreenBufferBitQnx\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCREEN_BUFFER_BIT_QNX")]
        ExternalMemoryHandleTypeScreenBufferBitQnx = 16384,
        [Obsolete("Deprecated in favour of \"SciBufBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCI_BUF_BIT_NV")]
        ExternalMemoryHandleTypeSciBufBitNV = 8192,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT")]
        OpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        OpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        OpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT")]
        D3D11TextureBit = 8,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT")]
        D3D11TextureKmtBit = 16,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT")]
        D3D12HeapBit = 32,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT")]
        D3D12ResourceBit = 64,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT")]
        DmaBufBitExt = 512,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID")]
        AndroidHardwareBufferBitAndroid = 1024,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT")]
        HostAllocationBitExt = 128,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT")]
        HostMappedForeignMemoryBitExt = 256,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA")]
        ZirconVmoBitFuchsia = 2048,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV")]
        RdmaAddressBitNV = 4096,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCREEN_BUFFER_BIT_QNX")]
        ScreenBufferBitQnx = 16384,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCI_BUF_BIT_NV")]
        SciBufBitNV = 8192,
    }
}
