// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS")]
    public enum HardwareCompositionSupportFlags
    {
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN")]
        HardwareCompositionSupportFlagFullscreen = 0x1,
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED")]
        HardwareCompositionSupportFlagWindowed = 0x2,
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED")]
        HardwareCompositionSupportFlagCursorStretched = 0x4,
    }
}
