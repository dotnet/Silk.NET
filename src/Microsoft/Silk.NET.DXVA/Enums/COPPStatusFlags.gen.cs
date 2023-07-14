// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_COPP_StatusFlags")]
    public enum COPPStatusFlags : int
    {
        [Obsolete("Deprecated in favour of \"StatusNormal\"")]
        [NativeName("Name", "COPP_StatusNormal")]
        CoppStatusNormal = 0x0,
        [Obsolete("Deprecated in favour of \"LinkLost\"")]
        [NativeName("Name", "COPP_LinkLost")]
        CoppLinkLost = 0x1,
        [Obsolete("Deprecated in favour of \"RenegotiationRequired\"")]
        [NativeName("Name", "COPP_RenegotiationRequired")]
        CoppRenegotiationRequired = 0x2,
        [Obsolete("Deprecated in favour of \"StatusFlagsReserved\"")]
        [NativeName("Name", "COPP_StatusFlagsReserved")]
        CoppStatusFlagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "COPP_StatusNormal")]
        StatusNormal = 0x0,
        [NativeName("Name", "COPP_LinkLost")]
        LinkLost = 0x1,
        [NativeName("Name", "COPP_RenegotiationRequired")]
        RenegotiationRequired = 0x2,
        [NativeName("Name", "COPP_StatusFlagsReserved")]
        StatusFlagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFC),
    }
}
