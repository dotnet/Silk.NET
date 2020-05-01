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
    public unsafe struct PipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public PipelineViewportExclusiveScissorStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineViewportExclusiveScissorStateCreateInfoNV,
            void* pNext = default,
            uint exclusiveScissorCount = default,
            Rect2D* pExclusiveScissors = default
        )
        {
           SType = sType;
           PNext = pNext;
           ExclusiveScissorCount = exclusiveScissorCount;
           PExclusiveScissors = pExclusiveScissors;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint ExclusiveScissorCount;
/// <summary></summary>
        public Rect2D* PExclusiveScissors;
    }
}
