// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct ImageViewHandleInfoNVX
    {
        public ImageViewHandleInfoNVX
        (
            StructureType sType = StructureType.ImageViewHandleInfoNvx,
            void* pNext = default,
            ImageView imageView = default,
            DescriptorType descriptorType = default,
            Sampler sampler = default
        )
        {
           SType = sType;
           PNext = pNext;
           ImageView = imageView;
           DescriptorType = descriptorType;
           Sampler = sampler;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageView ImageView;
/// <summary></summary>
        public DescriptorType DescriptorType;
/// <summary></summary>
        public Sampler Sampler;
    }
}
