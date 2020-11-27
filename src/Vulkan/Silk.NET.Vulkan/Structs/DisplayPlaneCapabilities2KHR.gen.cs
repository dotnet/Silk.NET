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
    [NativeName("Name", "VkDisplayPlaneCapabilities2KHR")]
    public unsafe partial struct DisplayPlaneCapabilities2KHR
    {
        public DisplayPlaneCapabilities2KHR
        (
            StructureType? sType = StructureType.DisplayPlaneCapabilities2Khr,
            void* pNext = null,
            DisplayPlaneCapabilitiesKHR? capabilities = null
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

            if (capabilities is not null)
            {
                Capabilities = capabilities.Value;
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
        [NativeName("Type", "VkDisplayPlaneCapabilitiesKHR")]
        [NativeName("Type.Name", "VkDisplayPlaneCapabilitiesKHR")]
        [NativeName("Name", "capabilities")]
        public DisplayPlaneCapabilitiesKHR Capabilities;
    }
}
