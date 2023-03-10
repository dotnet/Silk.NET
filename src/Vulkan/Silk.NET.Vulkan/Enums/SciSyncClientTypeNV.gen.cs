// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSciSyncClientTypeNV")]
    public enum SciSyncClientTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"SignalerNV\"")]
        [NativeName("Name", "VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_NV")]
        SciSyncClientTypeSignalerNV = 0,
        [Obsolete("Deprecated in favour of \"WaiterNV\"")]
        [NativeName("Name", "VK_SCI_SYNC_CLIENT_TYPE_WAITER_NV")]
        SciSyncClientTypeWaiterNV = 1,
        [Obsolete("Deprecated in favour of \"SignalerWaiterNV\"")]
        [NativeName("Name", "VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_WAITER_NV")]
        SciSyncClientTypeSignalerWaiterNV = 2,
        [NativeName("Name", "VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_NV")]
        SignalerNV = 0,
        [NativeName("Name", "VK_SCI_SYNC_CLIENT_TYPE_WAITER_NV")]
        WaiterNV = 1,
        [NativeName("Name", "VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_WAITER_NV")]
        SignalerWaiterNV = 2,
    }
}
