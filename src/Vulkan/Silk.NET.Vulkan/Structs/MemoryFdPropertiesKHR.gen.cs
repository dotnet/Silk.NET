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
    public unsafe struct MemoryFdPropertiesKHR
    {
        public MemoryFdPropertiesKHR
        (
            StructureType sType = StructureType.MemoryFDPropertiesKhr,
            void* pNext = default,
            uint memoryTypeBits = default
        )
        {
           SType = sType;
           PNext = pNext;
           MemoryTypeBits = memoryTypeBits;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MemoryTypeBits;
    }
}
