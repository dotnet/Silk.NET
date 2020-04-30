// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct MemoryType
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
        public MemoryPropertyFlags PropertyFlags;
/// <summary></summary>
        public uint HeapIndex;
    }
}
