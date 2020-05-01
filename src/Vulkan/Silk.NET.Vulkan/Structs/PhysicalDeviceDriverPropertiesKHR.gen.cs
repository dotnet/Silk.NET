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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DriverId DriverID;
        /// <summary></summary>
       public fixed byte DriverName[256];
        /// <summary></summary>
       public fixed byte DriverInfo[256];
/// <summary></summary>
        public ConformanceVersion ConformanceVersion;
    }
}
