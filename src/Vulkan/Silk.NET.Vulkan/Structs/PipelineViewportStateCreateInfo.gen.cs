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
    [NativeName("Name", "VkPipelineViewportStateCreateInfo")]
    public unsafe partial struct PipelineViewportStateCreateInfo
    {
        public PipelineViewportStateCreateInfo
        (
            StructureType sType = StructureType.PipelineViewportStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint viewportCount = default,
            Viewport* pViewports = default,
            uint scissorCount = default,
            Rect2D* pScissors = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            ViewportCount = viewportCount;
            PViewports = pViewports;
            ScissorCount = scissorCount;
            PScissors = pScissors;
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
        [NativeName("Type", "VkPipelineViewportStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineViewportStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportCount")]
        public uint ViewportCount;
/// <summary></summary>
        [NativeName("Type", "VkViewport*")]
        [NativeName("Type.Name", "VkViewport")]
        [NativeName("Name", "pViewports")]
        public Viewport* PViewports;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "scissorCount")]
        public uint ScissorCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pScissors")]
        public Rect2D* PScissors;
    }
}
