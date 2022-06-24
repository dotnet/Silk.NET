// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPeerMemoryFeatureFlagsKHR")]
    public enum PeerMemoryFeatureFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CopySrcBit\"")]
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT")]
        PeerMemoryFeatureCopySrcBit = 1,
        [Obsolete("Deprecated in favour of \"CopyDstBit\"")]
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_COPY_DST_BIT")]
        PeerMemoryFeatureCopyDstBit = 2,
        [Obsolete("Deprecated in favour of \"GenericSrcBit\"")]
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT")]
        PeerMemoryFeatureGenericSrcBit = 4,
        [Obsolete("Deprecated in favour of \"GenericDstBit\"")]
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT")]
        PeerMemoryFeatureGenericDstBit = 8,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT")]
        CopySrcBit = 1,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_COPY_DST_BIT")]
        CopyDstBit = 2,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT")]
        GenericSrcBit = 4,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT")]
        GenericDstBit = 8,
    }
}
