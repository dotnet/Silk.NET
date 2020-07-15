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
    [NativeName("Name", "VkPeerMemoryFeatureFlagsKHR")]
    public enum PeerMemoryFeatureFlagsKHR
    {
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT")]
        PeerMemoryFeatureCopySrcBit = 1,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_COPY_DST_BIT")]
        PeerMemoryFeatureCopyDstBit = 2,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT")]
        PeerMemoryFeatureGenericSrcBit = 4,
        [NativeName("Name", "VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT")]
        PeerMemoryFeatureGenericDstBit = 8,
    }
}
