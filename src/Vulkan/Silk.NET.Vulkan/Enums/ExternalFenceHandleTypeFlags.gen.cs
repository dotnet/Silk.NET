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
    [NativeName("Name", "VkExternalFenceHandleTypeFlags")]
    public enum ExternalFenceHandleTypeFlags
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
