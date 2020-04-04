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
    public unsafe struct PipelineViewportSwizzleStateCreateInfoNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint ViewportCount;
/// <summary></summary>
        public ViewportSwizzleNV* PViewportSwizzles;
    }
}
