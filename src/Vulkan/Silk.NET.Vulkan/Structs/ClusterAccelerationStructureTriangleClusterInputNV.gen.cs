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
    [NativeName("Name", "VkClusterAccelerationStructureTriangleClusterInputNV")]
    public unsafe partial struct ClusterAccelerationStructureTriangleClusterInputNV : IChainable
    {
        public ClusterAccelerationStructureTriangleClusterInputNV
        (
            StructureType? sType = StructureType.ClusterAccelerationStructureTriangleClusterInputNV,
            void* pNext = null,
            Format? vertexFormat = null,
            uint? maxGeometryIndexValue = null,
            uint? maxClusterUniqueGeometryCount = null,
            uint? maxClusterTriangleCount = null,
            uint? maxClusterVertexCount = null,
            uint? maxTotalTriangleCount = null,
            uint? maxTotalVertexCount = null,
            uint? minPositionTruncateBitCount = null
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

            if (vertexFormat is not null)
            {
                VertexFormat = vertexFormat.Value;
            }

            if (maxGeometryIndexValue is not null)
            {
                MaxGeometryIndexValue = maxGeometryIndexValue.Value;
            }

            if (maxClusterUniqueGeometryCount is not null)
            {
                MaxClusterUniqueGeometryCount = maxClusterUniqueGeometryCount.Value;
            }

            if (maxClusterTriangleCount is not null)
            {
                MaxClusterTriangleCount = maxClusterTriangleCount.Value;
            }

            if (maxClusterVertexCount is not null)
            {
                MaxClusterVertexCount = maxClusterVertexCount.Value;
            }

            if (maxTotalTriangleCount is not null)
            {
                MaxTotalTriangleCount = maxTotalTriangleCount.Value;
            }

            if (maxTotalVertexCount is not null)
            {
                MaxTotalVertexCount = maxTotalVertexCount.Value;
            }

            if (minPositionTruncateBitCount is not null)
            {
                MinPositionTruncateBitCount = minPositionTruncateBitCount.Value;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "vertexFormat")]
        public Format VertexFormat;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxGeometryIndexValue")]
        public uint MaxGeometryIndexValue;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxClusterUniqueGeometryCount")]
        public uint MaxClusterUniqueGeometryCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxClusterTriangleCount")]
        public uint MaxClusterTriangleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxClusterVertexCount")]
        public uint MaxClusterVertexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTotalTriangleCount")]
        public uint MaxTotalTriangleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTotalVertexCount")]
        public uint MaxTotalVertexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minPositionTruncateBitCount")]
        public uint MinPositionTruncateBitCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ClusterAccelerationStructureTriangleClusterInputNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
