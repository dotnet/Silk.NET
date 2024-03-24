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
            Buffer? dstBuffer = null,
            ulong? dstBufferOffset = null,
            ulong? dstBufferRange = null,
            VideoPictureResourceInfoKHR? srcPictureResource = null,
            VideoReferenceSlotInfoKHR* pSetupReferenceSlot = null,
            uint? referenceSlotCount = null,
            VideoReferenceSlotInfoKHR* pReferenceSlots = null,
            uint? precedingExternallyEncodedBytes = null
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

            if (dstBuffer is not null)
            {
                DstBuffer = dstBuffer.Value;
            }

            if (dstBufferOffset is not null)
            {
                DstBufferOffset = dstBufferOffset.Value;
            }

            if (dstBufferRange is not null)
            {
                DstBufferRange = dstBufferRange.Value;
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

            if (precedingExternallyEncodedBytes is not null)
            {
                PrecedingExternallyEncodedBytes = precedingExternallyEncodedBytes.Value;
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
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "dstBuffer")]
        public Buffer DstBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "dstBufferOffset")]
        public ulong DstBufferOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "dstBufferRange")]
        public ulong DstBufferRange;
/// <summary></summary>
        [NativeName("Type", "VkVideoPictureResourceInfoKHR")]
        [NativeName("Type.Name", "VkVideoPictureResourceInfoKHR")]
        [NativeName("Name", "srcPictureResource")]
        public VideoPictureResourceInfoKHR SrcPictureResource;
/// <summary></summary>
        [NativeName("Type", "VkVideoReferenceSlotInfoKHR*")]
        [NativeName("Type.Name", "VkVideoReferenceSlotInfoKHR")]
        [NativeName("Name", "pSetupReferenceSlot")]
        public VideoReferenceSlotInfoKHR* PSetupReferenceSlot;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "referenceSlotCount")]
        public uint ReferenceSlotCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoReferenceSlotInfoKHR*")]
        [NativeName("Type.Name", "VkVideoReferenceSlotInfoKHR")]
        [NativeName("Name", "pReferenceSlots")]
        public VideoReferenceSlotInfoKHR* PReferenceSlots;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "precedingExternallyEncodedBytes")]
        public uint PrecedingExternallyEncodedBytes;

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
