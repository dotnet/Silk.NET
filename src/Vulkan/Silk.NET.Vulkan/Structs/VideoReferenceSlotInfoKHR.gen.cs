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
    [NativeName("Name", "VkVideoReferenceSlotInfoKHR")]
    public unsafe partial struct VideoReferenceSlotInfoKHR : IChainStart
    {
        public VideoReferenceSlotInfoKHR
        (
            StructureType? sType = StructureType.VideoReferenceSlotInfoKhr,
            void* pNext = null,
            int? slotIndex = null,
            VideoPictureResourceInfoKHR* pPictureResource = null
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

            if (slotIndex is not null)
            {
                SlotIndex = slotIndex.Value;
            }

            if (pPictureResource is not null)
            {
                PPictureResource = pPictureResource;
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
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "slotIndex")]
        public int SlotIndex;
/// <summary></summary>
        [NativeName("Type", "VkVideoPictureResourceInfoKHR*")]
        [NativeName("Type.Name", "VkVideoPictureResourceInfoKHR")]
        [NativeName("Name", "pPictureResource")]
        public VideoPictureResourceInfoKHR* PPictureResource;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoReferenceSlotInfoKhr;
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
        public static unsafe ref VideoReferenceSlotInfoKHR Chain(
            out VideoReferenceSlotInfoKHR capture)
        {
            capture = new VideoReferenceSlotInfoKHR(StructureType.VideoReferenceSlotInfoKhr);
            return ref capture;
        }
    }
}
