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
    public unsafe struct BindAccelerationStructureMemoryInfoKHR
    {
        public BindAccelerationStructureMemoryInfoKHR
        (
            StructureType sType = StructureType.BindAccelerationStructureMemoryInfoKhr,
            void* pNext = default,
            AccelerationStructureKHR accelerationStructure = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default,
            uint deviceIndexCount = default,
            uint* pDeviceIndices = default
        )
        {
           SType = sType;
           PNext = pNext;
           AccelerationStructure = accelerationStructure;
           Memory = memory;
           MemoryOffset = memoryOffset;
           DeviceIndexCount = deviceIndexCount;
           PDeviceIndices = pDeviceIndices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccelerationStructureKHR AccelerationStructure;
/// <summary></summary>
        public DeviceMemory Memory;
/// <summary></summary>
        public ulong MemoryOffset;
/// <summary></summary>
        public uint DeviceIndexCount;
/// <summary></summary>
        public uint* PDeviceIndices;
    }
}
