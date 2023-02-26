// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalSemaphoreHandleTypeFlags")]
    public enum ExternalSemaphoreHandleTypeFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"OpaqueFDBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalSemaphoreHandleTypeOpaqueFDBit = 1,
        [Obsolete("Deprecated in favour of \"OpaqueWin32Bit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        [Obsolete("Deprecated in favour of \"OpaqueWin32KmtBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        [Obsolete("Deprecated in favour of \"D3D12FenceBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT")]
        ExternalSemaphoreHandleTypeD3D12FenceBit = 8,
        [Obsolete("Deprecated in favour of \"D3D11FenceBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT")]
        ExternalSemaphoreHandleTypeD3D11FenceBit = 8,
        [Obsolete("Deprecated in favour of \"SyncFDBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT")]
        ExternalSemaphoreHandleTypeSyncFDBit = 16,
        [Obsolete("Deprecated in favour of \"ZirconEventBitFuchsia\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_ZIRCON_EVENT_BIT_FUCHSIA")]
        ExternalSemaphoreHandleTypeZirconEventBitFuchsia = 128,
        [Obsolete("Deprecated in favour of \"SciSyncObjBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SCI_SYNC_OBJ_BIT_NV")]
        ExternalSemaphoreHandleTypeSciSyncObjBitNV = 32,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT")]
        OpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        OpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        OpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT")]
        D3D12FenceBit = 8,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT")]
        D3D11FenceBit = 8,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT")]
        SyncFDBit = 16,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_ZIRCON_EVENT_BIT_FUCHSIA")]
        ZirconEventBitFuchsia = 128,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SCI_SYNC_OBJ_BIT_NV")]
        SciSyncObjBitNV = 32,
    }
}
