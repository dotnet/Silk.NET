// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxDrawMeshTasksCount;
/// <summary></summary>
        public uint MaxTaskWorkGroupInvocations;
        /// <summary></summary>
       public fixed uint MaxTaskWorkGroupSize[3];
/// <summary></summary>
        public uint MaxTaskTotalMemorySize;
/// <summary></summary>
        public uint MaxTaskOutputCount;
/// <summary></summary>
        public uint MaxMeshWorkGroupInvocations;
        /// <summary></summary>
       public fixed uint MaxMeshWorkGroupSize[3];
/// <summary></summary>
        public uint MaxMeshTotalMemorySize;
/// <summary></summary>
        public uint MaxMeshOutputVertices;
/// <summary></summary>
        public uint MaxMeshOutputPrimitives;
/// <summary></summary>
        public uint MaxMeshMultiviewViewCount;
/// <summary></summary>
        public uint MeshOutputPerVertexGranularity;
/// <summary></summary>
        public uint MeshOutputPerPrimitiveGranularity;
    }
}
