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
    [NativeName("Name", "VkSparseMemoryBind")]
    public unsafe struct SparseMemoryBind
    {
        public SparseMemoryBind
        (
            ulong resourceOffset = default,
            ulong size = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default,
            SparseMemoryBindFlags flags = default
        )
        {
           ResourceOffset = resourceOffset;
           Size = size;
           Memory = memory;
           MemoryOffset = memoryOffset;
           Flags = flags;
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "resourceOffset")]
        public ulong ResourceOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
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
