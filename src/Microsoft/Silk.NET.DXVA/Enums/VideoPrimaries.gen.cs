// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_VideoPrimaries")]
    public enum VideoPrimaries : int
    {
        [NativeName("Name", "DXVA_VideoPrimariesShift")]
        VideoPrimariesShift = 0x16,
        [NativeName("Name", "DXVA_VideoPrimariesMask")]
        VideoPrimariesMask = 0x7C00000,
        [NativeName("Name", "DXVA_VideoPrimaries_Unknown")]
        VideoPrimariesUnknown = 0x0,
        [NativeName("Name", "DXVA_VideoPrimaries_reserved")]
        VideoPrimariesReserved = 0x1,
        [NativeName("Name", "DXVA_VideoPrimaries_BT709")]
        VideoPrimariesBT709 = 0x2,
        [NativeName("Name", "DXVA_VideoPrimaries_BT470_2_SysM")]
        VideoPrimariesBT4702SysM = 0x3,
        [NativeName("Name", "DXVA_VideoPrimaries_BT470_2_SysBG")]
        VideoPrimariesBT4702SysBG = 0x4,
        [NativeName("Name", "DXVA_VideoPrimaries_SMPTE170M")]
        VideoPrimariesSmpte170M = 0x5,
        [NativeName("Name", "DXVA_VideoPrimaries_SMPTE240M")]
        VideoPrimariesSmpte240M = 0x6,
        [NativeName("Name", "DXVA_VideoPrimaries_EBU3213")]
        VideoPrimariesEbu3213 = 0x7,
        [NativeName("Name", "DXVA_VideoPrimaries_SMPTE_C")]
        VideoPrimariesSmpteC = 0x8,
    }
}
