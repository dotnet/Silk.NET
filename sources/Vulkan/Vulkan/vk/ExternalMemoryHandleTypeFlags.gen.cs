// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalMemoryHandleTypeFlags")]
[Flags]
public enum ExternalMemoryHandleTypeFlags : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT")]
    OpaqueFdBit = 0x1,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
    OpaqueWin32Bit = 0x2,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
    OpaqueWin32KmtBit = 0x4,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT")]
    D3D11TextureBit = 0x8,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT")]
    D3D11TextureKmtBit = 0x10,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT")]
    D3D12HeapBit = 0x20,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT")]
    D3D12ResourceBit = 0x40,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT")]
    DmaBufBitEXT = 0x200,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID")]
    AndroidHardwareBufferBitANDROID = 0x400,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT")]
    HostAllocationBitEXT = 0x80,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT")]
    HostMappedForeignMemoryBitEXT = 0x100,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA")]
    ZirconVmoBitFUCHSIA = 0x800,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV")]
    RdmaAddressBitNV = 0x1000,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OH_NATIVE_BUFFER_BIT_OHOS")]
    OhNativeBufferBitOHOS = 0x8000,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCREEN_BUFFER_BIT_QNX")]
    ScreenBufferBitQNX = 0x4000,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_MTLBUFFER_BIT_EXT")]
    MtlbufferBitEXT = 0x10000,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_MTLTEXTURE_BIT_EXT")]
    MtltextureBitEXT = 0x20000,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_MTLHEAP_BIT_EXT")]
    MtlheapBitEXT = 0x40000,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT_KHR")]
    OpaqueFdBitKHR = OpaqueFdBit,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR")]
    OpaqueWin32BitKHR = OpaqueWin32Bit,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR")]
    OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT_KHR")]
    D3D11TextureBitKHR = D3D11TextureBit,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT_KHR")]
    D3D11TextureKmtBitKHR = D3D11TextureKmtBit,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT_KHR")]
    D3D12HeapBitKHR = D3D12HeapBit,

    [NativeName("VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT_KHR")]
    D3D12ResourceBitKHR = D3D12ResourceBit,
}
