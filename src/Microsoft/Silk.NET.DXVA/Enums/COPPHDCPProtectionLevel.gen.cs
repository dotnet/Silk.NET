// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_COPP_HDCP_Protection_Level")]
    public enum COPPHDCPProtectionLevel : int
    {
        [Obsolete("Deprecated in favour of \"Level0\"")]
        [NativeName("Name", "COPP_HDCP_Level0")]
        CoppHdcpLevel0 = 0x0,
        [Obsolete("Deprecated in favour of \"LevelMin\"")]
        [NativeName("Name", "COPP_HDCP_LevelMin")]
        CoppHdcpLevelMin = 0x0,
        [Obsolete("Deprecated in favour of \"Level1\"")]
        [NativeName("Name", "COPP_HDCP_Level1")]
        CoppHdcpLevel1 = 0x1,
        [Obsolete("Deprecated in favour of \"LevelMax\"")]
        [NativeName("Name", "COPP_HDCP_LevelMax")]
        CoppHdcpLevelMax = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "COPP_HDCP_ForceDWORD")]
        CoppHdcpForceDword = 0x7FFFFFFF,
        [NativeName("Name", "COPP_HDCP_Level0")]
        Level0 = 0x0,
        [NativeName("Name", "COPP_HDCP_LevelMin")]
        LevelMin = 0x0,
        [NativeName("Name", "COPP_HDCP_Level1")]
        Level1 = 0x1,
        [NativeName("Name", "COPP_HDCP_LevelMax")]
        LevelMax = 0x1,
        [NativeName("Name", "COPP_HDCP_ForceDWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
