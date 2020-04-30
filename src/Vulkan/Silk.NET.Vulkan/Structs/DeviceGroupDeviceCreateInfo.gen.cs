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
    public unsafe struct DeviceGroupDeviceCreateInfo
    {
        public DeviceGroupDeviceCreateInfo
        (
            StructureType sType = StructureType.DeviceGroupDeviceCreateInfo,
            void* pNext = default,
            uint physicalDeviceCount = default,
            PhysicalDevice* pPhysicalDevices = default
        )
        {
           SType = sType;
           PNext = pNext;
           PhysicalDeviceCount = physicalDeviceCount;
           PPhysicalDevices = pPhysicalDevices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint PhysicalDeviceCount;
/// <summary></summary>
        public PhysicalDevice* PPhysicalDevices;
    }
}
