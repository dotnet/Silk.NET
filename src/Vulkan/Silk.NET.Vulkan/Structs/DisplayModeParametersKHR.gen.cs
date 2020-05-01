// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct DisplayModeParametersKHR
    {
        public DisplayModeParametersKHR
        (
            Extent2D visibleRegion = default,
            uint refreshRate = default
        )
        {
           VisibleRegion = visibleRegion;
           RefreshRate = refreshRate;
        }

/// <summary></summary>
        public Extent2D VisibleRegion;
/// <summary></summary>
        public uint RefreshRate;
    }
}
