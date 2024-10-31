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
    [NativeName("Name", "VkImageCreateInfo")]
    public unsafe partial struct ImageCreateInfo : IChainStart
    {
        public ImageCreateInfo
        (
            StructureType? sType = StructureType.ImageCreateInfo,
            void* pNext = null,
            ImageCreateFlags? flags = null,
            ImageType? imageType = null,
            Format? format = null,
            Extent3D? extent = null,
            uint? mipLevels = null,
            uint? arrayLayers = null,
            SampleCountFlags? samples = null,
            ImageTiling? tiling = null,
            ImageUsageFlags? usage = null,
            SharingMode? sharingMode = null,
            uint? queueFamilyIndexCount = null,
            uint* pQueueFamilyIndices = null,
            ImageLayout? initialLayout = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (imageType is not null)
            {
                ImageType = imageType.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (extent is not null)
            {
                Extent = extent.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (arrayLayers is not null)
            {
                ArrayLayers = arrayLayers.Value;
            }

            if (samples is not null)
            {
                Samples = samples.Value;
            }

            if (tiling is not null)
            {
                Tiling = tiling.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (sharingMode is not null)
            {
                SharingMode = sharingMode.Value;
            }

            if (queueFamilyIndexCount is not null)
            {
                QueueFamilyIndexCount = queueFamilyIndexCount.Value;
            }

            if (pQueueFamilyIndices is not null)
            {
                PQueueFamilyIndices = pQueueFamilyIndices;
            }

            if (initialLayout is not null)
            {
                InitialLayout = initialLayout.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref ImageCreateInfo Chain(
            out ImageCreateInfo capture)
        {
            capture = new ImageCreateInfo(StructureType.ImageCreateInfo);
            return ref capture;
        }
    }
}
