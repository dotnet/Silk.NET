// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalFenceHandleTypeFlagsKHR")]
    public enum ExternalFenceHandleTypeFlagsKHR : int
    {
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT")]
        ExternalFenceHandleTypeOpaqueFDBit = 1,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT")]
        ExternalFenceHandleTypeOpaqueWin32Bit = 2,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT")]
        ExternalFenceHandleTypeOpaqueWin32KmtBit = 4,
        [NativeName("Name", "VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT")]
        ExternalFenceHandleTypeSyncFDBit = 8,
    }
}
