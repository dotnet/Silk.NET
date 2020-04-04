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
    public unsafe struct MemoryHeap
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
        public ulong Size;
/// <summary></summary>
        public MemoryHeapFlags Flags;
    }
}
