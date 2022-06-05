// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_COPP_StatusHDCPFlags")]
    public enum COPPStatusHDCPFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Hdcprepeater\"")]
        [NativeName("Name", "COPP_HDCPRepeater")]
        CoppHdcprepeater = 0x1,
        [Obsolete("Deprecated in favour of \"HdcpflagsReserved\"")]
        [NativeName("Name", "COPP_HDCPFlagsReserved")]
        CoppHdcpflagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "COPP_HDCPRepeater")]
        Hdcprepeater = 0x1,
        [NativeName("Name", "COPP_HDCPFlagsReserved")]
        HdcpflagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFE),
    }
}
