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
        [Obsolete("Deprecated in favour of \"RedAmplitude\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_AMPLITUDE")]
        GammatransferPropRedAmplitude = 0x0,
        [Obsolete("Deprecated in favour of \"RedExponent\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_EXPONENT")]
        GammatransferPropRedExponent = 0x1,
        [Obsolete("Deprecated in favour of \"RedOffset\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_OFFSET")]
        GammatransferPropRedOffset = 0x2,
        [Obsolete("Deprecated in favour of \"RedDisable\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_RED_DISABLE")]
        GammatransferPropRedDisable = 0x3,
        [Obsolete("Deprecated in favour of \"GreenAmplitude\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_AMPLITUDE")]
        GammatransferPropGreenAmplitude = 0x4,
        [Obsolete("Deprecated in favour of \"GreenExponent\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_EXPONENT")]
        GammatransferPropGreenExponent = 0x5,
        [Obsolete("Deprecated in favour of \"GreenOffset\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_OFFSET")]
        GammatransferPropGreenOffset = 0x6,
        [Obsolete("Deprecated in favour of \"GreenDisable\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_GREEN_DISABLE")]
        GammatransferPropGreenDisable = 0x7,
        [Obsolete("Deprecated in favour of \"BlueAmplitude\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_AMPLITUDE")]
        GammatransferPropBlueAmplitude = 0x8,
        [Obsolete("Deprecated in favour of \"BlueExponent\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_EXPONENT")]
        GammatransferPropBlueExponent = 0x9,
        [Obsolete("Deprecated in favour of \"BlueOffset\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_OFFSET")]
        GammatransferPropBlueOffset = 0xA,
        [Obsolete("Deprecated in favour of \"BlueDisable\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_BLUE_DISABLE")]
        GammatransferPropBlueDisable = 0xB,
        [Obsolete("Deprecated in favour of \"AlphaAmplitude\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_AMPLITUDE")]
        GammatransferPropAlphaAmplitude = 0xC,
        [Obsolete("Deprecated in favour of \"AlphaExponent\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_EXPONENT")]
        GammatransferPropAlphaExponent = 0xD,
        [Obsolete("Deprecated in favour of \"AlphaOffset\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_OFFSET")]
        GammatransferPropAlphaOffset = 0xE,
        [Obsolete("Deprecated in favour of \"AlphaDisable\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_ALPHA_DISABLE")]
        GammatransferPropAlphaDisable = 0xF,
        [Obsolete("Deprecated in favour of \"ClampOutput\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_CLAMP_OUTPUT")]
        GammatransferPropClampOutput = 0x10,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_GAMMATRANSFER_PROP_FORCE_DWORD")]
        GammatransferPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
