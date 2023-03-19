// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCacheCreateFlags")]
    public enum PipelineCacheCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ExternallySynchronizedBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT")]
        PipelineCacheCreateExternallySynchronizedBitExt = 1,
        [Obsolete("Deprecated in favour of \"ExternallySynchronizedBit\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT")]
        PipelineCacheCreateExternallySynchronizedBit = 1,
        [Obsolete("Deprecated in favour of \"ReadOnlyBit\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_READ_ONLY_BIT")]
        PipelineCacheCreateReadOnlyBit = 2,
        [Obsolete("Deprecated in favour of \"UseApplicationStorageBit\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_USE_APPLICATION_STORAGE_BIT")]
        PipelineCacheCreateUseApplicationStorageBit = 4,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT")]
        ExternallySynchronizedBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT")]
        ExternallySynchronizedBit = 1,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_READ_ONLY_BIT")]
        ReadOnlyBit = 2,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_USE_APPLICATION_STORAGE_BIT")]
        UseApplicationStorageBit = 4,
    }
}
