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
    [NativeName("Name", "VkPipelineCoverageModulationStateCreateInfoNV")]
    public unsafe struct PipelineCoverageModulationStateCreateInfoNV
    {
        public PipelineCoverageModulationStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineCoverageModulationStateCreateInfoNV,
            void* pNext = default,
            uint flags = default,
            CoverageModulationModeNV coverageModulationMode = default,
            Bool32 coverageModulationTableEnable = default,
            uint coverageModulationTableCount = default,
            float* pCoverageModulationTable = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           CoverageModulationMode = coverageModulationMode;
           CoverageModulationTableEnable = coverageModulationTableEnable;
           CoverageModulationTableCount = coverageModulationTableCount;
           PCoverageModulationTable = pCoverageModulationTable;
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
        [NativeName("Type", "VkPipelineCoverageModulationStateCreateFlagsNV")]
        [NativeName("Type.Name", "VkPipelineCoverageModulationStateCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkCoverageModulationModeNV")]
        [NativeName("Type.Name", "VkCoverageModulationModeNV")]
        [NativeName("Name", "coverageModulationMode")]
        public CoverageModulationModeNV CoverageModulationMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "coverageModulationTableEnable")]
        public Bool32 CoverageModulationTableEnable;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "coverageModulationTableCount")]
        public uint CoverageModulationTableCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pCoverageModulationTable")]
        public float* PCoverageModulationTable;
    }
}
