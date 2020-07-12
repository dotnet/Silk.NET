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
    [NativeName("Name", "VkExternalSemaphoreHandleTypeFlagsKHR")]
    public enum ExternalSemaphoreHandleTypeFlagsKHR
    {
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalSemaphoreHandleTypeOpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT")]
        ExternalSemaphoreHandleTypeD3D12FenceBit = 8,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT")]
        ExternalSemaphoreHandleTypeSyncFDBit = 16,
    }
}
