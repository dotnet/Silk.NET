// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDescriptorImageInfo")]
    public unsafe partial struct DescriptorImageInfo
    {
        public DescriptorImageInfo
        (
            Sampler sampler = default,
            ImageView imageView = default,
            ImageLayout imageLayout = default
        )
        {
            Sampler = sampler;
            ImageView = imageView;
            ImageLayout = imageLayout;
        }

/// <summary></summary>
        [NativeName("Type", "VkSampler")]
        [NativeName("Type.Name", "VkSampler")]
        [NativeName("Name", "sampler")]
        public Sampler Sampler;
/// <summary></summary>
        [NativeName("Type", "VkImageView")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "imageView")]
        public ImageView ImageView;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "imageLayout")]
        public ImageLayout ImageLayout;
    }
}
