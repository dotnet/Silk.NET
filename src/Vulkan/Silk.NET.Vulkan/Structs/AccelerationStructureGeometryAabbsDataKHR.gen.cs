// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureGeometryAabbsDataKHR")]
    public unsafe partial struct AccelerationStructureGeometryAabbsDataKHR
    {
        public AccelerationStructureGeometryAabbsDataKHR
        (
            StructureType sType = StructureType.AccelerationStructureGeometryAabbsDataKhr,
            void* pNext = default,
            DeviceOrHostAddressConstKHR data = default,
            ulong stride = default
        )
        {
            SType = sType;
            PNext = pNext;
            Data = data;
            Stride = stride;
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
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "data")]
        public DeviceOrHostAddressConstKHR Data;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "stride")]
        public ulong Stride;
    }
}
