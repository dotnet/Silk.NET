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
    [NativeName("Name", "VkAccelerationStructureInfoNV")]
    public unsafe partial struct AccelerationStructureInfoNV
    {
        public AccelerationStructureInfoNV
        (
            StructureType sType = StructureType.AccelerationStructureInfoNV,
            void* pNext = default,
            AccelerationStructureTypeNV type = default,
            BuildAccelerationStructureFlagsNV flags = default,
            uint instanceCount = default,
            uint geometryCount = default,
            GeometryNV* pGeometries = default
        )
        {
            SType = sType;
            PNext = pNext;
            Type = type;
            Flags = flags;
            InstanceCount = instanceCount;
            GeometryCount = geometryCount;
            PGeometries = pGeometries;
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
        [NativeName("Type", "VkAccelerationStructureTypeNV")]
        [NativeName("Type.Name", "VkAccelerationStructureTypeNV")]
        [NativeName("Name", "type")]
        public AccelerationStructureTypeNV Type;
/// <summary></summary>
        [NativeName("Type", "VkBuildAccelerationStructureFlagsNV")]
        [NativeName("Type.Name", "VkBuildAccelerationStructureFlagsNV")]
        [NativeName("Name", "flags")]
        public BuildAccelerationStructureFlagsNV Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCount")]
        public uint InstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "geometryCount")]
        public uint GeometryCount;
/// <summary></summary>
        [NativeName("Type", "VkGeometryNV*")]
        [NativeName("Type.Name", "VkGeometryNV")]
        [NativeName("Name", "pGeometries")]
        public GeometryNV* PGeometries;
    }
}
