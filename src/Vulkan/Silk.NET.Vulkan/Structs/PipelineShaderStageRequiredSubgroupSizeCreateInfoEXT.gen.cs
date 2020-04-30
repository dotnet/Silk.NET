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
    public unsafe struct PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
        public PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfoExt,
            void* pNext = default,
            uint requiredSubgroupSize = default
        )
        {
           SType = sType;
           PNext = pNext;
           RequiredSubgroupSize = requiredSubgroupSize;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint RequiredSubgroupSize;
    }
}
