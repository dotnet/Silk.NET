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
    [NativeName("Name", "VkSamplerCustomBorderColorCreateInfoEXT")]
    public unsafe partial struct SamplerCustomBorderColorCreateInfoEXT
    {
        public SamplerCustomBorderColorCreateInfoEXT
        (
            StructureType sType = StructureType.SamplerCustomBorderColorCreateInfoExt,
            void* pNext = default,
            ClearColorValue customBorderColor = default,
            Format format = default
        )
        {
            SType = sType;
            PNext = pNext;
            CustomBorderColor = customBorderColor;
            Format = format;
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
        [NativeName("Type", "VkClearColorValue")]
        [NativeName("Type.Name", "VkClearColorValue")]
        [NativeName("Name", "customBorderColor")]
        public ClearColorValue CustomBorderColor;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "format")]
        public Format Format;
    }
}
