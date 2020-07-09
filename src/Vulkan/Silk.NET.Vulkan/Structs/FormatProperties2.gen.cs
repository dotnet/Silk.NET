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
    [NativeName("Name", "VkFormatProperties2")]
    public unsafe struct FormatProperties2
    {
        public FormatProperties2
        (
            StructureType sType = StructureType.FormatProperties2,
            void* pNext = default,
            FormatProperties formatProperties = default
        )
        {
           SType = sType;
           PNext = pNext;
           FormatProperties = formatProperties;
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
        [NativeName("Type", "VkFormatProperties")]
        [NativeName("Type.Name", "VkFormatProperties")]
        [NativeName("Name", "formatProperties")]
        public FormatProperties FormatProperties;
    }
}
