// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct DescriptorImageInfo
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
        public Sampler Sampler;
/// <summary></summary>
        public ImageView ImageView;
/// <summary></summary>
        public ImageLayout ImageLayout;
    }
}
