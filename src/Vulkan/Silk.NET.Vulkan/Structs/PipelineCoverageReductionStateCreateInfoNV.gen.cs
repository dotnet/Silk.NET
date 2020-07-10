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
    [NativeName("Name", "VkPipelineCoverageReductionStateCreateInfoNV")]
    public unsafe partial struct PipelineCoverageReductionStateCreateInfoNV
    {
        public PipelineCoverageReductionStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineCoverageReductionStateCreateInfoNV,
            void* pNext = default,
            uint flags = default,
            CoverageReductionModeNV coverageReductionMode = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            CoverageReductionMode = coverageReductionMode;
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
        [NativeName("Type", "VkPipelineCoverageReductionStateCreateFlagsNV")]
        [NativeName("Type.Name", "VkPipelineCoverageReductionStateCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkCoverageReductionModeNV")]
        [NativeName("Type.Name", "VkCoverageReductionModeNV")]
        [NativeName("Name", "coverageReductionMode")]
        public CoverageReductionModeNV CoverageReductionMode;
    }
}
