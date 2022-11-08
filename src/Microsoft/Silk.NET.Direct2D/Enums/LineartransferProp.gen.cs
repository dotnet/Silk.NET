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
        [Obsolete("Deprecated in favour of \"RedYIntercept\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT")]
        LineartransferPropRedYIntercept = 0x0,
        [Obsolete("Deprecated in favour of \"RedSlope\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_RED_SLOPE")]
        LineartransferPropRedSlope = 0x1,
        [Obsolete("Deprecated in favour of \"RedDisable\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_RED_DISABLE")]
        LineartransferPropRedDisable = 0x2,
        [Obsolete("Deprecated in favour of \"GreenYIntercept\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT")]
        LineartransferPropGreenYIntercept = 0x3,
        [Obsolete("Deprecated in favour of \"GreenSlope\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE")]
        LineartransferPropGreenSlope = 0x4,
        [Obsolete("Deprecated in favour of \"GreenDisable\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE")]
        LineartransferPropGreenDisable = 0x5,
        [Obsolete("Deprecated in favour of \"BlueYIntercept\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT")]
        LineartransferPropBlueYIntercept = 0x6,
        [Obsolete("Deprecated in favour of \"BlueSlope\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE")]
        LineartransferPropBlueSlope = 0x7,
        [Obsolete("Deprecated in favour of \"BlueDisable\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE")]
        LineartransferPropBlueDisable = 0x8,
        [Obsolete("Deprecated in favour of \"AlphaYIntercept\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT")]
        LineartransferPropAlphaYIntercept = 0x9,
        [Obsolete("Deprecated in favour of \"AlphaSlope\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE")]
        LineartransferPropAlphaSlope = 0xA,
        [Obsolete("Deprecated in favour of \"AlphaDisable\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE")]
        LineartransferPropAlphaDisable = 0xB,
        [Obsolete("Deprecated in favour of \"ClampOutput\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT")]
        LineartransferPropClampOutput = 0xC,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_LINEARTRANSFER_PROP_FORCE_DWORD")]
        LineartransferPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
