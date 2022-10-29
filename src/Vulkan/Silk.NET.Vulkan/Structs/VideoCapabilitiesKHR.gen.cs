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
            VideoCapabilityFlagsKHR? flags = null,
            ulong? minBitstreamBufferOffsetAlignment = null,
            ulong? minBitstreamBufferSizeAlignment = null,
            Extent2D? pictureAccessGranularity = null,
            Extent2D? minCodedExtent = null,
            Extent2D? maxCodedExtent = null,
            uint? maxDpbSlots = null,
            uint? maxActiveReferencePictures = null,
            ExtensionProperties? stdHeaderVersion = null
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

            if (minBitstreamBufferOffsetAlignment is not null)
            {
                MinBitstreamBufferOffsetAlignment = minBitstreamBufferOffsetAlignment.Value;
            }

            if (minBitstreamBufferSizeAlignment is not null)
            {
                MinBitstreamBufferSizeAlignment = minBitstreamBufferSizeAlignment.Value;
            }

            if (pictureAccessGranularity is not null)
            {
                PictureAccessGranularity = pictureAccessGranularity.Value;
            }

            if (minCodedExtent is not null)
            {
                MinCodedExtent = minCodedExtent.Value;
            }

            if (maxCodedExtent is not null)
            {
                MaxCodedExtent = maxCodedExtent.Value;
            }

            if (maxDpbSlots is not null)
            {
                MaxDpbSlots = maxDpbSlots.Value;
            }

            if (maxActiveReferencePictures is not null)
            {
                MaxActiveReferencePictures = maxActiveReferencePictures.Value;
            }

            if (stdHeaderVersion is not null)
            {
                StdHeaderVersion = stdHeaderVersion.Value;
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
        [NativeName("Name", "flags")]
        public VideoCapabilityFlagsKHR Flags;
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
        [NativeName("Name", "pictureAccessGranularity")]
        public Extent2D PictureAccessGranularity;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minCodedExtent")]
        public Extent2D MinCodedExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxCodedExtent")]
        public Extent2D MaxCodedExtent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDpbSlots")]
        public uint MaxDpbSlots;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxActiveReferencePictures")]
        public uint MaxActiveReferencePictures;
/// <summary></summary>
        [NativeName("Type", "VkExtensionProperties")]
        [NativeName("Type.Name", "VkExtensionProperties")]
        [NativeName("Name", "stdHeaderVersion")]
        public ExtensionProperties StdHeaderVersion;

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
