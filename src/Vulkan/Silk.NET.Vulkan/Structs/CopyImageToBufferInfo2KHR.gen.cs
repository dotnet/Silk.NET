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
    [NativeName("Name", "VkCopyImageToBufferInfo2KHR")]
    public unsafe partial struct CopyImageToBufferInfo2KHR
    {
        public CopyImageToBufferInfo2KHR
        (
            StructureType? sType = StructureType.CopyImageToBufferInfo2Khr,
            void* pNext = null,
            Image? srcImage = null,
            ImageLayout? srcImageLayout = null,
            Buffer? dstBuffer = null,
            uint? regionCount = null,
            BufferImageCopy2KHR* pRegions = null
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

            if (dstBuffer is not null)
            {
                DstBuffer = dstBuffer.Value;
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
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "dstBuffer")]
        public Buffer DstBuffer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionCount")]
        public uint RegionCount;
/// <summary></summary>
        [NativeName("Type", "VkBufferImageCopy2KHR*")]
        [NativeName("Type.Name", "VkBufferImageCopy2KHR")]
        [NativeName("Name", "pRegions")]
        public BufferImageCopy2KHR* PRegions;
    }
}
