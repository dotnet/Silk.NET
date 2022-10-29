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
    [NativeName("Name", "VkPhysicalDeviceMeshShaderPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceMeshShaderPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMeshShaderPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceMeshShaderPropertiesExt,
            void* pNext = null,
            uint? maxTaskWorkGroupTotalCount = null,
            uint? maxTaskWorkGroupInvocations = null,
            uint? maxTaskPayloadSize = null,
            uint? maxTaskSharedMemorySize = null,
            uint? maxTaskPayloadAndSharedMemorySize = null,
            uint? maxMeshWorkGroupTotalCount = null,
            uint? maxMeshWorkGroupInvocations = null,
            uint? maxMeshSharedMemorySize = null,
            uint? maxMeshPayloadAndSharedMemorySize = null,
            uint? maxMeshOutputMemorySize = null,
            uint? maxMeshPayloadAndOutputMemorySize = null,
            uint? maxMeshOutputComponents = null,
            uint? maxMeshOutputVertices = null,
            uint? maxMeshOutputPrimitives = null,
            uint? maxMeshOutputLayers = null,
            uint? maxMeshMultiviewViewCount = null,
            uint? meshOutputPerVertexGranularity = null,
            uint? meshOutputPerPrimitiveGranularity = null,
            uint? maxPreferredTaskWorkGroupInvocations = null,
            uint? maxPreferredMeshWorkGroupInvocations = null,
            Bool32? prefersLocalInvocationVertexOutput = null,
            Bool32? prefersLocalInvocationPrimitiveOutput = null,
            Bool32? prefersCompactVertexOutput = null,
            Bool32? prefersCompactPrimitiveOutput = null
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

            if (maxTaskWorkGroupTotalCount is not null)
            {
                MaxTaskWorkGroupTotalCount = maxTaskWorkGroupTotalCount.Value;
            }

            if (maxTaskWorkGroupInvocations is not null)
            {
                MaxTaskWorkGroupInvocations = maxTaskWorkGroupInvocations.Value;
            }

            if (maxTaskPayloadSize is not null)
            {
                MaxTaskPayloadSize = maxTaskPayloadSize.Value;
            }

            if (maxTaskSharedMemorySize is not null)
            {
                MaxTaskSharedMemorySize = maxTaskSharedMemorySize.Value;
            }

            if (maxTaskPayloadAndSharedMemorySize is not null)
            {
                MaxTaskPayloadAndSharedMemorySize = maxTaskPayloadAndSharedMemorySize.Value;
            }

            if (maxMeshWorkGroupTotalCount is not null)
            {
                MaxMeshWorkGroupTotalCount = maxMeshWorkGroupTotalCount.Value;
            }

            if (maxMeshWorkGroupInvocations is not null)
            {
                MaxMeshWorkGroupInvocations = maxMeshWorkGroupInvocations.Value;
            }

            if (maxMeshSharedMemorySize is not null)
            {
                MaxMeshSharedMemorySize = maxMeshSharedMemorySize.Value;
            }

            if (maxMeshPayloadAndSharedMemorySize is not null)
            {
                MaxMeshPayloadAndSharedMemorySize = maxMeshPayloadAndSharedMemorySize.Value;
            }

            if (maxMeshOutputMemorySize is not null)
            {
                MaxMeshOutputMemorySize = maxMeshOutputMemorySize.Value;
            }

            if (maxMeshPayloadAndOutputMemorySize is not null)
            {
                MaxMeshPayloadAndOutputMemorySize = maxMeshPayloadAndOutputMemorySize.Value;
            }

            if (maxMeshOutputComponents is not null)
            {
                MaxMeshOutputComponents = maxMeshOutputComponents.Value;
            }

            if (maxMeshOutputVertices is not null)
            {
                MaxMeshOutputVertices = maxMeshOutputVertices.Value;
            }

            if (maxMeshOutputPrimitives is not null)
            {
                MaxMeshOutputPrimitives = maxMeshOutputPrimitives.Value;
            }

            if (maxMeshOutputLayers is not null)
            {
                MaxMeshOutputLayers = maxMeshOutputLayers.Value;
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

            if (maxPreferredTaskWorkGroupInvocations is not null)
            {
                MaxPreferredTaskWorkGroupInvocations = maxPreferredTaskWorkGroupInvocations.Value;
            }

            if (maxPreferredMeshWorkGroupInvocations is not null)
            {
                MaxPreferredMeshWorkGroupInvocations = maxPreferredMeshWorkGroupInvocations.Value;
            }

            if (prefersLocalInvocationVertexOutput is not null)
            {
                PrefersLocalInvocationVertexOutput = prefersLocalInvocationVertexOutput.Value;
            }

            if (prefersLocalInvocationPrimitiveOutput is not null)
            {
                PrefersLocalInvocationPrimitiveOutput = prefersLocalInvocationPrimitiveOutput.Value;
            }

            if (prefersCompactVertexOutput is not null)
            {
                PrefersCompactVertexOutput = prefersCompactVertexOutput.Value;
            }

            if (prefersCompactPrimitiveOutput is not null)
            {
                PrefersCompactPrimitiveOutput = prefersCompactPrimitiveOutput.Value;
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
        [NativeName("Name", "maxTaskWorkGroupTotalCount")]
        public uint MaxTaskWorkGroupTotalCount;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskWorkGroupCount")]
        public fixed uint MaxTaskWorkGroupCount[3];
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
        [NativeName("Name", "maxTaskPayloadSize")]
        public uint MaxTaskPayloadSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskSharedMemorySize")]
        public uint MaxTaskSharedMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTaskPayloadAndSharedMemorySize")]
        public uint MaxTaskPayloadAndSharedMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshWorkGroupTotalCount")]
        public uint MaxMeshWorkGroupTotalCount;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshWorkGroupCount")]
        public fixed uint MaxMeshWorkGroupCount[3];
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
        [NativeName("Name", "maxMeshSharedMemorySize")]
        public uint MaxMeshSharedMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshPayloadAndSharedMemorySize")]
        public uint MaxMeshPayloadAndSharedMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshOutputMemorySize")]
        public uint MaxMeshOutputMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshPayloadAndOutputMemorySize")]
        public uint MaxMeshPayloadAndOutputMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMeshOutputComponents")]
        public uint MaxMeshOutputComponents;
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
        [NativeName("Name", "maxMeshOutputLayers")]
        public uint MaxMeshOutputLayers;
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
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPreferredTaskWorkGroupInvocations")]
        public uint MaxPreferredTaskWorkGroupInvocations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPreferredMeshWorkGroupInvocations")]
        public uint MaxPreferredMeshWorkGroupInvocations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "prefersLocalInvocationVertexOutput")]
        public Bool32 PrefersLocalInvocationVertexOutput;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "prefersLocalInvocationPrimitiveOutput")]
        public Bool32 PrefersLocalInvocationPrimitiveOutput;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "prefersCompactVertexOutput")]
        public Bool32 PrefersCompactVertexOutput;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "prefersCompactPrimitiveOutput")]
        public Bool32 PrefersCompactPrimitiveOutput;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMeshShaderPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
