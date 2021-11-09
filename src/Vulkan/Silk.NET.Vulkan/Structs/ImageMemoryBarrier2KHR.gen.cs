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
    [NativeName("Name", "VkImageMemoryBarrier2KHR")]
    public unsafe partial struct ImageMemoryBarrier2KHR : IChainStart
    {
        public ImageMemoryBarrier2KHR
        (
            StructureType? sType = StructureType.ImageMemoryBarrier2Khr,
            void* pNext = null,
            PipelineStageFlags2KHR? srcStageMask = null,
            AccessFlags2KHR? srcAccessMask = null,
            PipelineStageFlags2KHR? dstStageMask = null,
            AccessFlags2KHR? dstAccessMask = null,
            ImageLayout? oldLayout = null,
            ImageLayout? newLayout = null,
            uint? srcQueueFamilyIndex = null,
            uint? dstQueueFamilyIndex = null,
            Image? image = null,
            ImageSubresourceRange? subresourceRange = null
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

            if (srcStageMask is not null)
            {
                SrcStageMask = srcStageMask.Value;
            }

            if (srcAccessMask is not null)
            {
                SrcAccessMask = srcAccessMask.Value;
            }

            if (dstStageMask is not null)
            {
                DstStageMask = dstStageMask.Value;
            }

            if (dstAccessMask is not null)
            {
                DstAccessMask = dstAccessMask.Value;
            }

            if (oldLayout is not null)
            {
                OldLayout = oldLayout.Value;
            }

            if (newLayout is not null)
            {
                NewLayout = newLayout.Value;
            }

            if (srcQueueFamilyIndex is not null)
            {
                SrcQueueFamilyIndex = srcQueueFamilyIndex.Value;
            }

            if (dstQueueFamilyIndex is not null)
            {
                DstQueueFamilyIndex = dstQueueFamilyIndex.Value;
            }

            if (image is not null)
            {
                Image = image.Value;
            }

            if (subresourceRange is not null)
            {
                SubresourceRange = subresourceRange.Value;
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
        [NativeName("Type", "VkPipelineStageFlags2KHR")]
        [NativeName("Type.Name", "VkPipelineStageFlags2KHR")]
        [NativeName("Name", "srcStageMask")]
        public PipelineStageFlags2KHR SrcStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags2KHR")]
        [NativeName("Type.Name", "VkAccessFlags2KHR")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags2KHR SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkPipelineStageFlags2KHR")]
        [NativeName("Type.Name", "VkPipelineStageFlags2KHR")]
        [NativeName("Name", "dstStageMask")]
        public PipelineStageFlags2KHR DstStageMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags2KHR")]
        [NativeName("Type.Name", "VkAccessFlags2KHR")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags2KHR DstAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "oldLayout")]
        public ImageLayout OldLayout;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "newLayout")]
        public ImageLayout NewLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "srcQueueFamilyIndex")]
        public uint SrcQueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dstQueueFamilyIndex")]
        public uint DstQueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceRange")]
        [NativeName("Type.Name", "VkImageSubresourceRange")]
        [NativeName("Name", "subresourceRange")]
        public ImageSubresourceRange SubresourceRange;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImageMemoryBarrier2Khr;
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
        public static unsafe ref ImageMemoryBarrier2KHR Chain(
            out ImageMemoryBarrier2KHR capture)
        {
            capture = new ImageMemoryBarrier2KHR(StructureType.ImageMemoryBarrier2Khr);
            return ref capture;
        }
    }
}
