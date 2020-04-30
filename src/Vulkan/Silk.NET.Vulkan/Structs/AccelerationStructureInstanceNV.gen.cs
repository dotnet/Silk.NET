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
    public unsafe struct AccelerationStructureInstanceNV
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
        public TransformMatrixKHR Transform;
/// <summary></summary>
        public uint InstanceCustomIndex;
/// <summary></summary>
        public uint Mask;
/// <summary></summary>
        public uint InstanceShaderBindingTableRecordOffset;
/// <summary></summary>
        public GeometryInstanceFlagsKHR Flags;
/// <summary></summary>
        public ulong AccelerationStructureReference;
    }
}
