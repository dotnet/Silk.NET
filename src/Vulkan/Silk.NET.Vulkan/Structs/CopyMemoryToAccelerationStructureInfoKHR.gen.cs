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
    public unsafe struct CopyMemoryToAccelerationStructureInfoKHR
    {
        public CopyMemoryToAccelerationStructureInfoKHR
        (
            StructureType sType = StructureType.CopyMemoryToAccelerationStructureInfoKhr,
            void* pNext = default,
            DeviceOrHostAddressConstKHR src = default,
            AccelerationStructureKHR dst = default,
            CopyAccelerationStructureModeKHR mode = default
        )
        {
           SType = sType;
           PNext = pNext;
           Src = src;
           Dst = dst;
           Mode = mode;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DeviceOrHostAddressConstKHR Src;
/// <summary></summary>
        public AccelerationStructureKHR Dst;
/// <summary></summary>
        public CopyAccelerationStructureModeKHR Mode;
    }
}
