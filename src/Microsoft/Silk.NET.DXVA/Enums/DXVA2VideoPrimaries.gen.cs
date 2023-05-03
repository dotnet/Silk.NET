// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_VideoPrimaries")]
    public enum DXVA2VideoPrimaries : int
    {
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoPrimariesMask")]
        DXVA2VideoPrimariesMask = 0x1F,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_Unknown")]
        DXVA2VideoPrimariesUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_reserved")]
        DXVA2VideoPrimariesReserved = 0x1,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_BT709")]
        DXVA2VideoPrimariesBT709 = 0x2,
        [Obsolete("Deprecated in favour of \"BT4702SysM\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysM")]
        DXVA2VideoPrimariesBT4702SysM = 0x3,
        [Obsolete("Deprecated in favour of \"BT4702SysBG\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysBG")]
        DXVA2VideoPrimariesBT4702SysBG = 0x4,
        [Obsolete("Deprecated in favour of \"Smpte170M\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE170M")]
        DXVA2VideoPrimariesSmpte170M = 0x5,
        [Obsolete("Deprecated in favour of \"Smpte240M\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE240M")]
        DXVA2VideoPrimariesSmpte240M = 0x6,
        [Obsolete("Deprecated in favour of \"Ebu3213\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_EBU3213")]
        DXVA2VideoPrimariesEbu3213 = 0x7,
        [Obsolete("Deprecated in favour of \"SmpteC\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE_C")]
        DXVA2VideoPrimariesSmpteC = 0x8,
        [NativeName("Name", "DXVA2_VideoPrimariesMask")]
        Mask = 0x1F,
        [NativeName("Name", "DXVA2_VideoPrimaries_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA2_VideoPrimaries_reserved")]
        Reserved = 0x1,
        [NativeName("Name", "DXVA2_VideoPrimaries_BT709")]
        BT709 = 0x2,
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysM")]
        BT4702SysM = 0x3,
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysBG")]
        BT4702SysBG = 0x4,
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE170M")]
        Smpte170M = 0x5,
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE240M")]
        Smpte240M = 0x6,
        [NativeName("Name", "DXVA2_VideoPrimaries_EBU3213")]
        Ebu3213 = 0x7,
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE_C")]
        SmpteC = 0x8,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoPrimariesMask")]
        VideoPrimariesMask = 0x1F,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_Unknown")]
        VideoPrimariesUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_reserved")]
        VideoPrimariesReserved = 0x1,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_BT709")]
        VideoPrimariesBT709 = 0x2,
        [Obsolete("Deprecated in favour of \"BT4702SysM\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysM")]
        VideoPrimariesBT4702SysM = 0x3,
        [Obsolete("Deprecated in favour of \"BT4702SysBG\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysBG")]
        VideoPrimariesBT4702SysBG = 0x4,
        [Obsolete("Deprecated in favour of \"Smpte170M\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE170M")]
        VideoPrimariesSmpte170M = 0x5,
        [Obsolete("Deprecated in favour of \"Smpte240M\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE240M")]
        VideoPrimariesSmpte240M = 0x6,
        [Obsolete("Deprecated in favour of \"Ebu3213\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_EBU3213")]
        VideoPrimariesEbu3213 = 0x7,
        [Obsolete("Deprecated in favour of \"SmpteC\"")]
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE_C")]
        VideoPrimariesSmpteC = 0x8,
    }
}
