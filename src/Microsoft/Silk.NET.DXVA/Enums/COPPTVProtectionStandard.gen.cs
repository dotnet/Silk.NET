// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_COPP_TVProtectionStandard")]
    public enum COPPTVProtectionStandard : int
    {
        [NativeName("Name", "COPP_ProtectionStandard_Unknown")]
        CoppProtectionStandardUnknown = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "COPP_ProtectionStandard_None")]
        CoppProtectionStandardNone = 0x0,
        [NativeName("Name", "COPP_ProtectionStandard_IEC61880_525i")]
        CoppProtectionStandardIec61880525i = 0x1,
        [NativeName("Name", "COPP_ProtectionStandard_IEC61880_2_525i")]
        CoppProtectionStandardIec618802525i = 0x2,
        [NativeName("Name", "COPP_ProtectionStandard_IEC62375_625p")]
        CoppProtectionStandardIec62375625p = 0x4,
        [NativeName("Name", "COPP_ProtectionStandard_EIA608B_525")]
        CoppProtectionStandardEia608B525 = 0x8,
        [NativeName("Name", "COPP_ProtectionStandard_EN300294_625i")]
        CoppProtectionStandardEN300294625i = 0x10,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_525p")]
        CoppProtectionStandardCea805ATypeA525p = 0x20,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_750p")]
        CoppProtectionStandardCea805ATypeA750p = 0x40,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_1125i")]
        CoppProtectionStandardCea805ATypeA1125i = 0x80,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_525p")]
        CoppProtectionStandardCea805ATypeB525p = 0x100,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_750p")]
        CoppProtectionStandardCea805ATypeB750p = 0x200,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_1125i")]
        CoppProtectionStandardCea805ATypeB1125i = 0x400,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_525i")]
        CoppProtectionStandardAribtrb15525i = 0x800,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_525p")]
        CoppProtectionStandardAribtrb15525p = 0x1000,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_750p")]
        CoppProtectionStandardAribtrb15750p = 0x2000,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_1125i")]
        CoppProtectionStandardAribtrb151125i = 0x4000,
        [NativeName("Name", "COPP_ProtectionStandard_Mask")]
        CoppProtectionStandardMask = unchecked((int) 0xFFFFFFFF80007FFF),
        [NativeName("Name", "COPP_ProtectionStandard_Reserved")]
        CoppProtectionStandardReserved = 0x7FFF8000,
    }
}
