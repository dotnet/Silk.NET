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
    public unsafe struct PhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public PhysicalDeviceMemoryPriorityFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceMemoryPriorityFeaturesExt,
            void* pNext = default,
            Bool32 memoryPriority = default
        )
        {
           SType = sType;
           PNext = pNext;
           MemoryPriority = memoryPriority;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 MemoryPriority;
    }
}
