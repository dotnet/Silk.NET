// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerMipmapMode")]
    public enum SamplerMipmapMode : int
    {
        [NativeName("Name", "VK_SAMPLER_MIPMAP_MODE_NEAREST")]
        Nearest = 0,
        [NativeName("Name", "VK_SAMPLER_MIPMAP_MODE_LINEAR")]
        Linear = 1,
    }
}
