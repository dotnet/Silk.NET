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
    [NativeName("Name", "VkBufferImageCopy2KHR")]
    public unsafe partial struct BufferImageCopy2KHR
    {
        public BufferImageCopy2KHR
        (
            StructureType? sType = StructureType.BufferImageCopy2Khr,
            void* pNext = null,
            ulong? bufferOffset = null,
            uint? bufferRowLength = null,
            uint? bufferImageHeight = null,
            ImageSubresourceLayers? imageSubresource = null,
            Offset3D? imageOffset = null,
            Extent3D? imageExtent = null
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

            if (bufferOffset is not null)
            {
                BufferOffset = bufferOffset.Value;
            }

            if (bufferRowLength is not null)
            {
                BufferRowLength = bufferRowLength.Value;
            }

            if (bufferImageHeight is not null)
            {
                BufferImageHeight = bufferImageHeight.Value;
            }

            if (imageSubresource is not null)
            {
                ImageSubresource = imageSubresource.Value;
            }

            if (imageOffset is not null)
            {
                ImageOffset = imageOffset.Value;
            }

            if (imageExtent is not null)
            {
                ImageExtent = imageExtent.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "bufferOffset")]
        public ulong BufferOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferRowLength")]
        public uint BufferRowLength;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferImageHeight")]
        public uint BufferImageHeight;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "imageSubresource")]
        public ImageSubresourceLayers ImageSubresource;
/// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "imageOffset")]
        public Offset3D ImageOffset;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "imageExtent")]
        public Extent3D ImageExtent;
    }
}
