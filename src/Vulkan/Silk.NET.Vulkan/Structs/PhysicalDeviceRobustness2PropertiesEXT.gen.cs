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
    [NativeName("Name", "VkPhysicalDeviceRobustness2PropertiesEXT")]
    public unsafe struct PhysicalDeviceRobustness2PropertiesEXT
    {
        public PhysicalDeviceRobustness2PropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceRobustness2PropertiesExt,
            void* pNext = default,
            ulong robustStorageBufferAccessSizeAlignment = default,
            ulong robustUniformBufferAccessSizeAlignment = default
        )
        {
           SType = sType;
           PNext = pNext;
           RobustStorageBufferAccessSizeAlignment = robustStorageBufferAccessSizeAlignment;
           RobustUniformBufferAccessSizeAlignment = robustUniformBufferAccessSizeAlignment;
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
        [NativeName("Name", "robustStorageBufferAccessSizeAlignment")]
        public ulong RobustStorageBufferAccessSizeAlignment;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "robustUniformBufferAccessSizeAlignment")]
        public ulong RobustUniformBufferAccessSizeAlignment;
    }
}
