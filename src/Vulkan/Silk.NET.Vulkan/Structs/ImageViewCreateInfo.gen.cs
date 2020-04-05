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
    public unsafe struct ImageViewCreateInfo
    {
        public ImageViewCreateInfo
        (
            StructureType sType = StructureType.ImageViewCreateInfo,
            void* pNext = default,
            ImageViewCreateFlags flags = default,
            Image image = default,
            ImageViewType viewType = default,
            Format format = default,
            ComponentMapping components = default,
            ImageSubresourceRange subresourceRange = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Image = image;
           ViewType = viewType;
           Format = format;
           Components = components;
           SubresourceRange = subresourceRange;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageViewCreateFlags Flags;
/// <summary></summary>
        public Image Image;
/// <summary></summary>
        public ImageViewType ViewType;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public ComponentMapping Components;
/// <summary></summary>
        public ImageSubresourceRange SubresourceRange;
    }
}
