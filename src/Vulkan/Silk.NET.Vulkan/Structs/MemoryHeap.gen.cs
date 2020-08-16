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
    [NativeName("Name", "VkMemoryHeap")]
    public unsafe partial struct MemoryHeap
    {
        public MemoryHeap
        (
            ulong size = default,
            MemoryHeapFlags flags = default
        )
        {
            Size = size;
            Flags = flags;
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkMemoryHeapFlags")]
        [NativeName("Type.Name", "VkMemoryHeapFlags")]
        [NativeName("Name", "flags")]
        public MemoryHeapFlags Flags;
    }
}
