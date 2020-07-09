// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerAddressMode")]
    public enum SamplerAddressMode
    {
        [NativeName("Name", "VK_SAMPLER_ADDRESS_MODE_REPEAT")]
        Repeat = 0,
        [NativeName("Name", "VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT")]
        MirroredRepeat = 1,
        [NativeName("Name", "VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE")]
        ClampToEdge = 2,
        [NativeName("Name", "VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER")]
        ClampToBorder = 3,
        [NativeName("Name", "VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE")]
        MirrorClampToEdge = 4,
        [NativeName("Name", "VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE_KHR")]
        MirrorClampToEdgeKhr = 4,
    }
}
