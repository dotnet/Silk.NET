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
    [NativeName("Name", "VkAccelerationStructureInstanceNV")]
    public unsafe partial struct AccelerationStructureInstanceNV
    {
        public AccelerationStructureInstanceNV
        (
            TransformMatrixKHR transform = default,
            uint instanceCustomIndex = default,
            uint mask = default,
            uint instanceShaderBindingTableRecordOffset = default,
            GeometryInstanceFlagsKHR flags = default,
            ulong accelerationStructureReference = default
        )
        {
            Transform = transform;
            InstanceCustomIndex = instanceCustomIndex;
            Mask = mask;
            InstanceShaderBindingTableRecordOffset = instanceShaderBindingTableRecordOffset;
            Flags = flags;
            AccelerationStructureReference = accelerationStructureReference;
        }

/// <summary></summary>
        [NativeName("Type", "VkTransformMatrixKHR")]
        [NativeName("Type.Name", "VkTransformMatrixKHR")]
        [NativeName("Name", "transform")]
        public TransformMatrixKHR Transform;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCustomIndex")]
        public uint InstanceCustomIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mask")]
        public uint Mask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceShaderBindingTableRecordOffset")]
        public uint InstanceShaderBindingTableRecordOffset;
/// <summary></summary>
        [NativeName("Type", "VkGeometryInstanceFlagsKHR")]
        [NativeName("Type.Name", "VkGeometryInstanceFlagsKHR")]
        [NativeName("Name", "flags")]
        public GeometryInstanceFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "accelerationStructureReference")]
        public ulong AccelerationStructureReference;
    }
}
