// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_APTTYPEQUALIFIER")]
    public enum Apttypequalifier : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_NONE")]
        ApttypequalifierNone = 0x0,
        [Obsolete("Deprecated in favour of \"ImplicitMta\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_IMPLICIT_MTA")]
        ApttypequalifierImplicitMta = 0x1,
        [Obsolete("Deprecated in favour of \"NAOnMta\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_MTA")]
        ApttypequalifierNAOnMta = 0x2,
        [Obsolete("Deprecated in favour of \"NAOnSta\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_STA")]
        ApttypequalifierNAOnSta = 0x3,
        [Obsolete("Deprecated in favour of \"NAOnImplicitMta\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA")]
        ApttypequalifierNAOnImplicitMta = 0x4,
        [Obsolete("Deprecated in favour of \"NAOnMainsta\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_MAINSTA")]
        ApttypequalifierNAOnMainsta = 0x5,
        [Obsolete("Deprecated in favour of \"ApplicationSta\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_APPLICATION_STA")]
        ApttypequalifierApplicationSta = 0x6,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "APTTYPEQUALIFIER_RESERVED_1")]
        ApttypequalifierReserved1 = 0x7,
        [NativeName("Name", "APTTYPEQUALIFIER_NONE")]
        None = 0x0,
        [NativeName("Name", "APTTYPEQUALIFIER_IMPLICIT_MTA")]
        ImplicitMta = 0x1,
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_MTA")]
        NAOnMta = 0x2,
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_STA")]
        NAOnSta = 0x3,
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA")]
        NAOnImplicitMta = 0x4,
        [NativeName("Name", "APTTYPEQUALIFIER_NA_ON_MAINSTA")]
        NAOnMainsta = 0x5,
        [NativeName("Name", "APTTYPEQUALIFIER_APPLICATION_STA")]
        ApplicationSta = 0x6,
        [NativeName("Name", "APTTYPEQUALIFIER_RESERVED_1")]
        Reserved1 = 0x7,
    }
}
