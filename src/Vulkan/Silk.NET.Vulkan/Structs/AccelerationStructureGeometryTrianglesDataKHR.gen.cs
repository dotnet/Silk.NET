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
    [NativeName("Name", "VkAccelerationStructureGeometryTrianglesDataKHR")]
    public unsafe struct AccelerationStructureGeometryTrianglesDataKHR
    {
        public AccelerationStructureGeometryTrianglesDataKHR
        (
            StructureType sType = StructureType.AccelerationStructureGeometryTrianglesDataKhr,
            void* pNext = default,
            Format vertexFormat = default,
            DeviceOrHostAddressConstKHR vertexData = default,
            ulong vertexStride = default,
            IndexType indexType = default,
            DeviceOrHostAddressConstKHR indexData = default,
            DeviceOrHostAddressConstKHR transformData = default
        )
        {
           SType = sType;
           PNext = pNext;
           VertexFormat = vertexFormat;
           VertexData = vertexData;
           VertexStride = vertexStride;
           IndexType = indexType;
           IndexData = indexData;
           TransformData = transformData;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "vertexFormat")]
        public Format VertexFormat;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "vertexData")]
        public DeviceOrHostAddressConstKHR VertexData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "vertexStride")]
        public ulong VertexStride;
/// <summary></summary>
        [NativeName("Type", "VkIndexType")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "indexType")]
        public IndexType IndexType;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "indexData")]
        public DeviceOrHostAddressConstKHR IndexData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "transformData")]
        public DeviceOrHostAddressConstKHR TransformData;
    }
}
