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
    public unsafe struct PipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public PipelineColorBlendAdvancedStateCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineColorBlendAdvancedStateCreateInfoExt,
            void* pNext = default,
            Bool32 srcPremultiplied = default,
            Bool32 dstPremultiplied = default,
            BlendOverlapEXT blendOverlap = default
        )
        {
           SType = sType;
           PNext = pNext;
           SrcPremultiplied = srcPremultiplied;
           DstPremultiplied = dstPremultiplied;
           BlendOverlap = blendOverlap;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 SrcPremultiplied;
/// <summary></summary>
        public Bool32 DstPremultiplied;
/// <summary></summary>
        public BlendOverlapEXT BlendOverlap;
    }
}
