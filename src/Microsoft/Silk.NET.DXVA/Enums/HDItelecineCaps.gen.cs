// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_ITELECINE_CAPS")]
    public enum HDItelecineCaps : int
    {
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_32")]
        HDItelecineCaps32 = 0x1,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_22")]
        HDItelecineCaps22 = 0x2,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_2224")]
        HDItelecineCaps2224 = 0x4,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_2332")]
        HDItelecineCaps2332 = 0x8,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_32322")]
        HDItelecineCaps32322 = 0x10,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_55")]
        HDItelecineCaps55 = 0x20,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_64")]
        HDItelecineCaps64 = 0x40,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_87")]
        HDItelecineCaps87 = 0x80,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_222222222223")]
        HDItelecineCaps222222222223 = 0x100,
        [NativeName("Name", "DXVAHD_ITELECINE_CAPS_OTHER")]
        HDItelecineCapsOther = unchecked((int) 0xFFFFFFFF80000000),
    }
}
