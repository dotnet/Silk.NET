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
        [Obsolete("Deprecated in favour of \"Reserved1BitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_EXT")]
        PipelineCacheCreateReserved1BitExt = 2,
        [Obsolete("Deprecated in favour of \"ExternallySynchronizedBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT")]
        PipelineCacheCreateExternallySynchronizedBitExt = 1,
        [Obsolete("Deprecated in favour of \"Reserved1BitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_KHR")]
        PipelineCacheCreateReserved1BitKhr = 2,
        [Obsolete("Deprecated in favour of \"Reserved2BitKhr\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_RESERVED_2_BIT_KHR")]
        PipelineCacheCreateReserved2BitKhr = 4,
        [Obsolete("Deprecated in favour of \"ExternallySynchronizedBit\"")]
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT")]
        PipelineCacheCreateExternallySynchronizedBit = 1,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_EXT")]
        Reserved1BitExt = 2,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT_EXT")]
        ExternallySynchronizedBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_RESERVED_1_BIT_KHR")]
        Reserved1BitKhr = 2,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_RESERVED_2_BIT_KHR")]
        Reserved2BitKhr = 4,
        [NativeName("Name", "VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT")]
        ExternallySynchronizedBit = 1,
    }
}
