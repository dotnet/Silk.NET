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
    public unsafe struct DisplayPresentInfoKHR
    {
        public DisplayPresentInfoKHR
        (
            StructureType sType = StructureType.DisplayPresentInfoKhr,
            void* pNext = default,
            Rect2D srcRect = default,
            Rect2D dstRect = default,
            Bool32 persistent = default
        )
        {
           SType = sType;
           PNext = pNext;
           SrcRect = srcRect;
           DstRect = dstRect;
           Persistent = persistent;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Rect2D SrcRect;
/// <summary></summary>
        public Rect2D DstRect;
/// <summary></summary>
        public Bool32 Persistent;
    }
}
