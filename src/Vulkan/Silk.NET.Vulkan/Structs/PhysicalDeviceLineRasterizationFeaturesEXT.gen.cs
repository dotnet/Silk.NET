// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceLineRasterizationFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceLineRasterizationFeaturesEXT
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rectangularLines")]
        public Bool32 RectangularLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bresenhamLines")]
        public Bool32 BresenhamLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "smoothLines")]
        public Bool32 SmoothLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledRectangularLines")]
        public Bool32 StippledRectangularLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledBresenhamLines")]
        public Bool32 StippledBresenhamLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledSmoothLines")]
        public Bool32 StippledSmoothLines;
    }
}
