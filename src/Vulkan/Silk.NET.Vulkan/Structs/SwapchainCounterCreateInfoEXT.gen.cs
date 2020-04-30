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
    public unsafe struct SwapchainCounterCreateInfoEXT
    {
        public SwapchainCounterCreateInfoEXT
        (
            StructureType sType = StructureType.SwapchainCounterCreateInfoExt,
            void* pNext = default,
            SurfaceCounterFlagsEXT surfaceCounters = default
        )
        {
           SType = sType;
           PNext = pNext;
           SurfaceCounters = surfaceCounters;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SurfaceCounterFlagsEXT SurfaceCounters;
    }
}
