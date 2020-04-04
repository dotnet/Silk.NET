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
    public unsafe struct WriteDescriptorSetAccelerationStructureNV
    {
        public WriteDescriptorSetAccelerationStructureNV
        (
            StructureType sType = StructureType.WriteDescriptorSetAccelerationStructureKhr,
            void* pNext = default,
            uint accelerationStructureCount = default,
            AccelerationStructureKHR* pAccelerationStructures = default
        )
        {
           SType = sType;
           PNext = pNext;
           AccelerationStructureCount = accelerationStructureCount;
           PAccelerationStructures = pAccelerationStructures;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint AccelerationStructureCount;
/// <summary></summary>
        public AccelerationStructureKHR* PAccelerationStructures;
    }
}
