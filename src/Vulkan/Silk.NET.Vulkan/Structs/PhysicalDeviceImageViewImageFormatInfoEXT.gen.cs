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
    [NativeName("Name", "VkPhysicalDeviceImageViewImageFormatInfoEXT")]
    public unsafe partial struct PhysicalDeviceImageViewImageFormatInfoEXT
    {
        public PhysicalDeviceImageViewImageFormatInfoEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceImageViewImageFormatInfoExt,
            void* pNext = null,
            ImageViewType? imageViewType = null
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

            if (imageViewType is not null)
            {
                ImageViewType = imageViewType.Value;
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
        [NativeName("Type", "VkImageViewType")]
        [NativeName("Type.Name", "VkImageViewType")]
        [NativeName("Name", "imageViewType")]
        public ImageViewType ImageViewType;
    }
}
