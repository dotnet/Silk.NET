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
    public unsafe struct DeviceGroupBindSparseInfoKHR
    {
        public DeviceGroupBindSparseInfoKHR
        (
            StructureType sType = StructureType.DeviceGroupBindSparseInfo,
            void* pNext = default,
            uint resourceDeviceIndex = default,
            uint memoryDeviceIndex = default
        )
        {
           SType = sType;
           PNext = pNext;
           ResourceDeviceIndex = resourceDeviceIndex;
           MemoryDeviceIndex = memoryDeviceIndex;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint ResourceDeviceIndex;
/// <summary></summary>
        public uint MemoryDeviceIndex;
    }
}
