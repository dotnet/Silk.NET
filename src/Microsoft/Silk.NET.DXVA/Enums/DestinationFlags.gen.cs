// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_DestinationFlags")]
    public enum DestinationFlags : int
    {
        [NativeName("Name", "DXVA_DestinationFlagMask")]
        DestinationFlagMask = 0xF,
        [NativeName("Name", "DXVA_DestinationFlag_Background_Changed")]
        DestinationFlagBackgroundChanged = 0x1,
        [NativeName("Name", "DXVA_DestinationFlag_TargetRect_Changed")]
        DestinationFlagTargetRectChanged = 0x2,
        [NativeName("Name", "DXVA_DestinationFlag_ColorData_Changed")]
        DestinationFlagColorDataChanged = 0x4,
        [NativeName("Name", "DXVA_DestinationFlag_Alpha_Changed")]
        DestinationFlagAlphaChanged = 0x8,
    }
}
