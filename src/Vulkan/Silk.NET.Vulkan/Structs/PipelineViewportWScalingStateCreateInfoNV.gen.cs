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
    public unsafe struct PipelineViewportWScalingStateCreateInfoNV
    {
        public PipelineViewportWScalingStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineViewportWScalingStateCreateInfoNV,
            void* pNext = default,
            Bool32 viewportWScalingEnable = default,
            uint viewportCount = default,
            ViewportWScalingNV* pViewportWScalings = default
        )
        {
           SType = sType;
           PNext = pNext;
           ViewportWScalingEnable = viewportWScalingEnable;
           ViewportCount = viewportCount;
           PViewportWScalings = pViewportWScalings;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ViewportWScalingEnable;
/// <summary></summary>
        public uint ViewportCount;
/// <summary></summary>
        public ViewportWScalingNV* PViewportWScalings;
    }
}
