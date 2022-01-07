// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalFenceHandleTypeFlags")]
    public enum ExternalFenceHandleTypeFlags : int
    {
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalFenceHandleTypeOpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalFenceHandleTypeOpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalFenceHandleTypeOpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT")]
        ExternalFenceHandleTypeSyncFDBit = 8,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_RESERVED_4_BIT_NV")]
        ExternalFenceHandleTypeReserved4BitNV = 16,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_RESERVED_5_BIT_NV")]
        ExternalFenceHandleTypeReserved5BitNV = 32,
    }
}
