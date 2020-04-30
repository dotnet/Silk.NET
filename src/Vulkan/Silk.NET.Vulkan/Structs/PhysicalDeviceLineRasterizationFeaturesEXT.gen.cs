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
    public unsafe struct PhysicalDeviceLineRasterizationFeaturesEXT
    {
        public PhysicalDeviceLineRasterizationFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceLineRasterizationFeaturesExt,
            void* pNext = default,
            Bool32 rectangularLines = default,
            Bool32 bresenhamLines = default,
            Bool32 smoothLines = default,
            Bool32 stippledRectangularLines = default,
            Bool32 stippledBresenhamLines = default,
            Bool32 stippledSmoothLines = default
        )
        {
           SType = sType;
           PNext = pNext;
           RectangularLines = rectangularLines;
           BresenhamLines = bresenhamLines;
           SmoothLines = smoothLines;
           StippledRectangularLines = stippledRectangularLines;
           StippledBresenhamLines = stippledBresenhamLines;
           StippledSmoothLines = stippledSmoothLines;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 RectangularLines;
/// <summary></summary>
        public Bool32 BresenhamLines;
/// <summary></summary>
        public Bool32 SmoothLines;
/// <summary></summary>
        public Bool32 StippledRectangularLines;
/// <summary></summary>
        public Bool32 StippledBresenhamLines;
/// <summary></summary>
        public Bool32 StippledSmoothLines;
    }
}
