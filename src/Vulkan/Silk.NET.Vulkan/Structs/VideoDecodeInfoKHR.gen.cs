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
    [NativeName("Name", "VkVideoDecodeInfoKHR")]
    public unsafe partial struct VideoDecodeInfoKHR : IChainStart
    {
        public VideoDecodeInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeInfoKhr,
            void* pNext = null,
            uint? flags = null,
            Buffer? srcBuffer = null,
            ulong? srcBufferOffset = null,
            ulong? srcBufferRange = null,
            VideoPictureResourceInfoKHR? dstPictureResource = null,
            VideoReferenceSlotInfoKHR* pSetupReferenceSlot = null,
            uint? referenceSlotCount = null,
            VideoReferenceSlotInfoKHR* pReferenceSlots = null
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

            if (srcBuffer is not null)
            {
                SrcBuffer = srcBuffer.Value;
            }

            if (srcBufferOffset is not null)
            {
                SrcBufferOffset = srcBufferOffset.Value;
            }

            if (srcBufferRange is not null)
            {
                SrcBufferRange = srcBufferRange.Value;
            }

            if (dstPictureResource is not null)
            {
                DstPictureResource = dstPictureResource.Value;
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
        [NativeName("Type", "VkVideoDecodeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoDecodeFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "srcBuffer")]
        public Buffer SrcBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "srcBufferOffset")]
        public ulong SrcBufferOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "srcBufferRange")]
        public ulong SrcBufferRange;
/// <summary></summary>
        [NativeName("Type", "VkVideoPictureResourceInfoKHR")]
        [NativeName("Type.Name", "VkVideoPictureResourceInfoKHR")]
        [NativeName("Name", "dstPictureResource")]
        public VideoPictureResourceInfoKHR DstPictureResource;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeInfoKhr;
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
        public static unsafe ref VideoDecodeInfoKHR Chain(
            out VideoDecodeInfoKHR capture)
        {
            capture = new VideoDecodeInfoKHR(StructureType.VideoDecodeInfoKhr);
            return ref capture;
        }
    }
}
