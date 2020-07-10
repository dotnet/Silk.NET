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
    [NativeName("Name", "VkRayTracingPipelineCreateInfoKHR")]
    public unsafe partial struct RayTracingPipelineCreateInfoKHR
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
        [NativeName("Type", "VkPipelineCreateFlags")]
        [NativeName("Type.Name", "VkPipelineCreateFlags")]
        [NativeName("Name", "flags")]
        public PipelineCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stageCount")]
        public uint StageCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineShaderStageCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineShaderStageCreateInfo")]
        [NativeName("Name", "pStages")]
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "groupCount")]
        public uint GroupCount;
/// <summary></summary>
        [NativeName("Type", "VkRayTracingShaderGroupCreateInfoKHR*")]
        [NativeName("Type.Name", "VkRayTracingShaderGroupCreateInfoKHR")]
        [NativeName("Name", "pGroups")]
        public RayTracingShaderGroupCreateInfoKHR* PGroups;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRecursionDepth")]
        public uint MaxRecursionDepth;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLibraryCreateInfoKHR")]
        [NativeName("Type.Name", "VkPipelineLibraryCreateInfoKHR")]
        [NativeName("Name", "libraries")]
        public PipelineLibraryCreateInfoKHR Libraries;
/// <summary></summary>
        [NativeName("Type", "VkRayTracingPipelineInterfaceCreateInfoKHR*")]
        [NativeName("Type.Name", "VkRayTracingPipelineInterfaceCreateInfoKHR")]
        [NativeName("Name", "pLibraryInterface")]
        public RayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "VkPipeline")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "basePipelineHandle")]
        public Pipeline BasePipelineHandle;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "basePipelineIndex")]
        public int BasePipelineIndex;
    }
}
