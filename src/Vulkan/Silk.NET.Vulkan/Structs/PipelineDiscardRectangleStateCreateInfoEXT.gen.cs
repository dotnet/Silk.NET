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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public DiscardRectangleModeEXT DiscardRectangleMode;
/// <summary></summary>
        public uint DiscardRectangleCount;
/// <summary></summary>
        public Rect2D* PDiscardRectangles;
    }
}
