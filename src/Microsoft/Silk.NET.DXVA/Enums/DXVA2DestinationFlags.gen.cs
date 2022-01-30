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
        [NativeName("Name", "DXVA2_DestinationFlag_Background_Changed")]
        DXVA2DestinationFlagBackgroundChanged = 0x1,
        [NativeName("Name", "DXVA2_DestinationFlag_TargetRect_Changed")]
        DXVA2DestinationFlagTargetRectChanged = 0x2,
        [NativeName("Name", "DXVA2_DestinationFlag_ColorData_Changed")]
        DXVA2DestinationFlagColorDataChanged = 0x4,
        [NativeName("Name", "DXVA2_DestinationFlag_Alpha_Changed")]
        DXVA2DestinationFlagAlphaChanged = 0x8,
        [NativeName("Name", "DXVA2_DestinationFlag_RFF")]
        DXVA2DestinationFlagRff = 0x10000,
        [NativeName("Name", "DXVA2_DestinationFlag_TFF")]
        DXVA2DestinationFlagTff = 0x20000,
        [NativeName("Name", "DXVA2_DestinationFlag_RFF_TFF_Present")]
        DXVA2DestinationFlagRffTffPresent = 0x40000,
        [NativeName("Name", "DXVA2_DestinationFlagMask")]
        DXVA2DestinationFlagMask = unchecked((int) 0xFFFFFFFFFFFF000F),
    }
}
