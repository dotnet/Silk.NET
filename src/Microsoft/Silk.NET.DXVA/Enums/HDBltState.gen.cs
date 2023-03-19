// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_BLT_STATE")]
    public enum HDBltState : int
    {
        [Obsolete("Deprecated in favour of \"TargetRect\"")]
        [NativeName("Name", "DXVAHD_BLT_STATE_TARGET_RECT")]
        HDBltStateTargetRect = 0x0,
        [Obsolete("Deprecated in favour of \"BackgroundColor\"")]
        [NativeName("Name", "DXVAHD_BLT_STATE_BACKGROUND_COLOR")]
        HDBltStateBackgroundColor = 0x1,
        [Obsolete("Deprecated in favour of \"OutputColorSpace\"")]
        [NativeName("Name", "DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE")]
        HDBltStateOutputColorSpace = 0x2,
        [Obsolete("Deprecated in favour of \"AlphaFill\"")]
        [NativeName("Name", "DXVAHD_BLT_STATE_ALPHA_FILL")]
        HDBltStateAlphaFill = 0x3,
        [Obsolete("Deprecated in favour of \"Constriction\"")]
        [NativeName("Name", "DXVAHD_BLT_STATE_CONSTRICTION")]
        HDBltStateConstriction = 0x4,
        [Obsolete("Deprecated in favour of \"Private\"")]
        [NativeName("Name", "DXVAHD_BLT_STATE_PRIVATE")]
        HDBltStatePrivate = 0x3E8,
        [NativeName("Name", "DXVAHD_BLT_STATE_TARGET_RECT")]
        TargetRect = 0x0,
        [NativeName("Name", "DXVAHD_BLT_STATE_BACKGROUND_COLOR")]
        BackgroundColor = 0x1,
        [NativeName("Name", "DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE")]
        OutputColorSpace = 0x2,
        [NativeName("Name", "DXVAHD_BLT_STATE_ALPHA_FILL")]
        AlphaFill = 0x3,
        [NativeName("Name", "DXVAHD_BLT_STATE_CONSTRICTION")]
        Constriction = 0x4,
        [NativeName("Name", "DXVAHD_BLT_STATE_PRIVATE")]
        Private = 0x3E8,
    }
}
