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
    [NativeName("Name", "VkAccelerationStructureBuildGeometryInfoKHR")]
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "update")]
        public Bool32 Update;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "srcAccelerationStructure")]
        public AccelerationStructureKHR SrcAccelerationStructure;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "dstAccelerationStructure")]
        public AccelerationStructureKHR DstAccelerationStructure;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "geometryArrayOfPointers")]
        public Bool32 GeometryArrayOfPointers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "geometryCount")]
        public uint GeometryCount;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureGeometryKHR**")]
        [NativeName("Type.Name", "VkAccelerationStructureGeometryKHR")]
        [NativeName("Name", "ppGeometries")]
        public AccelerationStructureGeometryKHR** PpGeometries;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressKHR")]
        [NativeName("Name", "scratchData")]
        public DeviceOrHostAddressKHR ScratchData;
    }
}
