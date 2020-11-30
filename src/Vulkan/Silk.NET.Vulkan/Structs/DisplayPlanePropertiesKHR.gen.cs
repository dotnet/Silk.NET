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
    [NativeName("Name", "VkDisplayPlanePropertiesKHR")]
    public unsafe partial struct DisplayPlanePropertiesKHR
    {
        public DisplayPlanePropertiesKHR
        (
            DisplayKHR? currentDisplay = null,
            uint? currentStackIndex = null
        ) : this()
        {
            if (currentDisplay is not null)
            {
                CurrentDisplay = currentDisplay.Value;
            }

            if (currentStackIndex is not null)
            {
                CurrentStackIndex = currentStackIndex.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayKHR")]
        [NativeName("Type.Name", "VkDisplayKHR")]
        [NativeName("Name", "currentDisplay")]
        public DisplayKHR CurrentDisplay;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "currentStackIndex")]
        public uint CurrentStackIndex;
    }
}
