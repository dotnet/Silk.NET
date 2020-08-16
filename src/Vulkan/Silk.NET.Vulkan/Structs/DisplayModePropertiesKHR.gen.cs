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
    [NativeName("Name", "VkDisplayModePropertiesKHR")]
    public unsafe partial struct DisplayModePropertiesKHR
    {
        public DisplayModePropertiesKHR
        (
            DisplayModeKHR displayMode = default,
            DisplayModeParametersKHR parameters = default
        )
        {
            DisplayMode = displayMode;
            Parameters = parameters;
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayModeKHR")]
        [NativeName("Type.Name", "VkDisplayModeKHR")]
        [NativeName("Name", "displayMode")]
        public DisplayModeKHR DisplayMode;
/// <summary></summary>
        [NativeName("Type", "VkDisplayModeParametersKHR")]
        [NativeName("Type.Name", "VkDisplayModeParametersKHR")]
        [NativeName("Name", "parameters")]
        public DisplayModeParametersKHR Parameters;
    }
}
