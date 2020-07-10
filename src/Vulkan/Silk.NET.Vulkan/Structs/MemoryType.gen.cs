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
    [NativeName("Name", "VkMemoryType")]
    public unsafe partial struct MemoryType
    {
        public MemoryType
        (
            MemoryPropertyFlags propertyFlags = default,
            uint heapIndex = default
        )
        {
            PropertyFlags = propertyFlags;
            HeapIndex = heapIndex;
        }

/// <summary></summary>
        [NativeName("Type", "VkMemoryPropertyFlags")]
        [NativeName("Type.Name", "VkMemoryPropertyFlags")]
        [NativeName("Name", "propertyFlags")]
        public MemoryPropertyFlags PropertyFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "heapIndex")]
        public uint HeapIndex;
    }
}
