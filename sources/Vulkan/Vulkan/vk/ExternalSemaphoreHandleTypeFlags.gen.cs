// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalSemaphoreHandleTypeFlags")]
[Flags]
public enum ExternalSemaphoreHandleTypeFlags : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT")]
    OpaqueFdBit = 0x1,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
    OpaqueWin32Bit = 0x2,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
    OpaqueWin32KmtBit = 0x4,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT")]
    D3D12FenceBit = 0x8,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT")]
    SyncFdBit = 0x10,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_ZIRCON_EVENT_BIT_FUCHSIA")]
    ZirconEventBitFUCHSIA = 0x80,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D11_FENCE_BIT")]
    D3D11FenceBit = D3D12FenceBit,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR")]
    OpaqueFdBitKHR = OpaqueFdBit,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR")]
    OpaqueWin32BitKHR = OpaqueWin32Bit,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR")]
    OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT_KHR")]
    D3D12FenceBitKHR = D3D12FenceBit,

    [NativeName("VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT_KHR")]
    SyncFdBitKHR = SyncFdBit,
}
