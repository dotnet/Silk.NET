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
    [NativeName("Name", "VkPhysicalDeviceMemoryBudgetPropertiesEXT")]
    public unsafe struct PhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public PhysicalDeviceMemoryBudgetPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceMemoryBudgetPropertiesExt,
            void* pNext = default
        )
        {
           SType = sType;
           PNext = pNext;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
        /// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "heapBudget")]
        public fixed ulong HeapBudget[16];
        /// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "heapUsage")]
        public fixed ulong HeapUsage[16];
    }
}
