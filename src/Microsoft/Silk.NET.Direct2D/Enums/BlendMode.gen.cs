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
