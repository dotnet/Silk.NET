// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceGroupDeviceCreateInfoKHR")]
    public unsafe partial struct DeviceGroupDeviceCreateInfoKHR
    {
        public DeviceGroupDeviceCreateInfoKHR
        (
            StructureType? sType = StructureType.DeviceGroupDeviceCreateInfo,
            void* pNext = null,
            uint? physicalDeviceCount = null,
            PhysicalDevice* pPhysicalDevices = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (physicalDeviceCount is not null)
            {
                PhysicalDeviceCount = physicalDeviceCount.Value;
            }

            if (pPhysicalDevices is not null)
            {
                PPhysicalDevices = pPhysicalDevices;
            }
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
        [NativeName("Name", "physicalDeviceCount")]
        public uint PhysicalDeviceCount;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice*")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "pPhysicalDevices")]
        public PhysicalDevice* PPhysicalDevices;
    }
}
