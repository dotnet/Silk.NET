// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDescriptorImageInfo")]
    public unsafe partial struct DescriptorImageInfo
    {
        public DescriptorImageInfo
        (
            Sampler? sampler = null,
            ImageView? imageView = null,
            ImageLayout? imageLayout = null
        ) : this()
        {
            if (sampler is not null)
            {
                Sampler = sampler.Value;
            }

            if (imageView is not null)
            {
                ImageView = imageView.Value;
            }

            if (imageLayout is not null)
            {
                ImageLayout = imageLayout.Value;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
