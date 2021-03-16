// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkResolveImageInfo2KHR")]
    public unsafe partial struct ResolveImageInfo2KHR
    {
        public ResolveImageInfo2KHR
        (
            StructureType? sType = StructureType.ResolveImageInfo2Khr,
            void* pNext = null,
            Image? srcImage = null,
            ImageLayout? srcImageLayout = null,
            Image? dstImage = null,
            ImageLayout? dstImageLayout = null,
            uint? regionCount = null,
            ImageResolve2KHR* pRegions = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (srcImage is not null)
            {
                SrcImage = srcImage.Value;
            }

            if (srcImageLayout is not null)
            {
                SrcImageLayout = srcImageLayout.Value;
            }

            if (dstImage is not null)
            {
                DstImage = dstImage.Value;
            }

            if (dstImageLayout is not null)
            {
                DstImageLayout = dstImageLayout.Value;
            }

            if (regionCount is not null)
            {
                RegionCount = regionCount.Value;
            }

            if (pRegions is not null)
            {
                PRegions = pRegions;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "srcImage")]
        public Image SrcImage;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "srcImageLayout")]
        public ImageLayout SrcImageLayout;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "dstImage")]
        public Image DstImage;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "dstImageLayout")]
        public ImageLayout DstImageLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionCount")]
        public uint RegionCount;
/// <summary></summary>
        [NativeName("Type", "VkImageResolve2KHR*")]
        [NativeName("Type.Name", "VkImageResolve2KHR")]
        [NativeName("Name", "pRegions")]
        public ImageResolve2KHR* PRegions;
    }
}
