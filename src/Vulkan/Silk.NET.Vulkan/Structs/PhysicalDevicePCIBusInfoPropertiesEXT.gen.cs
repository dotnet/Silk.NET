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
    public unsafe struct PhysicalDevicePCIBusInfoPropertiesEXT
    {
        public PhysicalDevicePCIBusInfoPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDevicePciBusInfoPropertiesExt,
            void* pNext = default,
            uint pciDomain = default,
            uint pciBus = default,
            uint pciDevice = default,
            uint pciFunction = default
        )
        {
           SType = sType;
           PNext = pNext;
           PciDomain = pciDomain;
           PciBus = pciBus;
           PciDevice = pciDevice;
           PciFunction = pciFunction;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint PciDomain;
/// <summary></summary>
        public uint PciBus;
/// <summary></summary>
        public uint PciDevice;
/// <summary></summary>
        public uint PciFunction;
    }
}
