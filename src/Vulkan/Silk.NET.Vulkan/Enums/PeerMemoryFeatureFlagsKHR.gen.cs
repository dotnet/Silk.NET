// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum PeerMemoryFeatureFlagsKHR
    {
        PeerMemoryFeatureCopySrcBit = 1,
        PeerMemoryFeatureCopyDstBit = 2,
        PeerMemoryFeatureGenericSrcBit = 4,
        PeerMemoryFeatureGenericDstBit = 8,
    }
}
