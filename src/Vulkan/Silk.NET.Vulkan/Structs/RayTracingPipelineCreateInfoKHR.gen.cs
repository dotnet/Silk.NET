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
    public unsafe struct RayTracingPipelineCreateInfoKHR
    {
        public RayTracingPipelineCreateInfoKHR
        (
            StructureType sType = StructureType.RayTracingPipelineCreateInfoKhr,
            void* pNext = default,
            PipelineCreateFlags flags = default,
            uint stageCount = default,
            PipelineShaderStageCreateInfo* pStages = default,
            uint groupCount = default,
            RayTracingShaderGroupCreateInfoKHR* pGroups = default,
            uint maxRecursionDepth = default,
            PipelineLibraryCreateInfoKHR libraries = default,
            RayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface = default,
            PipelineLayout layout = default,
            Pipeline basePipelineHandle = default,
            int basePipelineIndex = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           StageCount = stageCount;
           PStages = pStages;
           GroupCount = groupCount;
           PGroups = pGroups;
           MaxRecursionDepth = maxRecursionDepth;
           Libraries = libraries;
           PLibraryInterface = pLibraryInterface;
           Layout = layout;
           BasePipelineHandle = basePipelineHandle;
           BasePipelineIndex = basePipelineIndex;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineCreateFlags Flags;
/// <summary></summary>
        public uint StageCount;
/// <summary></summary>
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        public uint GroupCount;
/// <summary></summary>
        public RayTracingShaderGroupCreateInfoKHR* PGroups;
/// <summary></summary>
        public uint MaxRecursionDepth;
/// <summary></summary>
        public PipelineLibraryCreateInfoKHR Libraries;
/// <summary></summary>
        public RayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;
/// <summary></summary>
        public PipelineLayout Layout;
/// <summary></summary>
        public Pipeline BasePipelineHandle;
/// <summary></summary>
        public int BasePipelineIndex;
    }
}
