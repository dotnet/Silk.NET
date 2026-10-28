// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalFenceHandleTypeFlags")]
[Flags]
public enum ExternalFenceHandleTypeFlags : uint
{
    None = 0x0,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT")]
    OpaqueFdBit = 0x1,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
    OpaqueWin32Bit = 0x2,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
    OpaqueWin32KmtBit = 0x4,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT")]
    SyncFdBit = 0x8,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR")]
    OpaqueFdBitKHR = OpaqueFdBit,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR")]
    OpaqueWin32BitKHR = OpaqueWin32Bit,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR")]
    OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,

    [NativeName("VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT_KHR")]
    SyncFdBitKHR = SyncFdBit,
}
