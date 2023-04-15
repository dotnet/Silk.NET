// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_COPP_StatusHDCPFlags")]
    public enum COPPStatusHDCPFlags : int
    {
        [Obsolete("Deprecated in favour of \"Repeater\"")]
        [NativeName("Name", "COPP_HDCPRepeater")]
        CoppHdcprepeater = 0x1,
        [Obsolete("Deprecated in favour of \"FlagsReserved\"")]
        [NativeName("Name", "COPP_HDCPFlagsReserved")]
        CoppHdcpflagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "COPP_HDCPRepeater")]
        Repeater = 0x1,
        [NativeName("Name", "COPP_HDCPFlagsReserved")]
        FlagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFE),
    }
}
