// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_COPP_ACP_Protection_Level")]
    public enum COPPACPProtectionLevel : int
    {
        [NativeName("Name", "COPP_ACP_Level0")]
        CoppAcpLevel0 = 0x0,
        [NativeName("Name", "COPP_ACP_LevelMin")]
        CoppAcpLevelMin = 0x0,
        [NativeName("Name", "COPP_ACP_Level1")]
        CoppAcpLevel1 = 0x1,
        [NativeName("Name", "COPP_ACP_Level2")]
        CoppAcpLevel2 = 0x2,
        [NativeName("Name", "COPP_ACP_Level3")]
        CoppAcpLevel3 = 0x3,
        [NativeName("Name", "COPP_ACP_LevelMax")]
        CoppAcpLevelMax = 0x3,
        [NativeName("Name", "COPP_ACP_ForceDWORD")]
        CoppAcpForceDword = 0x7FFFFFFF,
    }
}
