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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong CompactedSize;
/// <summary></summary>
        public AccelerationStructureTypeKHR Type;
/// <summary></summary>
        public BuildAccelerationStructureFlagsKHR Flags;
/// <summary></summary>
        public uint MaxGeometryCount;
/// <summary></summary>
        public AccelerationStructureCreateGeometryTypeInfoKHR* PGeometryInfos;
/// <summary></summary>
        public ulong DeviceAddress;
    }
}
