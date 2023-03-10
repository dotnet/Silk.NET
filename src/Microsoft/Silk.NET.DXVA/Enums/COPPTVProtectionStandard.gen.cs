// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_COPP_TVProtectionStandard")]
    public enum COPPTVProtectionStandard : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "COPP_ProtectionStandard_Unknown")]
        CoppProtectionStandardUnknown = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "COPP_ProtectionStandard_None")]
        CoppProtectionStandardNone = 0x0,
        [Obsolete("Deprecated in favour of \"Iec61880525i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_IEC61880_525i")]
        CoppProtectionStandardIec61880525i = 0x1,
        [Obsolete("Deprecated in favour of \"Iec618802525i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_IEC61880_2_525i")]
        CoppProtectionStandardIec618802525i = 0x2,
        [Obsolete("Deprecated in favour of \"Iec62375625p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_IEC62375_625p")]
        CoppProtectionStandardIec62375625p = 0x4,
        [Obsolete("Deprecated in favour of \"Eia608B525\"")]
        [NativeName("Name", "COPP_ProtectionStandard_EIA608B_525")]
        CoppProtectionStandardEia608B525 = 0x8,
        [Obsolete("Deprecated in favour of \"EN300294625i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_EN300294_625i")]
        CoppProtectionStandardEN300294625i = 0x10,
        [Obsolete("Deprecated in favour of \"Cea805ATypeA525p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_525p")]
        CoppProtectionStandardCea805ATypeA525p = 0x20,
        [Obsolete("Deprecated in favour of \"Cea805ATypeA750p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_750p")]
        CoppProtectionStandardCea805ATypeA750p = 0x40,
        [Obsolete("Deprecated in favour of \"Cea805ATypeA1125i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_1125i")]
        CoppProtectionStandardCea805ATypeA1125i = 0x80,
        [Obsolete("Deprecated in favour of \"Cea805ATypeB525p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_525p")]
        CoppProtectionStandardCea805ATypeB525p = 0x100,
        [Obsolete("Deprecated in favour of \"Cea805ATypeB750p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_750p")]
        CoppProtectionStandardCea805ATypeB750p = 0x200,
        [Obsolete("Deprecated in favour of \"Cea805ATypeB1125i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_1125i")]
        CoppProtectionStandardCea805ATypeB1125i = 0x400,
        [Obsolete("Deprecated in favour of \"Aribtrb15525i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_525i")]
        CoppProtectionStandardAribtrb15525i = 0x800,
        [Obsolete("Deprecated in favour of \"Aribtrb15525p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_525p")]
        CoppProtectionStandardAribtrb15525p = 0x1000,
        [Obsolete("Deprecated in favour of \"Aribtrb15750p\"")]
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_750p")]
        CoppProtectionStandardAribtrb15750p = 0x2000,
        [Obsolete("Deprecated in favour of \"Aribtrb151125i\"")]
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_1125i")]
        CoppProtectionStandardAribtrb151125i = 0x4000,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "COPP_ProtectionStandard_Mask")]
        CoppProtectionStandardMask = unchecked((int) 0xFFFFFFFF80007FFF),
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "COPP_ProtectionStandard_Reserved")]
        CoppProtectionStandardReserved = 0x7FFF8000,
        [NativeName("Name", "COPP_ProtectionStandard_Unknown")]
        Unknown = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "COPP_ProtectionStandard_None")]
        None = 0x0,
        [NativeName("Name", "COPP_ProtectionStandard_IEC61880_525i")]
        Iec61880525i = 0x1,
        [NativeName("Name", "COPP_ProtectionStandard_IEC61880_2_525i")]
        Iec618802525i = 0x2,
        [NativeName("Name", "COPP_ProtectionStandard_IEC62375_625p")]
        Iec62375625p = 0x4,
        [NativeName("Name", "COPP_ProtectionStandard_EIA608B_525")]
        Eia608B525 = 0x8,
        [NativeName("Name", "COPP_ProtectionStandard_EN300294_625i")]
        EN300294625i = 0x10,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_525p")]
        Cea805ATypeA525p = 0x20,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_750p")]
        Cea805ATypeA750p = 0x40,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeA_1125i")]
        Cea805ATypeA1125i = 0x80,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_525p")]
        Cea805ATypeB525p = 0x100,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_750p")]
        Cea805ATypeB750p = 0x200,
        [NativeName("Name", "COPP_ProtectionStandard_CEA805A_TypeB_1125i")]
        Cea805ATypeB1125i = 0x400,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_525i")]
        Aribtrb15525i = 0x800,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_525p")]
        Aribtrb15525p = 0x1000,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_750p")]
        Aribtrb15750p = 0x2000,
        [NativeName("Name", "COPP_ProtectionStandard_ARIBTRB15_1125i")]
        Aribtrb151125i = 0x4000,
        [NativeName("Name", "COPP_ProtectionStandard_Mask")]
        Mask = unchecked((int) 0xFFFFFFFF80007FFF),
        [NativeName("Name", "COPP_ProtectionStandard_Reserved")]
        Reserved = 0x7FFF8000,
    }
}
