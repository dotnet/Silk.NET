// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDriverPropertiesKHR")]
    public unsafe partial struct PhysicalDeviceDriverPropertiesKHR
    {
        public PhysicalDeviceDriverPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceDriverProperties,
            void* pNext = null,
            DriverId? driverID = null,
            ConformanceVersion? conformanceVersion = null
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

            if (driverID is not null)
            {
                DriverID = driverID.Value;
            }

            if (conformanceVersion is not null)
            {
                ConformanceVersion = conformanceVersion.Value;
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
