// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifGraphicControlExtensionProperties")]
    public enum WICGifGraphicControlExtensionProperties : int
    {
        [Obsolete("Deprecated in favour of \"Disposal\"")]
        [NativeName("Name", "WICGifGraphicControlExtensionDisposal")]
        WicgifGraphicControlExtensionDisposal = 0x1,
        [Obsolete("Deprecated in favour of \"UserInputFlag\"")]
        [NativeName("Name", "WICGifGraphicControlExtensionUserInputFlag")]
        WicgifGraphicControlExtensionUserInputFlag = 0x2,
        [Obsolete("Deprecated in favour of \"TransparencyFlag\"")]
        [NativeName("Name", "WICGifGraphicControlExtensionTransparencyFlag")]
        WicgifGraphicControlExtensionTransparencyFlag = 0x3,
        [Obsolete("Deprecated in favour of \"Delay\"")]
        [NativeName("Name", "WICGifGraphicControlExtensionDelay")]
        WicgifGraphicControlExtensionDelay = 0x4,
        [Obsolete("Deprecated in favour of \"TransparentColorIndex\"")]
        [NativeName("Name", "WICGifGraphicControlExtensionTransparentColorIndex")]
        WicgifGraphicControlExtensionTransparentColorIndex = 0x5,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICGifGraphicControlExtensionProperties_FORCE_DWORD")]
        WicgifGraphicControlExtensionPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICGifGraphicControlExtensionDisposal")]
        Disposal = 0x1,
        [NativeName("Name", "WICGifGraphicControlExtensionUserInputFlag")]
        UserInputFlag = 0x2,
        [NativeName("Name", "WICGifGraphicControlExtensionTransparencyFlag")]
        TransparencyFlag = 0x3,
        [NativeName("Name", "WICGifGraphicControlExtensionDelay")]
        Delay = 0x4,
        [NativeName("Name", "WICGifGraphicControlExtensionTransparentColorIndex")]
        TransparentColorIndex = 0x5,
        [NativeName("Name", "WICGifGraphicControlExtensionProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
