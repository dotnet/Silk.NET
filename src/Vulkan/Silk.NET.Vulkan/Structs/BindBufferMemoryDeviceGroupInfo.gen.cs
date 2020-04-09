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
    public unsafe struct BindBufferMemoryDeviceGroupInfo
    {
        public BindBufferMemoryDeviceGroupInfo
        (
            StructureType sType = StructureType.BindBufferMemoryDeviceGroupInfo,
            void* pNext = default,
            uint deviceIndexCount = default,
            uint* pDeviceIndices = default
        )
        {
           SType = sType;
           PNext = pNext;
           DeviceIndexCount = deviceIndexCount;
           PDeviceIndices = pDeviceIndices;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint DeviceIndexCount;
/// <summary></summary>
        public uint* PDeviceIndices;
    }
}
