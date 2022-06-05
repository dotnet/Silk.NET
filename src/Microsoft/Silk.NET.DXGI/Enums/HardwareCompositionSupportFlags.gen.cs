// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS")]
    public enum HardwareCompositionSupportFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Fullscreen\"")]
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN")]
        HardwareCompositionSupportFlagFullscreen = 0x1,
        [Obsolete("Deprecated in favour of \"Windowed\"")]
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED")]
        HardwareCompositionSupportFlagWindowed = 0x2,
        [Obsolete("Deprecated in favour of \"CursorStretched\"")]
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED")]
        HardwareCompositionSupportFlagCursorStretched = 0x4,
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN")]
        Fullscreen = 0x1,
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED")]
        Windowed = 0x2,
        [NativeName("Name", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED")]
        CursorStretched = 0x4,
    }
}
