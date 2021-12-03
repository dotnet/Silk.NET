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
    [NativeName("Name", "VkVideoEncodeInfoKHR")]
    public unsafe partial struct VideoEncodeInfoKHR : IChainStart
    {
        public VideoEncodeInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeInfoKhr,
            void* pNext = null,
            VideoEncodeFlagsKHR? flags = null,
            uint? qualityLevel = null,
            Extent2D? codedExtent = null,
            Buffer? dstBitstreamBuffer = null,
            ulong? dstBitstreamBufferOffset = null,
            ulong? dstBitstreamBufferMaxRange = null,
            VideoPictureResourceKHR? srcPictureResource = null,
            VideoReferenceSlotKHR* pSetupReferenceSlot = null,
            uint? referenceSlotCount = null,
            VideoReferenceSlotKHR* pReferenceSlots = null
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

            if (qualityLevel is not null)
            {
                QualityLevel = qualityLevel.Value;
            }

            if (codedExtent is not null)
            {
                CodedExtent = codedExtent.Value;
            }

            if (dstBitstreamBuffer is not null)
            {
                DstBitstreamBuffer = dstBitstreamBuffer.Value;
            }

            if (dstBitstreamBufferOffset is not null)
            {
                DstBitstreamBufferOffset = dstBitstreamBufferOffset.Value;
            }

            if (dstBitstreamBufferMaxRange is not null)
            {
                DstBitstreamBufferMaxRange = dstBitstreamBufferMaxRange.Value;
            }

            if (srcPictureResource is not null)
            {
                SrcPictureResource = srcPictureResource.Value;
            }

            if (pSetupReferenceSlot is not null)
            {
                PSetupReferenceSlot = pSetupReferenceSlot;
            }

            if (referenceSlotCount is not null)
            {
                ReferenceSlotCount = referenceSlotCount.Value;
            }

            if (pReferenceSlots is not null)
            {
                PReferenceSlots = pReferenceSlots;
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
        [NativeName("Type", "VkVideoEncodeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "qualityLevel")]
        public uint QualityLevel;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "codedExtent")]
        public Extent2D CodedExtent;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "dstBitstreamBuffer")]
        public Buffer DstBitstreamBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "dstBitstreamBufferOffset")]
        public ulong DstBitstreamBufferOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "dstBitstreamBufferMaxRange")]
        public ulong DstBitstreamBufferMaxRange;
/// <summary></summary>
        [NativeName("Type", "VkVideoPictureResourceKHR")]
        [NativeName("Type.Name", "VkVideoPictureResourceKHR")]
        [NativeName("Name", "srcPictureResource")]
        public VideoPictureResourceKHR SrcPictureResource;
/// <summary></summary>
        [NativeName("Type", "VkVideoReferenceSlotKHR*")]
        [NativeName("Type.Name", "VkVideoReferenceSlotKHR")]
        [NativeName("Name", "pSetupReferenceSlot")]
        public VideoReferenceSlotKHR* PSetupReferenceSlot;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "referenceSlotCount")]
        public uint ReferenceSlotCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoReferenceSlotKHR*")]
        [NativeName("Type.Name", "VkVideoReferenceSlotKHR")]
        [NativeName("Name", "pReferenceSlots")]
        public VideoReferenceSlotKHR* PReferenceSlots;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeInfoKhr;
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
        public static unsafe ref VideoEncodeInfoKHR Chain(
            out VideoEncodeInfoKHR capture)
        {
            capture = new VideoEncodeInfoKHR(StructureType.VideoEncodeInfoKhr);
            return ref capture;
        }
    }
}
