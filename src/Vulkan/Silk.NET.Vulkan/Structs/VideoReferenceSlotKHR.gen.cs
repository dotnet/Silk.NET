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
    [NativeName("Name", "VkVideoReferenceSlotKHR")]
    public unsafe partial struct VideoReferenceSlotKHR : IChainStart
    {
        public VideoReferenceSlotKHR
        (
            StructureType? sType = StructureType.VideoReferenceSlotKhr,
            void* pNext = null,
            sbyte? slotIndex = null,
            VideoPictureResourceKHR* pPictureResource = null
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
        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slotIndex")]
        public sbyte SlotIndex;
/// <summary></summary>
        [NativeName("Type", "VkVideoPictureResourceKHR*")]
        [NativeName("Type.Name", "VkVideoPictureResourceKHR")]
        [NativeName("Name", "pPictureResource")]
        public VideoPictureResourceKHR* PPictureResource;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoReferenceSlotKhr;
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
        public static unsafe ref VideoReferenceSlotKHR Chain(
            out VideoReferenceSlotKHR capture)
        {
            capture = new VideoReferenceSlotKHR(StructureType.VideoReferenceSlotKhr);
            return ref capture;
        }
    }
}
