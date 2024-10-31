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
    [NativeName("Name", "VkCopyMemoryToImageIndirectCommandNV")]
    public unsafe partial struct CopyMemoryToImageIndirectCommandNV
    {
        public CopyMemoryToImageIndirectCommandNV
        (
            ulong? srcAddress = null,
            uint? bufferRowLength = null,
            uint? bufferImageHeight = null,
            ImageSubresourceLayers? imageSubresource = null,
            Offset3D? imageOffset = null,
            Extent3D? imageExtent = null
        ) : this()
        {
            if (srcAddress is not null)
            {
                SrcAddress = srcAddress.Value;
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
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "srcAddress")]
        public ulong SrcAddress;
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
