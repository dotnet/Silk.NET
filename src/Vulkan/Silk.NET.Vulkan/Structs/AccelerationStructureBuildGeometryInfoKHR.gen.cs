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
    public unsafe struct AccelerationStructureBuildGeometryInfoKHR
    {
        public AccelerationStructureBuildGeometryInfoKHR
        (
            StructureType sType = StructureType.AccelerationStructureBuildGeometryInfoKhr,
            void* pNext = default,
            AccelerationStructureTypeKHR type = default,
            BuildAccelerationStructureFlagsKHR flags = default,
            Bool32 update = default,
            AccelerationStructureKHR srcAccelerationStructure = default,
            AccelerationStructureKHR dstAccelerationStructure = default,
            Bool32 geometryArrayOfPointers = default,
            uint geometryCount = default,
            AccelerationStructureGeometryKHR** ppGeometries = default,
            DeviceOrHostAddressKHR scratchData = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
           Flags = flags;
           Update = update;
           SrcAccelerationStructure = srcAccelerationStructure;
           DstAccelerationStructure = dstAccelerationStructure;
           GeometryArrayOfPointers = geometryArrayOfPointers;
           GeometryCount = geometryCount;
           PpGeometries = ppGeometries;
           ScratchData = scratchData;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccelerationStructureTypeKHR Type;
/// <summary></summary>
        public BuildAccelerationStructureFlagsKHR Flags;
/// <summary></summary>
        public Bool32 Update;
/// <summary></summary>
        public AccelerationStructureKHR SrcAccelerationStructure;
/// <summary></summary>
        public AccelerationStructureKHR DstAccelerationStructure;
/// <summary></summary>
        public Bool32 GeometryArrayOfPointers;
/// <summary></summary>
        public uint GeometryCount;
/// <summary></summary>
        public AccelerationStructureGeometryKHR** PpGeometries;
/// <summary></summary>
        public DeviceOrHostAddressKHR ScratchData;
    }
}
