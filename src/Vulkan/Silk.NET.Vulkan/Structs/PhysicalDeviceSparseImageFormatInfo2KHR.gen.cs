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
    [NativeName("Name", "VkPhysicalDeviceSparseImageFormatInfo2KHR")]
    public unsafe partial struct PhysicalDeviceSparseImageFormatInfo2KHR
    {
        public PhysicalDeviceSparseImageFormatInfo2KHR
        (
            StructureType? sType = StructureType.PhysicalDeviceSparseImageFormatInfo2,
            void* pNext = null,
            Format? format = null,
            ImageType? type = null,
            SampleCountFlags? samples = null,
            ImageUsageFlags? usage = null,
            ImageTiling? tiling = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (samples is not null)
            {
                Samples = samples.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (tiling is not null)
            {
                Tiling = tiling.Value;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkImageType")]
        [NativeName("Type.Name", "VkImageType")]
        [NativeName("Name", "type")]
        public ImageType Type;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "samples")]
        public SampleCountFlags Samples;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "usage")]
        public ImageUsageFlags Usage;
/// <summary></summary>
        [NativeName("Type", "VkImageTiling")]
        [NativeName("Type.Name", "VkImageTiling")]
        [NativeName("Name", "tiling")]
        public ImageTiling Tiling;
    }
}
