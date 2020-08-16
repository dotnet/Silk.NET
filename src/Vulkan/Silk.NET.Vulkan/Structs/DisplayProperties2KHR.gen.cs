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
    [NativeName("Name", "VkDisplayProperties2KHR")]
    public unsafe partial struct DisplayProperties2KHR
    {
        public DisplayProperties2KHR
        (
            StructureType sType = StructureType.DisplayProperties2Khr,
            void* pNext = default,
            DisplayPropertiesKHR displayProperties = default
        )
        {
            SType = sType;
            PNext = pNext;
            DisplayProperties = displayProperties;
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
        [NativeName("Type", "VkDisplayPropertiesKHR")]
        [NativeName("Type.Name", "VkDisplayPropertiesKHR")]
        [NativeName("Name", "displayProperties")]
        public DisplayPropertiesKHR DisplayProperties;
    }
}
