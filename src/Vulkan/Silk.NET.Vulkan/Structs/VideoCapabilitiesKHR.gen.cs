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
    [NativeName("Name", "VkVideoCapabilitiesKHR")]
    public unsafe partial struct VideoCapabilitiesKHR : IChainStart
    {
        public VideoCapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoCapabilitiesKhr,
            void* pNext = null,
            VideoCapabilityFlagsKHR? capabilityFlags = null,
            ulong? minBitstreamBufferOffsetAlignment = null,
            ulong? minBitstreamBufferSizeAlignment = null,
            Extent2D? videoPictureExtentGranularity = null,
            Extent2D? minExtent = null,
            Extent2D? maxExtent = null,
            uint? maxReferencePicturesSlotsCount = null,
            uint? maxReferencePicturesActiveCount = null
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

            if (capabilityFlags is not null)
            {
                CapabilityFlags = capabilityFlags.Value;
            }

            if (minBitstreamBufferOffsetAlignment is not null)
            {
                MinBitstreamBufferOffsetAlignment = minBitstreamBufferOffsetAlignment.Value;
            }

            if (minBitstreamBufferSizeAlignment is not null)
            {
                MinBitstreamBufferSizeAlignment = minBitstreamBufferSizeAlignment.Value;
            }

            if (videoPictureExtentGranularity is not null)
            {
                VideoPictureExtentGranularity = videoPictureExtentGranularity.Value;
            }

            if (minExtent is not null)
            {
                MinExtent = minExtent.Value;
            }

            if (maxExtent is not null)
            {
                MaxExtent = maxExtent.Value;
            }

            if (maxReferencePicturesSlotsCount is not null)
            {
                MaxReferencePicturesSlotsCount = maxReferencePicturesSlotsCount.Value;
            }

            if (maxReferencePicturesActiveCount is not null)
            {
                MaxReferencePicturesActiveCount = maxReferencePicturesActiveCount.Value;
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
        [NativeName("Type", "VkVideoCapabilityFlagsKHR")]
        [NativeName("Type.Name", "VkVideoCapabilityFlagsKHR")]
        [NativeName("Name", "capabilityFlags")]
        public VideoCapabilityFlagsKHR CapabilityFlags;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minBitstreamBufferOffsetAlignment")]
        public ulong MinBitstreamBufferOffsetAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minBitstreamBufferSizeAlignment")]
        public ulong MinBitstreamBufferSizeAlignment;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "videoPictureExtentGranularity")]
        public Extent2D VideoPictureExtentGranularity;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minExtent")]
        public Extent2D MinExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxExtent")]
        public Extent2D MaxExtent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxReferencePicturesSlotsCount")]
        public uint MaxReferencePicturesSlotsCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxReferencePicturesActiveCount")]
        public uint MaxReferencePicturesActiveCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoCapabilitiesKhr;
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
        public static unsafe ref VideoCapabilitiesKHR Chain(
            out VideoCapabilitiesKHR capture)
        {
            capture = new VideoCapabilitiesKHR(StructureType.VideoCapabilitiesKhr);
            return ref capture;
        }
    }
}
