// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSwapchainCounterCreateInfoEXT")]
    public unsafe partial struct SwapchainCounterCreateInfoEXT
    {
        public SwapchainCounterCreateInfoEXT
        (
            StructureType? sType = StructureType.SwapchainCounterCreateInfoExt,
            void* pNext = null,
            SurfaceCounterFlagsEXT? surfaceCounters = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (surfaceCounters is not null)
            {
                SurfaceCounters = surfaceCounters.Value;
            }
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
        [NativeName("Type", "VkSurfaceCounterFlagsEXT")]
        [NativeName("Type.Name", "VkSurfaceCounterFlagsEXT")]
        [NativeName("Name", "surfaceCounters")]
        public SurfaceCounterFlagsEXT SurfaceCounters;
    }
}
