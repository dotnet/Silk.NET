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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkAccelerationStructureGeometryDataKHR")]
    public unsafe struct AccelerationStructureGeometryDataKHR
    {
        public AccelerationStructureGeometryDataKHR
        (
            AccelerationStructureGeometryTrianglesDataKHR triangles = default,
            AccelerationStructureGeometryAabbsDataKHR aabbs = default,
            AccelerationStructureGeometryInstancesDataKHR instances = default
        )
        {
           Triangles = triangles;
           Aabbs = aabbs;
           Instances = instances;
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkAccelerationStructureGeometryTrianglesDataKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureGeometryTrianglesDataKHR")]
        [NativeName("Name", "triangles")]
        public AccelerationStructureGeometryTrianglesDataKHR Triangles;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkAccelerationStructureGeometryAabbsDataKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureGeometryAabbsDataKHR")]
        [NativeName("Name", "aabbs")]
        public AccelerationStructureGeometryAabbsDataKHR Aabbs;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkAccelerationStructureGeometryInstancesDataKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureGeometryInstancesDataKHR")]
        [NativeName("Name", "instances")]
        public AccelerationStructureGeometryInstancesDataKHR Instances;
    }
}
