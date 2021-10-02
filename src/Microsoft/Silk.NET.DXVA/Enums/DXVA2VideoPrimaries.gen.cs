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
        [NativeName("Name", "DXVA2_VideoPrimariesMask")]
        DXVA2VideoPrimariesMask = 0x1F,
        [NativeName("Name", "DXVA2_VideoPrimaries_Unknown")]
        DXVA2VideoPrimariesUnknown = 0x0,
        [NativeName("Name", "DXVA2_VideoPrimaries_reserved")]
        DXVA2VideoPrimariesReserved = 0x1,
        [NativeName("Name", "DXVA2_VideoPrimaries_BT709")]
        DXVA2VideoPrimariesBT709 = 0x2,
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysM")]
        DXVA2VideoPrimariesBT4702SysM = 0x3,
        [NativeName("Name", "DXVA2_VideoPrimaries_BT470_2_SysBG")]
        DXVA2VideoPrimariesBT4702SysBG = 0x4,
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE170M")]
        DXVA2VideoPrimariesSmpte170M = 0x5,
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE240M")]
        DXVA2VideoPrimariesSmpte240M = 0x6,
        [NativeName("Name", "DXVA2_VideoPrimaries_EBU3213")]
        DXVA2VideoPrimariesEbu3213 = 0x7,
        [NativeName("Name", "DXVA2_VideoPrimaries_SMPTE_C")]
        DXVA2VideoPrimariesSmpteC = 0x8,
    }
}
