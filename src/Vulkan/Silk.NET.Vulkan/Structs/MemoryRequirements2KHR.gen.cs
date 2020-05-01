// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct MemoryRequirements2KHR
    {
        public MemoryRequirements2KHR
        (
            StructureType sType = StructureType.MemoryRequirements2,
            void* pNext = default,
            MemoryRequirements memoryRequirements = default
        )
        {
           SType = sType;
           PNext = pNext;
           MemoryRequirements = memoryRequirements;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public MemoryRequirements MemoryRequirements;
    }
}
