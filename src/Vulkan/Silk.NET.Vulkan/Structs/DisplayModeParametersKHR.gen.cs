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
    [NativeName("Name", "VkDisplayModeParametersKHR")]
    public unsafe partial struct DisplayModeParametersKHR
    {
        public DisplayModeParametersKHR
        (
            Extent2D? visibleRegion = null,
            uint? refreshRate = null
        ) : this()
        {
            if (visibleRegion is not null)
            {
                VisibleRegion = visibleRegion.Value;
            }

            if (refreshRate is not null)
            {
                RefreshRate = refreshRate.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "visibleRegion")]
        public Extent2D VisibleRegion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "refreshRate")]
        public uint RefreshRate;
    }
}
