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
    [NativeName("Name", "VkPipelineDiscardRectangleStateCreateInfoEXT")]
    public unsafe struct PipelineDiscardRectangleStateCreateInfoEXT
    {
        public PipelineDiscardRectangleStateCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineDiscardRectangleStateCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            DiscardRectangleModeEXT discardRectangleMode = default,
            uint discardRectangleCount = default,
            Rect2D* pDiscardRectangles = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           DiscardRectangleMode = discardRectangleMode;
           DiscardRectangleCount = discardRectangleCount;
           PDiscardRectangles = pDiscardRectangles;
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
        [NativeName("Type", "VkPipelineDiscardRectangleStateCreateFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineDiscardRectangleStateCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkDiscardRectangleModeEXT")]
        [NativeName("Type.Name", "VkDiscardRectangleModeEXT")]
        [NativeName("Name", "discardRectangleMode")]
        public DiscardRectangleModeEXT DiscardRectangleMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "discardRectangleCount")]
        public uint DiscardRectangleCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pDiscardRectangles")]
        public Rect2D* PDiscardRectangles;
    }
}
