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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkAccelerationStructureGeometryDataKHR")]
    public unsafe partial struct AccelerationStructureGeometryDataKHR
    {
        public AccelerationStructureGeometryDataKHR
        (
            AccelerationStructureGeometryTrianglesDataKHR? triangles = null,
            AccelerationStructureGeometryAabbsDataKHR? aabbs = null,
            AccelerationStructureGeometryInstancesDataKHR? instances = null
        ) : this()
        {
            if (triangles is not null)
            {
                Triangles = triangles.Value;
            }

            if (aabbs is not null)
            {
                Aabbs = aabbs.Value;
            }

            if (instances is not null)
            {
                Instances = instances.Value;
            }
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
