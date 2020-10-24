// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureCreateInfoKHR")]
    public unsafe partial struct AccelerationStructureCreateInfoKHR
    {
        public AccelerationStructureCreateInfoKHR
        (
            StructureType? sType = StructureType.AccelerationStructureCreateInfoKhr,
            void* pNext = null,
            ulong? compactedSize = null,
            AccelerationStructureTypeKHR? type = null,
            BuildAccelerationStructureFlagsKHR? flags = null,
            uint? maxGeometryCount = null,
            AccelerationStructureCreateGeometryTypeInfoKHR* pGeometryInfos = null,
            ulong? deviceAddress = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (compactedSize is not null)
            {
                CompactedSize = compactedSize.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (maxGeometryCount is not null)
            {
                MaxGeometryCount = maxGeometryCount.Value;
            }

            if (pGeometryInfos is not null)
            {
                PGeometryInfos = pGeometryInfos;
            }

            if (deviceAddress is not null)
            {
                DeviceAddress = deviceAddress.Value;
            }
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
