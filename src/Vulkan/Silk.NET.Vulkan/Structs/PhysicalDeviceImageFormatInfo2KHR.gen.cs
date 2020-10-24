// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceImageFormatInfo2KHR")]
    public unsafe partial struct PhysicalDeviceImageFormatInfo2KHR
    {
        public PhysicalDeviceImageFormatInfo2KHR
        (
            StructureType? sType = StructureType.PhysicalDeviceImageFormatInfo2,
            void* pNext = null,
            Format? format = null,
            ImageType? type = null,
            ImageTiling? tiling = null,
            ImageUsageFlags? usage = null,
            ImageCreateFlags? flags = null
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

            if (tiling is not null)
            {
                Tiling = tiling.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Type", "VkImageTiling")]
        [NativeName("Type.Name", "VkImageTiling")]
        [NativeName("Name", "tiling")]
        public ImageTiling Tiling;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "usage")]
        public ImageUsageFlags Usage;
/// <summary></summary>
        [NativeName("Type", "VkImageCreateFlags")]
        [NativeName("Type.Name", "VkImageCreateFlags")]
        [NativeName("Name", "flags")]
        public ImageCreateFlags Flags;
    }
}
