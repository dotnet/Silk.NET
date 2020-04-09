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
    public unsafe struct PhysicalDeviceMaintenance3Properties
    {
        public PhysicalDeviceMaintenance3Properties
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxPerSetDescriptors;
/// <summary></summary>
        public ulong MaxMemoryAllocationSize;
    }
}
