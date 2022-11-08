// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BLEND_MODE")]
    public enum BlendMode : int
    {
        [Obsolete("Deprecated in favour of \"Multiply\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_MULTIPLY")]
        BlendModeMultiply = 0x0,
        [Obsolete("Deprecated in favour of \"Screen\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_SCREEN")]
        BlendModeScreen = 0x1,
        [Obsolete("Deprecated in favour of \"Darken\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_DARKEN")]
        BlendModeDarken = 0x2,
        [Obsolete("Deprecated in favour of \"Lighten\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_LIGHTEN")]
        BlendModeLighten = 0x3,
        [Obsolete("Deprecated in favour of \"Dissolve\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_DISSOLVE")]
        BlendModeDissolve = 0x4,
        [Obsolete("Deprecated in favour of \"ColorBurn\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_COLOR_BURN")]
        BlendModeColorBurn = 0x5,
        [Obsolete("Deprecated in favour of \"LinearBurn\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_LINEAR_BURN")]
        BlendModeLinearBurn = 0x6,
        [Obsolete("Deprecated in favour of \"DarkerColor\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_DARKER_COLOR")]
        BlendModeDarkerColor = 0x7,
        [Obsolete("Deprecated in favour of \"LighterColor\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_LIGHTER_COLOR")]
        BlendModeLighterColor = 0x8,
        [Obsolete("Deprecated in favour of \"ColorDodge\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_COLOR_DODGE")]
        BlendModeColorDodge = 0x9,
        [Obsolete("Deprecated in favour of \"LinearDodge\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_LINEAR_DODGE")]
        BlendModeLinearDodge = 0xA,
        [Obsolete("Deprecated in favour of \"Overlay\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_OVERLAY")]
        BlendModeOverlay = 0xB,
        [Obsolete("Deprecated in favour of \"SoftLight\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_SOFT_LIGHT")]
        BlendModeSoftLight = 0xC,
        [Obsolete("Deprecated in favour of \"HardLight\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_HARD_LIGHT")]
        BlendModeHardLight = 0xD,
        [Obsolete("Deprecated in favour of \"VividLight\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_VIVID_LIGHT")]
        BlendModeVividLight = 0xE,
        [Obsolete("Deprecated in favour of \"LinearLight\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_LINEAR_LIGHT")]
        BlendModeLinearLight = 0xF,
        [Obsolete("Deprecated in favour of \"PinLight\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_PIN_LIGHT")]
        BlendModePinLight = 0x10,
        [Obsolete("Deprecated in favour of \"HardMix\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_HARD_MIX")]
        BlendModeHardMix = 0x11,
        [Obsolete("Deprecated in favour of \"Difference\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_DIFFERENCE")]
        BlendModeDifference = 0x12,
        [Obsolete("Deprecated in favour of \"Exclusion\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_EXCLUSION")]
        BlendModeExclusion = 0x13,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_HUE")]
        BlendModeHue = 0x14,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_SATURATION")]
        BlendModeSaturation = 0x15,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_COLOR")]
        BlendModeColor = 0x16,
        [Obsolete("Deprecated in favour of \"Luminosity\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_LUMINOSITY")]
        BlendModeLuminosity = 0x17,
        [Obsolete("Deprecated in favour of \"Subtract\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_SUBTRACT")]
        BlendModeSubtract = 0x18,
        [Obsolete("Deprecated in favour of \"Division\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_DIVISION")]
        BlendModeDivision = 0x19,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BLEND_MODE_FORCE_DWORD")]
        BlendModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BLEND_MODE_MULTIPLY")]
        Multiply = 0x0,
        [NativeName("Name", "D2D1_BLEND_MODE_SCREEN")]
        Screen = 0x1,
        [NativeName("Name", "D2D1_BLEND_MODE_DARKEN")]
        Darken = 0x2,
        [NativeName("Name", "D2D1_BLEND_MODE_LIGHTEN")]
        Lighten = 0x3,
        [NativeName("Name", "D2D1_BLEND_MODE_DISSOLVE")]
        Dissolve = 0x4,
        [NativeName("Name", "D2D1_BLEND_MODE_COLOR_BURN")]
        ColorBurn = 0x5,
        [NativeName("Name", "D2D1_BLEND_MODE_LINEAR_BURN")]
        LinearBurn = 0x6,
        [NativeName("Name", "D2D1_BLEND_MODE_DARKER_COLOR")]
        DarkerColor = 0x7,
        [NativeName("Name", "D2D1_BLEND_MODE_LIGHTER_COLOR")]
        LighterColor = 0x8,
        [NativeName("Name", "D2D1_BLEND_MODE_COLOR_DODGE")]
        ColorDodge = 0x9,
        [NativeName("Name", "D2D1_BLEND_MODE_LINEAR_DODGE")]
        LinearDodge = 0xA,
        [NativeName("Name", "D2D1_BLEND_MODE_OVERLAY")]
        Overlay = 0xB,
        [NativeName("Name", "D2D1_BLEND_MODE_SOFT_LIGHT")]
        SoftLight = 0xC,
        [NativeName("Name", "D2D1_BLEND_MODE_HARD_LIGHT")]
        HardLight = 0xD,
        [NativeName("Name", "D2D1_BLEND_MODE_VIVID_LIGHT")]
        VividLight = 0xE,
        [NativeName("Name", "D2D1_BLEND_MODE_LINEAR_LIGHT")]
        LinearLight = 0xF,
        [NativeName("Name", "D2D1_BLEND_MODE_PIN_LIGHT")]
        PinLight = 0x10,
        [NativeName("Name", "D2D1_BLEND_MODE_HARD_MIX")]
        HardMix = 0x11,
        [NativeName("Name", "D2D1_BLEND_MODE_DIFFERENCE")]
        Difference = 0x12,
        [NativeName("Name", "D2D1_BLEND_MODE_EXCLUSION")]
        Exclusion = 0x13,
        [NativeName("Name", "D2D1_BLEND_MODE_HUE")]
        Hue = 0x14,
        [NativeName("Name", "D2D1_BLEND_MODE_SATURATION")]
        Saturation = 0x15,
        [NativeName("Name", "D2D1_BLEND_MODE_COLOR")]
        Color = 0x16,
        [NativeName("Name", "D2D1_BLEND_MODE_LUMINOSITY")]
        Luminosity = 0x17,
        [NativeName("Name", "D2D1_BLEND_MODE_SUBTRACT")]
        Subtract = 0x18,
        [NativeName("Name", "D2D1_BLEND_MODE_DIVISION")]
        Division = 0x19,
        [NativeName("Name", "D2D1_BLEND_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
