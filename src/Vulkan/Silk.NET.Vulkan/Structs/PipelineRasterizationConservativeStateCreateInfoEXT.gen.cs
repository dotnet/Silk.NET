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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public ConservativeRasterizationModeEXT ConservativeRasterizationMode;
/// <summary></summary>
        public float ExtraPrimitiveOverestimationSize;
    }
}
