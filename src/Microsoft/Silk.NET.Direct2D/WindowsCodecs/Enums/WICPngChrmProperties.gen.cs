// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngChrmProperties")]
    public enum WICPngChrmProperties : int
    {
        [Obsolete("Deprecated in favour of \"WhitePointX\"")]
        [NativeName("Name", "WICPngChrmWhitePointX")]
        WicpngChrmWhitePointX = 0x1,
        [Obsolete("Deprecated in favour of \"WhitePointY\"")]
        [NativeName("Name", "WICPngChrmWhitePointY")]
        WicpngChrmWhitePointY = 0x2,
        [Obsolete("Deprecated in favour of \"RedX\"")]
        [NativeName("Name", "WICPngChrmRedX")]
        WicpngChrmRedX = 0x3,
        [Obsolete("Deprecated in favour of \"RedY\"")]
        [NativeName("Name", "WICPngChrmRedY")]
        WicpngChrmRedY = 0x4,
        [Obsolete("Deprecated in favour of \"GreenX\"")]
        [NativeName("Name", "WICPngChrmGreenX")]
        WicpngChrmGreenX = 0x5,
        [Obsolete("Deprecated in favour of \"GreenY\"")]
        [NativeName("Name", "WICPngChrmGreenY")]
        WicpngChrmGreenY = 0x6,
        [Obsolete("Deprecated in favour of \"BlueX\"")]
        [NativeName("Name", "WICPngChrmBlueX")]
        WicpngChrmBlueX = 0x7,
        [Obsolete("Deprecated in favour of \"BlueY\"")]
        [NativeName("Name", "WICPngChrmBlueY")]
        WicpngChrmBlueY = 0x8,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngChrmProperties_FORCE_DWORD")]
        WicpngChrmPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngChrmWhitePointX")]
        WhitePointX = 0x1,
        [NativeName("Name", "WICPngChrmWhitePointY")]
        WhitePointY = 0x2,
        [NativeName("Name", "WICPngChrmRedX")]
        RedX = 0x3,
        [NativeName("Name", "WICPngChrmRedY")]
        RedY = 0x4,
        [NativeName("Name", "WICPngChrmGreenX")]
        GreenX = 0x5,
        [NativeName("Name", "WICPngChrmGreenY")]
        GreenY = 0x6,
        [NativeName("Name", "WICPngChrmBlueX")]
        BlueX = 0x7,
        [NativeName("Name", "WICPngChrmBlueY")]
        BlueY = 0x8,
        [NativeName("Name", "WICPngChrmProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
