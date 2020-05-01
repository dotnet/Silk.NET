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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Format VertexFormat;
/// <summary></summary>
        public DeviceOrHostAddressConstKHR VertexData;
/// <summary></summary>
        public ulong VertexStride;
/// <summary></summary>
        public IndexType IndexType;
/// <summary></summary>
        public DeviceOrHostAddressConstKHR IndexData;
/// <summary></summary>
        public DeviceOrHostAddressConstKHR TransformData;
    }
}
