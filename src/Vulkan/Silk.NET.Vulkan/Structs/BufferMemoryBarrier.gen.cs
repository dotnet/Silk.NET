// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkBufferMemoryBarrier")]
    public unsafe partial struct BufferMemoryBarrier
    {
        public BufferMemoryBarrier
        (
            StructureType? sType = StructureType.BufferMemoryBarrier,
            void* pNext = null,
            AccessFlags? srcAccessMask = null,
            AccessFlags? dstAccessMask = null,
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

            if (srcAccessMask is not null)
            {
                SrcAccessMask = srcAccessMask.Value;
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
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "srcAccessMask")]
        public AccessFlags SrcAccessMask;
/// <summary></summary>
        [NativeName("Type", "VkAccessFlags")]
        [NativeName("Type.Name", "VkAccessFlags")]
        [NativeName("Name", "dstAccessMask")]
        public AccessFlags DstAccessMask;
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
    }
}
