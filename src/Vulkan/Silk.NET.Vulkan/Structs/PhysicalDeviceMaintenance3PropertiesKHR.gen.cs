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
    [NativeName("Name", "VkPhysicalDeviceMaintenance3PropertiesKHR")]
    public unsafe partial struct PhysicalDeviceMaintenance3PropertiesKHR
    {
        public PhysicalDeviceMaintenance3PropertiesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceMaintenance3Properties,
            void* pNext = default,
            uint maxPerSetDescriptors = default,
            ulong maxMemoryAllocationSize = default
        )
        {
            SType = sType;
            PNext = pNext;
            MaxPerSetDescriptors = maxPerSetDescriptors;
            MaxMemoryAllocationSize = maxMemoryAllocationSize;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerSetDescriptors")]
        public uint MaxPerSetDescriptors;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxMemoryAllocationSize")]
        public ulong MaxMemoryAllocationSize;
    }
}
