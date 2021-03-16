// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkExternalSemaphoreHandleTypeFlags")]
    public enum ExternalSemaphoreHandleTypeFlags : int
    {
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalSemaphoreHandleTypeOpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT")]
        ExternalSemaphoreHandleTypeD3D12FenceBit = 8,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT")]
        ExternalSemaphoreHandleTypeD3D11FenceBit = 8,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT")]
        ExternalSemaphoreHandleTypeSyncFDBit = 16,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_RESERVED_5_BIT_NV")]
        ExternalSemaphoreHandleTypeReserved5BitNV = 32,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_RESERVED_6_BIT_NV")]
        ExternalSemaphoreHandleTypeReserved6BitNV = 64,
    }
}
