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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public CoverageModulationModeNV CoverageModulationMode;
/// <summary></summary>
        public Bool32 CoverageModulationTableEnable;
/// <summary></summary>
        public uint CoverageModulationTableCount;
/// <summary></summary>
        public float* PCoverageModulationTable;
    }
}
