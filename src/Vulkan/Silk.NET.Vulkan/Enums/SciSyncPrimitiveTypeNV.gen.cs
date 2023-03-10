// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSciSyncPrimitiveTypeNV")]
    public enum SciSyncPrimitiveTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"FenceNV\"")]
        [NativeName("Name", "VK_SCI_SYNC_PRIMITIVE_TYPE_FENCE_NV")]
        SciSyncPrimitiveTypeFenceNV = 0,
        [Obsolete("Deprecated in favour of \"SemaphoreNV\"")]
        [NativeName("Name", "VK_SCI_SYNC_PRIMITIVE_TYPE_SEMAPHORE_NV")]
        SciSyncPrimitiveTypeSemaphoreNV = 1,
        [NativeName("Name", "VK_SCI_SYNC_PRIMITIVE_TYPE_FENCE_NV")]
        FenceNV = 0,
        [NativeName("Name", "VK_SCI_SYNC_PRIMITIVE_TYPE_SEMAPHORE_NV")]
        SemaphoreNV = 1,
    }
}
