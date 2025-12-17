// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "VkClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV")]
    public unsafe partial struct ClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV
    {
        public ClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV
        (
            uint? clusterID = null,
            ClusterAccelerationStructureClusterFlagsNV? clusterFlags = null,
            uint? triangleCount = null,
            uint? vertexCount = null,
            uint? positionTruncateBitCount = null,
            uint? indexType = null,
            uint? opacityMicromapIndexType = null,
            ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV? baseGeometryIndexAndGeometryFlags = null,
            ushort? indexBufferStride = null,
            ushort? vertexBufferStride = null,
            ushort? geometryIndexAndFlagsBufferStride = null,
            ushort? opacityMicromapIndexBufferStride = null,
            ulong? indexBuffer = null,
            ulong? vertexBuffer = null,
            ulong? geometryIndexAndFlagsBuffer = null,
            ulong? opacityMicromapArray = null,
            ulong? opacityMicromapIndexBuffer = null,
            ulong? instantiationBoundingBoxLimit = null
        ) : this()
        {
            if (clusterID is not null)
            {
                ClusterID = clusterID.Value;
            }

            if (clusterFlags is not null)
            {
                ClusterFlags = clusterFlags.Value;
            }

            if (triangleCount is not null)
            {
                TriangleCount = triangleCount.Value;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }

            if (positionTruncateBitCount is not null)
            {
                PositionTruncateBitCount = positionTruncateBitCount.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }

            if (opacityMicromapIndexType is not null)
            {
                OpacityMicromapIndexType = opacityMicromapIndexType.Value;
            }

            if (baseGeometryIndexAndGeometryFlags is not null)
            {
                BaseGeometryIndexAndGeometryFlags = baseGeometryIndexAndGeometryFlags.Value;
            }

            if (indexBufferStride is not null)
            {
                IndexBufferStride = indexBufferStride.Value;
            }

            if (vertexBufferStride is not null)
            {
                VertexBufferStride = vertexBufferStride.Value;
            }

            if (geometryIndexAndFlagsBufferStride is not null)
            {
                GeometryIndexAndFlagsBufferStride = geometryIndexAndFlagsBufferStride.Value;
            }

            if (opacityMicromapIndexBufferStride is not null)
            {
                OpacityMicromapIndexBufferStride = opacityMicromapIndexBufferStride.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer.Value;
            }

            if (geometryIndexAndFlagsBuffer is not null)
            {
                GeometryIndexAndFlagsBuffer = geometryIndexAndFlagsBuffer.Value;
            }

            if (opacityMicromapArray is not null)
            {
                OpacityMicromapArray = opacityMicromapArray.Value;
            }

            if (opacityMicromapIndexBuffer is not null)
            {
                OpacityMicromapIndexBuffer = opacityMicromapIndexBuffer.Value;
            }

            if (instantiationBoundingBoxLimit is not null)
            {
                InstantiationBoundingBoxLimit = instantiationBoundingBoxLimit.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterID")]
        public uint ClusterID;
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureClusterFlagsNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureClusterFlagsNV")]
        [NativeName("Name", "clusterFlags")]
        public ClusterAccelerationStructureClusterFlagsNV ClusterFlags;

        private uint _bitfield1;

        public uint TriangleCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1FFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1FFu) | (uint)((uint)(value) & 0x1FFu));
        }

        public uint VertexCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1FFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1FFu << 9)) | (uint)(((uint)(value) & 0x1FFu) << 9));
        }

        public uint PositionTruncateBitCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0x3Fu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x3Fu << 18)) | (uint)(((uint)(value) & 0x3Fu) << 18));
        }

        public uint IndexType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0xFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFu << 24)) | (uint)(((uint)(value) & 0xFu) << 24));
        }

        public uint OpacityMicromapIndexType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 28) & 0xFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFu << 28)) | (uint)(((uint)(value) & 0xFu) << 28));
        }
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV")]
        [NativeName("Name", "baseGeometryIndexAndGeometryFlags")]
        public ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV BaseGeometryIndexAndGeometryFlags;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "indexBufferStride")]
        public ushort IndexBufferStride;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "vertexBufferStride")]
        public ushort VertexBufferStride;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "geometryIndexAndFlagsBufferStride")]
        public ushort GeometryIndexAndFlagsBufferStride;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "opacityMicromapIndexBufferStride")]
        public ushort OpacityMicromapIndexBufferStride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "indexBuffer")]
        public ulong IndexBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "vertexBuffer")]
        public ulong VertexBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "geometryIndexAndFlagsBuffer")]
        public ulong GeometryIndexAndFlagsBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "opacityMicromapArray")]
        public ulong OpacityMicromapArray;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "opacityMicromapIndexBuffer")]
        public ulong OpacityMicromapIndexBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "instantiationBoundingBoxLimit")]
        public ulong InstantiationBoundingBoxLimit;
    }
}
