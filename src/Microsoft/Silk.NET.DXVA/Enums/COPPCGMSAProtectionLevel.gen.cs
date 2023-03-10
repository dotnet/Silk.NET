// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_COPP_CGMSA_Protection_Level")]
    public enum COPPCGMSAProtectionLevel : int
    {
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "COPP_CGMSA_Disabled")]
        CoppCgmsaDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"LevelMin\"")]
        [NativeName("Name", "COPP_CGMSA_LevelMin")]
        CoppCgmsaLevelMin = 0x0,
        [Obsolete("Deprecated in favour of \"CopyFreely\"")]
        [NativeName("Name", "COPP_CGMSA_CopyFreely")]
        CoppCgmsaCopyFreely = 0x1,
        [Obsolete("Deprecated in favour of \"CopyNoMore\"")]
        [NativeName("Name", "COPP_CGMSA_CopyNoMore")]
        CoppCgmsaCopyNoMore = 0x2,
        [Obsolete("Deprecated in favour of \"CopyOneGeneration\"")]
        [NativeName("Name", "COPP_CGMSA_CopyOneGeneration")]
        CoppCgmsaCopyOneGeneration = 0x3,
        [Obsolete("Deprecated in favour of \"CopyNever\"")]
        [NativeName("Name", "COPP_CGMSA_CopyNever")]
        CoppCgmsaCopyNever = 0x4,
        [Obsolete("Deprecated in favour of \"RedistributionControlRequired\"")]
        [NativeName("Name", "COPP_CGMSA_RedistributionControlRequired")]
        CoppCgmsaRedistributionControlRequired = 0x8,
        [Obsolete("Deprecated in favour of \"LevelMax\"")]
        [NativeName("Name", "COPP_CGMSA_LevelMax")]
        CoppCgmsaLevelMax = 0xC,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "COPP_CGMSA_ForceDWORD")]
        CoppCgmsaForceDword = 0x7FFFFFFF,
        [NativeName("Name", "COPP_CGMSA_Disabled")]
        Disabled = 0x0,
        [NativeName("Name", "COPP_CGMSA_LevelMin")]
        LevelMin = 0x0,
        [NativeName("Name", "COPP_CGMSA_CopyFreely")]
        CopyFreely = 0x1,
        [NativeName("Name", "COPP_CGMSA_CopyNoMore")]
        CopyNoMore = 0x2,
        [NativeName("Name", "COPP_CGMSA_CopyOneGeneration")]
        CopyOneGeneration = 0x3,
        [NativeName("Name", "COPP_CGMSA_CopyNever")]
        CopyNever = 0x4,
        [NativeName("Name", "COPP_CGMSA_RedistributionControlRequired")]
        RedistributionControlRequired = 0x8,
        [NativeName("Name", "COPP_CGMSA_LevelMax")]
        LevelMax = 0xC,
        [NativeName("Name", "COPP_CGMSA_ForceDWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
