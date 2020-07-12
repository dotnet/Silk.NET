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
    [NativeName("Name", "VkPipelineRasterizationStateStreamCreateInfoEXT")]
    public unsafe partial struct PipelineRasterizationStateStreamCreateInfoEXT
    {
        public PipelineRasterizationStateStreamCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineRasterizationStateStreamCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            uint rasterizationStream = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            RasterizationStream = rasterizationStream;
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
        [NativeName("Type", "VkPipelineRasterizationStateStreamCreateFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineRasterizationStateStreamCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "rasterizationStream")]
        public uint RasterizationStream;
    }
}
