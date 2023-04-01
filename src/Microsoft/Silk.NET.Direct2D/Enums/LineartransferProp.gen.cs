// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_LINEARTRANSFER_PROP")]
    public enum LineartransferProp : int
    {
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT")]
        RedYIntercept = 0x0,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_RED_SLOPE")]
        RedSlope = 0x1,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_RED_DISABLE")]
        RedDisable = 0x2,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT")]
        GreenYIntercept = 0x3,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE")]
        GreenSlope = 0x4,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE")]
        GreenDisable = 0x5,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT")]
        BlueYIntercept = 0x6,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE")]
        BlueSlope = 0x7,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE")]
        BlueDisable = 0x8,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT")]
        AlphaYIntercept = 0x9,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE")]
        AlphaSlope = 0xA,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE")]
        AlphaDisable = 0xB,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT")]
        ClampOutput = 0xC,
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
