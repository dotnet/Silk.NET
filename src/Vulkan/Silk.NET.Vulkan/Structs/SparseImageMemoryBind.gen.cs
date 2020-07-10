// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSparseImageMemoryBind")]
    public unsafe partial struct SparseImageMemoryBind
    {
        public SparseImageMemoryBind
        (
            ImageSubresource subresource = default,
            Offset3D offset = default,
            Extent3D extent = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default,
            SparseMemoryBindFlags flags = default
        )
        {
            Subresource = subresource;
            Offset = offset;
            Extent = extent;
            Memory = memory;
            MemoryOffset = memoryOffset;
            Flags = flags;
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
