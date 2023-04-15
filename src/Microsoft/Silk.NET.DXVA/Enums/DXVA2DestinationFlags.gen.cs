// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA2_DestinationFlags")]
    public enum DXVA2DestinationFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BackgroundChanged\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_Background_Changed")]
        DXVA2DestinationFlagBackgroundChanged = 0x1,
        [Obsolete("Deprecated in favour of \"TargetRectChanged\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_TargetRect_Changed")]
        DXVA2DestinationFlagTargetRectChanged = 0x2,
        [Obsolete("Deprecated in favour of \"ColorDataChanged\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_ColorData_Changed")]
        DXVA2DestinationFlagColorDataChanged = 0x4,
        [Obsolete("Deprecated in favour of \"AlphaChanged\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_Alpha_Changed")]
        DXVA2DestinationFlagAlphaChanged = 0x8,
        [Obsolete("Deprecated in favour of \"Rff\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_RFF")]
        DXVA2DestinationFlagRff = 0x10000,
        [Obsolete("Deprecated in favour of \"Tff\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_TFF")]
        DXVA2DestinationFlagTff = 0x20000,
        [Obsolete("Deprecated in favour of \"RffTffPresent\"")]
        [NativeName("Name", "DXVA2_DestinationFlag_RFF_TFF_Present")]
        DXVA2DestinationFlagRffTffPresent = 0x40000,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_DestinationFlagMask")]
        DXVA2DestinationFlagMask = unchecked((int) 0xFFFFFFFFFFFF000F),
        [NativeName("Name", "DXVA2_DestinationFlag_Background_Changed")]
        BackgroundChanged = 0x1,
        [NativeName("Name", "DXVA2_DestinationFlag_TargetRect_Changed")]
        TargetRectChanged = 0x2,
        [NativeName("Name", "DXVA2_DestinationFlag_ColorData_Changed")]
        ColorDataChanged = 0x4,
        [NativeName("Name", "DXVA2_DestinationFlag_Alpha_Changed")]
        AlphaChanged = 0x8,
        [NativeName("Name", "DXVA2_DestinationFlag_RFF")]
        Rff = 0x10000,
        [NativeName("Name", "DXVA2_DestinationFlag_TFF")]
        Tff = 0x20000,
        [NativeName("Name", "DXVA2_DestinationFlag_RFF_TFF_Present")]
        RffTffPresent = 0x40000,
        [NativeName("Name", "DXVA2_DestinationFlagMask")]
        Mask = unchecked((int) 0xFFFFFFFFFFFF000F),
    }
}
