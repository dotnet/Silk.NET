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
    public unsafe struct ImageMemoryBarrier
    {
        public ImageMemoryBarrier
        (
            StructureType sType = StructureType.ImageMemoryBarrier,
            void* pNext = default,
            AccessFlags srcAccessMask = default,
            AccessFlags dstAccessMask = default,
            ImageLayout oldLayout = default,
            ImageLayout newLayout = default,
            uint srcQueueFamilyIndex = default,
            uint dstQueueFamilyIndex = default,
            Image image = default,
            ImageSubresourceRange subresourceRange = default
        )
        {
           SType = sType;
           PNext = pNext;
           SrcAccessMask = srcAccessMask;
           DstAccessMask = dstAccessMask;
           OldLayout = oldLayout;
           NewLayout = newLayout;
           SrcQueueFamilyIndex = srcQueueFamilyIndex;
           DstQueueFamilyIndex = dstQueueFamilyIndex;
           Image = image;
           SubresourceRange = subresourceRange;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        public AccessFlags DstAccessMask;
/// <summary></summary>
        public ImageLayout OldLayout;
/// <summary></summary>
        public ImageLayout NewLayout;
/// <summary></summary>
        public uint SrcQueueFamilyIndex;
/// <summary></summary>
        public uint DstQueueFamilyIndex;
/// <summary></summary>
        public Image Image;
/// <summary></summary>
        public ImageSubresourceRange SubresourceRange;
    }
}
