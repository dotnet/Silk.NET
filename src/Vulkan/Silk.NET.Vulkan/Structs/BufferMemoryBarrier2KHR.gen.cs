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
    [NativeName("Name", "VkBufferMemoryBarrier2KHR")]
    public unsafe partial struct BufferMemoryBarrier2KHR : IChainable
    {
        public BufferMemoryBarrier2KHR
        (
            StructureType? sType = StructureType.BufferMemoryBarrier2Khr,
            void* pNext = null,
            PipelineStageFlags2KHR? srcStageMask = null,
            AccessFlags2KHR? srcAccessMask = null,
            PipelineStageFlags2KHR? dstStageMask = null,
            AccessFlags2KHR? dstAccessMask = null,
            uint? srcQueueFamilyIndex = null,
            uint? dstQueueFamilyIndex = null,
            Buffer? buffer = null,
            ulong? offset = null,
            ulong? size = null
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

            if (srcQueueFamilyIndex is not null)
            {
                SrcQueueFamilyIndex = srcQueueFamilyIndex.Value;
            }

            if (dstQueueFamilyIndex is not null)
            {
                DstQueueFamilyIndex = dstQueueFamilyIndex.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
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
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer Buffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "offset")]
        public ulong Offset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BufferMemoryBarrier2Khr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
