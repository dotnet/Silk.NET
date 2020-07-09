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
    [NativeName("Name", "VkPhysicalDeviceMeshShaderPropertiesNV")]
    public unsafe struct PhysicalDeviceMeshShaderPropertiesNV
    {
        public PhysicalDeviceMeshShaderPropertiesNV
        (
            StructureType sType = StructureType.PhysicalDeviceMeshShaderPropertiesNV,
            void* pNext = default,
            uint maxDrawMeshTasksCount = default,
            uint maxTaskWorkGroupInvocations = default,
            uint maxTaskTotalMemorySize = default,
            uint maxTaskOutputCount = default,
            uint maxMeshWorkGroupInvocations = default,
            uint maxMeshTotalMemorySize = default,
            uint maxMeshOutputVertices = default,
            uint maxMeshOutputPrimitives = default,
            uint maxMeshMultiviewViewCount = default,
            uint meshOutputPerVertexGranularity = default,
            uint meshOutputPerPrimitiveGranularity = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxDrawMeshTasksCount = maxDrawMeshTasksCount;
           MaxTaskWorkGroupInvocations = maxTaskWorkGroupInvocations;
           MaxTaskTotalMemorySize = maxTaskTotalMemorySize;
           MaxTaskOutputCount = maxTaskOutputCount;
           MaxMeshWorkGroupInvocations = maxMeshWorkGroupInvocations;
           MaxMeshTotalMemorySize = maxMeshTotalMemorySize;
           MaxMeshOutputVertices = maxMeshOutputVertices;
           MaxMeshOutputPrimitives = maxMeshOutputPrimitives;
           MaxMeshMultiviewViewCount = maxMeshMultiviewViewCount;
           MeshOutputPerVertexGranularity = meshOutputPerVertexGranularity;
           MeshOutputPerPrimitiveGranularity = meshOutputPerPrimitiveGranularity;
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
    }
}
