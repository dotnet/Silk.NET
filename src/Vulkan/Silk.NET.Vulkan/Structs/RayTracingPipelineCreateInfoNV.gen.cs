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
    public unsafe struct RayTracingPipelineCreateInfoNV
    {
        public RayTracingPipelineCreateInfoNV
        (
            StructureType sType = StructureType.RayTracingPipelineCreateInfoNV,
            void* pNext = default,
            PipelineCreateFlags flags = default,
            uint stageCount = default,
            PipelineShaderStageCreateInfo* pStages = default,
            uint groupCount = default,
            RayTracingShaderGroupCreateInfoNV* pGroups = default,
            uint maxRecursionDepth = default,
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
        public RayTracingShaderGroupCreateInfoNV* PGroups;
/// <summary></summary>
        public uint MaxRecursionDepth;
/// <summary></summary>
        public PipelineLayout Layout;
/// <summary></summary>
        public Pipeline BasePipelineHandle;
/// <summary></summary>
        public int BasePipelineIndex;
    }
}
