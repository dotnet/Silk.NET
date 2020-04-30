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
    public unsafe struct MemoryAllocateFlagsInfoKHR
    {
        public MemoryAllocateFlagsInfoKHR
        (
            StructureType sType = StructureType.MemoryAllocateFlagsInfo,
            void* pNext = default,
            MemoryAllocateFlags flags = default,
            uint deviceMask = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           DeviceMask = deviceMask;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public MemoryAllocateFlags Flags;
/// <summary></summary>
        public uint DeviceMask;
    }
}
