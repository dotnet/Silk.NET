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
    public unsafe struct PresentRegionKHR
    {
        public PresentRegionKHR
        (
            uint rectangleCount = default,
            RectLayerKHR* pRectangles = default
        )
        {
           RectangleCount = rectangleCount;
           PRectangles = pRectangles;
        }

/// <summary></summary>
        public uint RectangleCount;
/// <summary></summary>
        public RectLayerKHR* PRectangles;
    }
}
