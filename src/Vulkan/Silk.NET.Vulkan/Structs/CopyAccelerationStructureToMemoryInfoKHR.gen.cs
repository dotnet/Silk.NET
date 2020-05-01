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
    public unsafe struct CopyAccelerationStructureToMemoryInfoKHR
    {
        public CopyAccelerationStructureToMemoryInfoKHR
        (
            StructureType sType = StructureType.CopyAccelerationStructureToMemoryInfoKhr,
            void* pNext = default,
            AccelerationStructureKHR src = default,
            DeviceOrHostAddressKHR dst = default,
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
        public AccelerationStructureKHR Src;
/// <summary></summary>
        public DeviceOrHostAddressKHR Dst;
/// <summary></summary>
        public CopyAccelerationStructureModeKHR Mode;
    }
}
