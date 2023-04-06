// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_GAMMATRANSFER_PROP")]
    public enum GammatransferProp : int
    {
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_AMPLITUDE")]
        RedAmplitude = 0x0,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_EXPONENT")]
        RedExponent = 0x1,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_OFFSET")]
        RedOffset = 0x2,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_DISABLE")]
        RedDisable = 0x3,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_AMPLITUDE")]
        GreenAmplitude = 0x4,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_EXPONENT")]
        GreenExponent = 0x5,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_OFFSET")]
        GreenOffset = 0x6,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_DISABLE")]
        GreenDisable = 0x7,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_AMPLITUDE")]
        BlueAmplitude = 0x8,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_EXPONENT")]
        BlueExponent = 0x9,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_OFFSET")]
        BlueOffset = 0xA,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_DISABLE")]
        BlueDisable = 0xB,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_AMPLITUDE")]
        AlphaAmplitude = 0xC,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_EXPONENT")]
        AlphaExponent = 0xD,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_OFFSET")]
        AlphaOffset = 0xE,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_DISABLE")]
        AlphaDisable = 0xF,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_CLAMP_OUTPUT")]
        ClampOutput = 0x10,
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
