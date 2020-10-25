// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMemoryType")]
    public unsafe partial struct MemoryType
    {
        public MemoryType
        (
            MemoryPropertyFlags? propertyFlags = null,
            uint? heapIndex = null
        ) : this()
        {
            if (propertyFlags is not null)
            {
                PropertyFlags = propertyFlags.Value;
            }

            if (heapIndex is not null)
            {
                HeapIndex = heapIndex.Value;
            }
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
