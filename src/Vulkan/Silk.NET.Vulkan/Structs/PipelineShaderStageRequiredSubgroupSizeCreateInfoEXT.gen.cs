// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT")]
    public unsafe partial struct PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "requiredSubgroupSize")]
        public uint RequiredSubgroupSize;
    }
}
