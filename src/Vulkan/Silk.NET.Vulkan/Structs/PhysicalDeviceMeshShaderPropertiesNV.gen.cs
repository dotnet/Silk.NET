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
    [NativeName("Name", "VkPhysicalDeviceMeshShaderPropertiesNV")]
    public unsafe partial struct PhysicalDeviceMeshShaderPropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMeshShaderPropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceMeshShaderPropertiesNV,
            void* pNext = null,
            uint? maxDrawMeshTasksCount = null,
            uint? maxTaskWorkGroupInvocations = null,
            uint? maxTaskTotalMemorySize = null,
            uint? maxTaskOutputCount = null,
            uint? maxMeshWorkGroupInvocations = null,
            uint? maxMeshTotalMemorySize = null,
            uint? maxMeshOutputVertices = null,
            uint? maxMeshOutputPrimitives = null,
            uint? maxMeshMultiviewViewCount = null,
            uint? meshOutputPerVertexGranularity = null,
            uint? meshOutputPerPrimitiveGranularity = null
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

            if (maxDrawMeshTasksCount is not null)
            {
                MaxDrawMeshTasksCount = maxDrawMeshTasksCount.Value;
            }

            if (maxTaskWorkGroupInvocations is not null)
            {
                MaxTaskWorkGroupInvocations = maxTaskWorkGroupInvocations.Value;
            }

            if (maxTaskTotalMemorySize is not null)
            {
                MaxTaskTotalMemorySize = maxTaskTotalMemorySize.Value;
            }

            if (maxTaskOutputCount is not null)
            {
                MaxTaskOutputCount = maxTaskOutputCount.Value;
            }

            if (maxMeshWorkGroupInvocations is not null)
            {
                MaxMeshWorkGroupInvocations = maxMeshWorkGroupInvocations.Value;
            }

            if (maxMeshTotalMemorySize is not null)
            {
                MaxMeshTotalMemorySize = maxMeshTotalMemorySize.Value;
            }

            if (maxMeshOutputVertices is not null)
            {
                MaxMeshOutputVertices = maxMeshOutputVertices.Value;
            }

            if (maxMeshOutputPrimitives is not null)
            {
                MaxMeshOutputPrimitives = maxMeshOutputPrimitives.Value;
            }

            if (maxMeshMultiviewViewCount is not null)
            {
                MaxMeshMultiviewViewCount = maxMeshMultiviewViewCount.Value;
            }

            if (meshOutputPerVertexGranularity is not null)
            {
                MeshOutputPerVertexGranularity = meshOutputPerVertexGranularity.Value;
            }

            if (meshOutputPerPrimitiveGranularity is not null)
            {
                MeshOutputPerPrimitiveGranularity = meshOutputPerPrimitiveGranularity.Value;
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
        [NativeName("Name", "maxDrawMeshTasksCount")]
        public uint MaxDrawMeshTasksCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskWorkGroupInvocations")]
        public uint MaxTaskWorkGroupInvocations;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskWorkGroupSize")]
        public fixed uint MaxTaskWorkGroupSize[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskTotalMemorySize")]
        public uint MaxTaskTotalMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskOutputCount")]
        public uint MaxTaskOutputCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshWorkGroupInvocations")]
        public uint MaxMeshWorkGroupInvocations;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshWorkGroupSize")]
        public fixed uint MaxMeshWorkGroupSize[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshTotalMemorySize")]
        public uint MaxMeshTotalMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshOutputVertices")]
        public uint MaxMeshOutputVertices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshOutputPrimitives")]
        public uint MaxMeshOutputPrimitives;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshMultiviewViewCount")]
        public uint MaxMeshMultiviewViewCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "meshOutputPerVertexGranularity")]
        public uint MeshOutputPerVertexGranularity;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "meshOutputPerPrimitiveGranularity")]
        public uint MeshOutputPerPrimitiveGranularity;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMeshShaderPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
