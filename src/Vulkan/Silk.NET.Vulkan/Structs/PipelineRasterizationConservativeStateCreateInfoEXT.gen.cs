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
    [NativeName("Name", "VkPipelineRasterizationConservativeStateCreateInfoEXT")]
    public unsafe struct PipelineRasterizationConservativeStateCreateInfoEXT
    {
        public PipelineRasterizationConservativeStateCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineRasterizationConservativeStateCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            ConservativeRasterizationModeEXT conservativeRasterizationMode = default,
            float extraPrimitiveOverestimationSize = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           ConservativeRasterizationMode = conservativeRasterizationMode;
           ExtraPrimitiveOverestimationSize = extraPrimitiveOverestimationSize;
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
        [NativeName("Type", "VkPipelineRasterizationConservativeStateCreateFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineRasterizationConservativeStateCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkConservativeRasterizationModeEXT")]
        [NativeName("Type.Name", "VkConservativeRasterizationModeEXT")]
        [NativeName("Name", "conservativeRasterizationMode")]
        public ConservativeRasterizationModeEXT ConservativeRasterizationMode;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "extraPrimitiveOverestimationSize")]
        public float ExtraPrimitiveOverestimationSize;
    }
}
