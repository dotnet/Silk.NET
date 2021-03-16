// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkRayTracingPipelineCreateInfoKHR")]
    public unsafe partial struct RayTracingPipelineCreateInfoKHR
    {
        public RayTracingPipelineCreateInfoKHR
        (
            StructureType? sType = StructureType.RayTracingPipelineCreateInfoKhr,
            void* pNext = null,
            PipelineCreateFlags? flags = null,
            uint? stageCount = null,
            PipelineShaderStageCreateInfo* pStages = null,
            uint? groupCount = null,
            RayTracingShaderGroupCreateInfoKHR* pGroups = null,
            uint? maxPipelineRayRecursionDepth = null,
            PipelineLibraryCreateInfoKHR* pLibraryInfo = null,
            RayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface = null,
            PipelineDynamicStateCreateInfo* pDynamicState = null,
            PipelineLayout? layout = null,
            Pipeline? basePipelineHandle = null,
            int? basePipelineIndex = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (stageCount is not null)
            {
                StageCount = stageCount.Value;
            }

            if (pStages is not null)
            {
                PStages = pStages;
            }

            if (groupCount is not null)
            {
                GroupCount = groupCount.Value;
            }

            if (pGroups is not null)
            {
                PGroups = pGroups;
            }

            if (maxPipelineRayRecursionDepth is not null)
            {
                MaxPipelineRayRecursionDepth = maxPipelineRayRecursionDepth.Value;
            }

            if (pLibraryInfo is not null)
            {
                PLibraryInfo = pLibraryInfo;
            }

            if (pLibraryInterface is not null)
            {
                PLibraryInterface = pLibraryInterface;
            }

            if (pDynamicState is not null)
            {
                PDynamicState = pDynamicState;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (basePipelineHandle is not null)
            {
                BasePipelineHandle = basePipelineHandle.Value;
            }

            if (basePipelineIndex is not null)
            {
                BasePipelineIndex = basePipelineIndex.Value;
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
        [NativeName("Name", "maxPipelineRayRecursionDepth")]
        public uint MaxPipelineRayRecursionDepth;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLibraryCreateInfoKHR*")]
        [NativeName("Type.Name", "VkPipelineLibraryCreateInfoKHR")]
        [NativeName("Name", "pLibraryInfo")]
        public PipelineLibraryCreateInfoKHR* PLibraryInfo;
/// <summary></summary>
        [NativeName("Type", "VkRayTracingPipelineInterfaceCreateInfoKHR*")]
        [NativeName("Type.Name", "VkRayTracingPipelineInterfaceCreateInfoKHR")]
        [NativeName("Name", "pLibraryInterface")]
        public RayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;
/// <summary></summary>
        [NativeName("Type", "VkPipelineDynamicStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineDynamicStateCreateInfo")]
        [NativeName("Name", "pDynamicState")]
        public PipelineDynamicStateCreateInfo* PDynamicState;
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
