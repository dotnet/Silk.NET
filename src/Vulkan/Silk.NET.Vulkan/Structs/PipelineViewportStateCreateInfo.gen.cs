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
    public unsafe struct PipelineViewportStateCreateInfo
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint ViewportCount;
/// <summary></summary>
        public Viewport* PViewports;
/// <summary></summary>
        public uint ScissorCount;
/// <summary></summary>
        public Rect2D* PScissors;
    }
}
