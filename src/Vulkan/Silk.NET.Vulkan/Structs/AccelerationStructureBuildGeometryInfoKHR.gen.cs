// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureBuildGeometryInfoKHR")]
    public unsafe partial struct AccelerationStructureBuildGeometryInfoKHR
    {
        public AccelerationStructureBuildGeometryInfoKHR
        (
            StructureType? sType = StructureType.AccelerationStructureBuildGeometryInfoKhr,
            void* pNext = null,
            AccelerationStructureTypeKHR? type = null,
            BuildAccelerationStructureFlagsKHR? flags = null,
            BuildAccelerationStructureModeKHR? mode = null,
            AccelerationStructureKHR? srcAccelerationStructure = null,
            AccelerationStructureKHR? dstAccelerationStructure = null,
            uint? geometryCount = null,
            AccelerationStructureGeometryKHR* pGeometries = null,
            AccelerationStructureGeometryKHR** ppGeometries = null,
            DeviceOrHostAddressKHR? scratchData = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (srcAccelerationStructure is not null)
            {
                SrcAccelerationStructure = srcAccelerationStructure.Value;
            }

            if (dstAccelerationStructure is not null)
            {
                DstAccelerationStructure = dstAccelerationStructure.Value;
            }

            if (geometryCount is not null)
            {
                GeometryCount = geometryCount.Value;
            }

            if (pGeometries is not null)
            {
                PGeometries = pGeometries;
            }

            if (ppGeometries is not null)
            {
                PpGeometries = ppGeometries;
            }

            if (scratchData is not null)
            {
                ScratchData = scratchData.Value;
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
        [NativeName("Type", "VkBuildAccelerationStructureModeKHR")]
        [NativeName("Type.Name", "VkBuildAccelerationStructureModeKHR")]
        [NativeName("Name", "mode")]
        public BuildAccelerationStructureModeKHR Mode;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "geometryCount")]
        public uint GeometryCount;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureGeometryKHR*")]
        [NativeName("Type.Name", "VkAccelerationStructureGeometryKHR")]
        [NativeName("Name", "pGeometries")]
        public AccelerationStructureGeometryKHR* PGeometries;
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
