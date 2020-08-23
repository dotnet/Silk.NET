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
    [NativeName("Name", "VkFilterCubicImageViewImageFormatPropertiesEXT")]
    public unsafe partial struct FilterCubicImageViewImageFormatPropertiesEXT
    {
        public FilterCubicImageViewImageFormatPropertiesEXT
        (
            StructureType sType = StructureType.FilterCubicImageViewImageFormatPropertiesExt,
            void* pNext = default,
            Bool32 filterCubic = default,
            Bool32 filterCubicMinmax = default
        )
        {
            SType = sType;
            PNext = pNext;
            FilterCubic = filterCubic;
            FilterCubicMinmax = filterCubicMinmax;
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
        [NativeName("Name", "filterCubic")]
        public Bool32 FilterCubic;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "filterCubicMinmax")]
        public Bool32 FilterCubicMinmax;
    }
}
