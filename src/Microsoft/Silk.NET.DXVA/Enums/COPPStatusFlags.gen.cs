// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_COPP_StatusFlags")]
    public enum COPPStatusFlags : int
    {
        [NativeName("Name", "COPP_StatusNormal")]
        CoppStatusNormal = 0x0,
        [NativeName("Name", "COPP_LinkLost")]
        CoppLinkLost = 0x1,
        [NativeName("Name", "COPP_RenegotiationRequired")]
        CoppRenegotiationRequired = 0x2,
        [NativeName("Name", "COPP_StatusFlagsReserved")]
        CoppStatusFlagsReserved = unchecked((int) 0xFFFFFFFFFFFFFFFC),
    }
}
