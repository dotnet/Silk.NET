// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBufferImageCopy")]
    public unsafe partial struct BufferImageCopy
    {
        public BufferImageCopy
        (
            ulong bufferOffset = default,
            uint bufferRowLength = default,
            uint bufferImageHeight = default,
            ImageSubresourceLayers imageSubresource = default,
            Offset3D imageOffset = default,
            Extent3D imageExtent = default
        )
        {
            BufferOffset = bufferOffset;
            BufferRowLength = bufferRowLength;
            BufferImageHeight = bufferImageHeight;
            ImageSubresource = imageSubresource;
            ImageOffset = imageOffset;
            ImageExtent = imageExtent;
        }

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
