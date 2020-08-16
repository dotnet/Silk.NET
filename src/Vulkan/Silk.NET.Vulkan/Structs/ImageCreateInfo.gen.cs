// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageCreateInfo")]
    public unsafe partial struct ImageCreateInfo
    {
        public ImageCreateInfo
        (
            StructureType sType = StructureType.ImageCreateInfo,
            void* pNext = default,
            ImageCreateFlags flags = default,
            ImageType imageType = default,
            Format format = default,
            Extent3D extent = default,
            uint mipLevels = default,
            uint arrayLayers = default,
            SampleCountFlags samples = default,
            ImageTiling tiling = default,
            ImageUsageFlags usage = default,
            SharingMode sharingMode = default,
            uint queueFamilyIndexCount = default,
            uint* pQueueFamilyIndices = default,
            ImageLayout initialLayout = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            ImageType = imageType;
            Format = format;
            Extent = extent;
            MipLevels = mipLevels;
            ArrayLayers = arrayLayers;
            Samples = samples;
            Tiling = tiling;
            Usage = usage;
            SharingMode = sharingMode;
            QueueFamilyIndexCount = queueFamilyIndexCount;
            PQueueFamilyIndices = pQueueFamilyIndices;
            InitialLayout = initialLayout;
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
        [NativeName("Type", "VkImageCreateFlags")]
        [NativeName("Type.Name", "VkImageCreateFlags")]
        [NativeName("Name", "flags")]
        public ImageCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkImageType")]
        [NativeName("Type.Name", "VkImageType")]
        [NativeName("Name", "imageType")]
        public ImageType ImageType;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "extent")]
        public Extent3D Extent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevels")]
        public uint MipLevels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayLayers")]
        public uint ArrayLayers;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "samples")]
        public SampleCountFlags Samples;
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
        [NativeName("Type", "VkSharingMode")]
        [NativeName("Type.Name", "VkSharingMode")]
        [NativeName("Name", "sharingMode")]
        public SharingMode SharingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndexCount")]
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pQueueFamilyIndices")]
        public uint* PQueueFamilyIndices;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "initialLayout")]
        public ImageLayout InitialLayout;
    }
}
