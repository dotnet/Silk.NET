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
    [NativeName("Name", "VkPhysicalDeviceClusterAccelerationStructurePropertiesNV")]
    public unsafe partial struct PhysicalDeviceClusterAccelerationStructurePropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceClusterAccelerationStructurePropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceClusterAccelerationStructurePropertiesNV,
            void* pNext = null,
            uint? maxVerticesPerCluster = null,
            uint? maxTrianglesPerCluster = null,
            uint? clusterScratchByteAlignment = null,
            uint? clusterByteAlignment = null,
            uint? clusterTemplateByteAlignment = null,
            uint? clusterBottomLevelByteAlignment = null,
            uint? clusterTemplateBoundsByteAlignment = null,
            uint? maxClusterGeometryIndex = null
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

            if (maxVerticesPerCluster is not null)
            {
                MaxVerticesPerCluster = maxVerticesPerCluster.Value;
            }

            if (maxTrianglesPerCluster is not null)
            {
                MaxTrianglesPerCluster = maxTrianglesPerCluster.Value;
            }

            if (clusterScratchByteAlignment is not null)
            {
                ClusterScratchByteAlignment = clusterScratchByteAlignment.Value;
            }

            if (clusterByteAlignment is not null)
            {
                ClusterByteAlignment = clusterByteAlignment.Value;
            }

            if (clusterTemplateByteAlignment is not null)
            {
                ClusterTemplateByteAlignment = clusterTemplateByteAlignment.Value;
            }

            if (clusterBottomLevelByteAlignment is not null)
            {
                ClusterBottomLevelByteAlignment = clusterBottomLevelByteAlignment.Value;
            }

            if (clusterTemplateBoundsByteAlignment is not null)
            {
                ClusterTemplateBoundsByteAlignment = clusterTemplateBoundsByteAlignment.Value;
            }

            if (maxClusterGeometryIndex is not null)
            {
                MaxClusterGeometryIndex = maxClusterGeometryIndex.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVerticesPerCluster")]
        public uint MaxVerticesPerCluster;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTrianglesPerCluster")]
        public uint MaxTrianglesPerCluster;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterScratchByteAlignment")]
        public uint ClusterScratchByteAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterByteAlignment")]
        public uint ClusterByteAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterTemplateByteAlignment")]
        public uint ClusterTemplateByteAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterBottomLevelByteAlignment")]
        public uint ClusterBottomLevelByteAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clusterTemplateBoundsByteAlignment")]
        public uint ClusterTemplateBoundsByteAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxClusterGeometryIndex")]
        public uint MaxClusterGeometryIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceClusterAccelerationStructurePropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
