// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICDdsAlphaMode")]
    public enum WICDdsAlphaMode : int
    {
        [Obsolete("Deprecated in favour of \"DdsAlphaModeUnknown\"")]
        [NativeName("Name", "WICDdsAlphaModeUnknown")]
        WicddsAlphaModeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"DdsAlphaModeStraight\"")]
        [NativeName("Name", "WICDdsAlphaModeStraight")]
        WicddsAlphaModeStraight = 0x1,
        [Obsolete("Deprecated in favour of \"DdsAlphaModePremultiplied\"")]
        [NativeName("Name", "WICDdsAlphaModePremultiplied")]
        WicddsAlphaModePremultiplied = 0x2,
        [Obsolete("Deprecated in favour of \"DdsAlphaModeOpaque\"")]
        [NativeName("Name", "WICDdsAlphaModeOpaque")]
        WicddsAlphaModeOpaque = 0x3,
        [Obsolete("Deprecated in favour of \"DdsAlphaModeCustom\"")]
        [NativeName("Name", "WICDdsAlphaModeCustom")]
        WicddsAlphaModeCustom = 0x4,
        [Obsolete("Deprecated in favour of \"DsalphamodeForceDword\"")]
        [NativeName("Name", "WICDDSALPHAMODE_FORCE_DWORD")]
        WicddsalphamodeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICDdsAlphaModeUnknown")]
        DdsAlphaModeUnknown = 0x0,
        [NativeName("Name", "WICDdsAlphaModeStraight")]
        DdsAlphaModeStraight = 0x1,
        [NativeName("Name", "WICDdsAlphaModePremultiplied")]
        DdsAlphaModePremultiplied = 0x2,
        [NativeName("Name", "WICDdsAlphaModeOpaque")]
        DdsAlphaModeOpaque = 0x3,
        [NativeName("Name", "WICDdsAlphaModeCustom")]
        DdsAlphaModeCustom = 0x4,
        [NativeName("Name", "WICDDSALPHAMODE_FORCE_DWORD")]
        DsalphamodeForceDword = 0x7FFFFFFF,
    }
}
