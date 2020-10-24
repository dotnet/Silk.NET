// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPresentRegionKHR")]
    public unsafe partial struct PresentRegionKHR
    {
        public PresentRegionKHR
        (
            uint? rectangleCount = null,
            RectLayerKHR* pRectangles = null
        ) : this()
        {
            if (rectangleCount is not null)
            {
                RectangleCount = rectangleCount.Value;
            }

            if (pRectangles is not null)
            {
                PRectangles = pRectangles;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "rectangleCount")]
        public uint RectangleCount;
/// <summary></summary>
        [NativeName("Type", "VkRectLayerKHR*")]
        [NativeName("Type.Name", "VkRectLayerKHR")]
        [NativeName("Name", "pRectangles")]
        public RectLayerKHR* PRectangles;
    }
}
