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
    [NativeName("Name", "VkPhysicalDeviceDriverPropertiesKHR")]
    public unsafe struct PhysicalDeviceDriverPropertiesKHR
    {
        public PhysicalDeviceDriverPropertiesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceDriverProperties,
            void* pNext = default,
            DriverId driverID = default,
            ConformanceVersion conformanceVersion = default
        )
        {
           SType = sType;
           PNext = pNext;
           DriverID = driverID;
           ConformanceVersion = conformanceVersion;
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
        [NativeName("Type", "VkDriverId")]
        [NativeName("Type.Name", "VkDriverId")]
        [NativeName("Name", "driverID")]
        public DriverId DriverID;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "driverName")]
        public fixed byte DriverName[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "driverInfo")]
        public fixed byte DriverInfo[256];
/// <summary></summary>
        [NativeName("Type", "VkConformanceVersion")]
        [NativeName("Type.Name", "VkConformanceVersion")]
        [NativeName("Name", "conformanceVersion")]
        public ConformanceVersion ConformanceVersion;
    }
}
