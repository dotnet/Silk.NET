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
    [NativeName("Name", "VkPipelineViewportSwizzleStateCreateInfoNV")]
    public unsafe partial struct PipelineViewportSwizzleStateCreateInfoNV
    {
        public PipelineViewportSwizzleStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineViewportSwizzleStateCreateInfoNV,
            void* pNext = default,
            uint flags = default,
            uint viewportCount = default,
            ViewportSwizzleNV* pViewportSwizzles = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            ViewportCount = viewportCount;
            PViewportSwizzles = pViewportSwizzles;
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
        [NativeName("Type", "VkPipelineViewportSwizzleStateCreateFlagsNV")]
        [NativeName("Type.Name", "VkPipelineViewportSwizzleStateCreateFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportCount")]
        public uint ViewportCount;
/// <summary></summary>
        [NativeName("Type", "VkViewportSwizzleNV*")]
        [NativeName("Type.Name", "VkViewportSwizzleNV")]
        [NativeName("Name", "pViewportSwizzles")]
        public ViewportSwizzleNV* PViewportSwizzles;
    }
}
