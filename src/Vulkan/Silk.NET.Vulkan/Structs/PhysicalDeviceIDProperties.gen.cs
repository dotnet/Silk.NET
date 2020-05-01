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
    public unsafe struct PhysicalDeviceIDProperties
    {
        public PhysicalDeviceIDProperties
        (
            StructureType sType = StructureType.PhysicalDeviceIDProperties,
            void* pNext = default,
            uint deviceNodeMask = default,
            Bool32 deviceLuidvalid = default
        )
        {
           SType = sType;
           PNext = pNext;
           DeviceNodeMask = deviceNodeMask;
           DeviceLuidvalid = deviceLuidvalid;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
        /// <summary></summary>
       public fixed byte DeviceUuid[16];
        /// <summary></summary>
       public fixed byte DriverUuid[16];
        /// <summary></summary>
       public fixed byte DeviceLuid[8];
/// <summary></summary>
        public uint DeviceNodeMask;
/// <summary></summary>
        public Bool32 DeviceLuidvalid;
    }
}
