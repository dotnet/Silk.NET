// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageDrmFormatModifierExplicitCreateInfoEXT")]
    public unsafe struct ImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public ImageDrmFormatModifierExplicitCreateInfoEXT
        (
            StructureType sType = StructureType.ImageDrmFormatModifierExplicitCreateInfoExt,
            void* pNext = default,
            ulong drmFormatModifier = default,
            uint drmFormatModifierPlaneCount = default,
            SubresourceLayout* pPlaneLayouts = default
        )
        {
           SType = sType;
           PNext = pNext;
           DrmFormatModifier = drmFormatModifier;
           DrmFormatModifierPlaneCount = drmFormatModifierPlaneCount;
           PPlaneLayouts = pPlaneLayouts;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmFormatModifier")]
        public ulong DrmFormatModifier;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "drmFormatModifierPlaneCount")]
        public uint DrmFormatModifierPlaneCount;
/// <summary></summary>
        [NativeName("Type", "VkSubresourceLayout*")]
        [NativeName("Type.Name", "VkSubresourceLayout")]
        [NativeName("Name", "pPlaneLayouts")]
        public SubresourceLayout* PPlaneLayouts;
    }
}
