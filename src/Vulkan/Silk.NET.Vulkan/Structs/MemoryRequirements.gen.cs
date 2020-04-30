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
    public unsafe struct MemoryRequirements
    {
        public MemoryRequirements
        (
            ulong size = default,
            ulong alignment = default,
            uint memoryTypeBits = default
        )
        {
           Size = size;
           Alignment = alignment;
           MemoryTypeBits = memoryTypeBits;
        }

/// <summary></summary>
        public ulong Size;
/// <summary></summary>
        public ulong Alignment;
/// <summary></summary>
        public uint MemoryTypeBits;
    }
}
