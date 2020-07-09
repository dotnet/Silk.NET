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
    [NativeName("Name", "VkAccelerationStructureCreateInfoKHR")]
    public unsafe struct AccelerationStructureCreateInfoKHR
    {
        public AccelerationStructureCreateInfoKHR
        (
            StructureType sType = StructureType.AccelerationStructureCreateInfoKhr,
            void* pNext = default,
            ulong compactedSize = default,
            AccelerationStructureTypeKHR type = default,
            BuildAccelerationStructureFlagsKHR flags = default,
            uint maxGeometryCount = default,
            AccelerationStructureCreateGeometryTypeInfoKHR* pGeometryInfos = default,
            ulong deviceAddress = default
        )
        {
           SType = sType;
           PNext = pNext;
           CompactedSize = compactedSize;
           Type = type;
           Flags = flags;
           MaxGeometryCount = maxGeometryCount;
           PGeometryInfos = pGeometryInfos;
           DeviceAddress = deviceAddress;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "compactedSize")]
        public ulong CompactedSize;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureTypeKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureTypeKHR")]
        [NativeName("Name", "type")]
        public AccelerationStructureTypeKHR Type;
/// <summary></summary>
        [NativeName("Type", "VkBuildAccelerationStructureFlagsKHR")]
        [NativeName("Type.Name", "VkBuildAccelerationStructureFlagsKHR")]
        [NativeName("Name", "flags")]
        public BuildAccelerationStructureFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryCount")]
        public uint MaxGeometryCount;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureCreateGeometryTypeInfoKHR*")]
        [NativeName("Type.Name", "VkAccelerationStructureCreateGeometryTypeInfoKHR")]
        [NativeName("Name", "pGeometryInfos")]
        public AccelerationStructureCreateGeometryTypeInfoKHR* PGeometryInfos;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "deviceAddress")]
        public ulong DeviceAddress;
    }
}
