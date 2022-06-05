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
        [Obsolete("Deprecated in favour of \"Level0\"")]
        [NativeName("Name", "COPP_ACP_Level0")]
        CoppAcpLevel0 = 0x0,
        [Obsolete("Deprecated in favour of \"LevelMin\"")]
        [NativeName("Name", "COPP_ACP_LevelMin")]
        CoppAcpLevelMin = 0x0,
        [Obsolete("Deprecated in favour of \"Level1\"")]
        [NativeName("Name", "COPP_ACP_Level1")]
        CoppAcpLevel1 = 0x1,
        [Obsolete("Deprecated in favour of \"Level2\"")]
        [NativeName("Name", "COPP_ACP_Level2")]
        CoppAcpLevel2 = 0x2,
        [Obsolete("Deprecated in favour of \"Level3\"")]
        [NativeName("Name", "COPP_ACP_Level3")]
        CoppAcpLevel3 = 0x3,
        [Obsolete("Deprecated in favour of \"LevelMax\"")]
        [NativeName("Name", "COPP_ACP_LevelMax")]
        CoppAcpLevelMax = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "COPP_ACP_ForceDWORD")]
        CoppAcpForceDword = 0x7FFFFFFF,
        [NativeName("Name", "COPP_ACP_Level0")]
        Level0 = 0x0,
        [NativeName("Name", "COPP_ACP_LevelMin")]
        LevelMin = 0x0,
        [NativeName("Name", "COPP_ACP_Level1")]
        Level1 = 0x1,
        [NativeName("Name", "COPP_ACP_Level2")]
        Level2 = 0x2,
        [NativeName("Name", "COPP_ACP_Level3")]
        Level3 = 0x3,
        [NativeName("Name", "COPP_ACP_LevelMax")]
        LevelMax = 0x3,
        [NativeName("Name", "COPP_ACP_ForceDWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
