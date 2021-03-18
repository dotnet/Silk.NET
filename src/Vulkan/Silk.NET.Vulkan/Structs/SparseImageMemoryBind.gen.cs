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
    [NativeName("Name", "VkSparseImageMemoryBind")]
    public unsafe partial struct SparseImageMemoryBind
    {
        public SparseImageMemoryBind
        (
            ImageSubresource? subresource = null,
            Offset3D? offset = null,
            Extent3D? extent = null,
            DeviceMemory? memory = null,
            ulong? memoryOffset = null,
            SparseMemoryBindFlags? flags = null
        ) : this()
        {
            if (subresource is not null)
            {
                Subresource = subresource.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (extent is not null)
            {
                Extent = extent.Value;
            }

            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (memoryOffset is not null)
            {
                MemoryOffset = memoryOffset.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkImageSubresource")]
        [NativeName("Type.Name", "VkImageSubresource")]
        [NativeName("Name", "subresource")]
        public ImageSubresource Subresource;
/// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "offset")]
        public Offset3D Offset;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "extent")]
        public Extent3D Extent;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "memoryOffset")]
        public ulong MemoryOffset;
/// <summary></summary>
        [NativeName("Type", "VkSparseMemoryBindFlags")]
        [NativeName("Type.Name", "VkSparseMemoryBindFlags")]
        [NativeName("Name", "flags")]
        public SparseMemoryBindFlags Flags;
    }
}
