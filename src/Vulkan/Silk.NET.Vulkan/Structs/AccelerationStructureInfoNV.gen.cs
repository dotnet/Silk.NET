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
    public unsafe struct AccelerationStructureInfoNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public AccelerationStructureTypeNV Type;
/// <summary></summary>
        public BuildAccelerationStructureFlagsNV Flags;
/// <summary></summary>
        public uint InstanceCount;
/// <summary></summary>
        public uint GeometryCount;
/// <summary></summary>
        public GeometryNV* PGeometries;
    }
}
