// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifGraphicControlExtensionProperties")]
    public enum GifGraphicControlExtensionProperties : int
    {
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
