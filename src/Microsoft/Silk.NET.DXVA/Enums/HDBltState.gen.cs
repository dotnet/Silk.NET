// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_BLT_STATE")]
    public enum HDBltState : int
    {
        [NativeName("Name", "DXVAHD_BLT_STATE_TARGET_RECT")]
        HDBltStateTargetRect = 0x0,
        [NativeName("Name", "DXVAHD_BLT_STATE_BACKGROUND_COLOR")]
        HDBltStateBackgroundColor = 0x1,
        [NativeName("Name", "DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE")]
        HDBltStateOutputColorSpace = 0x2,
        [NativeName("Name", "DXVAHD_BLT_STATE_ALPHA_FILL")]
        HDBltStateAlphaFill = 0x3,
        [NativeName("Name", "DXVAHD_BLT_STATE_CONSTRICTION")]
        HDBltStateConstriction = 0x4,
        [NativeName("Name", "DXVAHD_BLT_STATE_PRIVATE")]
        HDBltStatePrivate = 0x3E8,
    }
}
