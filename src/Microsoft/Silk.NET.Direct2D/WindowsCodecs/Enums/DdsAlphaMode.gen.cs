// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICDdsAlphaMode")]
    public enum DdsAlphaMode : int
    {
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
