// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS"]/*' />
[Flags]
public enum BINDINFO_OPTIONS
{
    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_WININETFLAG"]/*' />
    BINDINFO_OPTIONS_WININETFLAG = 0x10000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_ENABLE_UTF8"]/*' />
    BINDINFO_OPTIONS_ENABLE_UTF8 = 0x20000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_DISABLE_UTF8"]/*' />
    BINDINFO_OPTIONS_DISABLE_UTF8 = 0x40000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_USE_IE_ENCODING"]/*' />
    BINDINFO_OPTIONS_USE_IE_ENCODING = 0x80000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_BINDTOOBJECT"]/*' />
    BINDINFO_OPTIONS_BINDTOOBJECT = 0x100000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_SECURITYOPTOUT"]/*' />
    BINDINFO_OPTIONS_SECURITYOPTOUT = 0x200000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_IGNOREMIMETEXTPLAIN"]/*' />
    BINDINFO_OPTIONS_IGNOREMIMETEXTPLAIN = 0x400000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_USEBINDSTRINGCREDS"]/*' />
    BINDINFO_OPTIONS_USEBINDSTRINGCREDS = 0x800000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_IGNOREHTTPHTTPSREDIRECTS"]/*' />
    BINDINFO_OPTIONS_IGNOREHTTPHTTPSREDIRECTS = 0x1000000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_IGNORE_SSLERRORS_ONCE"]/*' />
    BINDINFO_OPTIONS_IGNORE_SSLERRORS_ONCE = 0x2000000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_WPC_DOWNLOADBLOCKED"]/*' />
    BINDINFO_WPC_DOWNLOADBLOCKED = 0x8000000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_WPC_LOGGING_ENABLED"]/*' />
    BINDINFO_WPC_LOGGING_ENABLED = 0x10000000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_ALLOWCONNECTDATA"]/*' />
    BINDINFO_OPTIONS_ALLOWCONNECTDATA = 0x20000000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_DISABLEAUTOREDIRECTS"]/*' />
    BINDINFO_OPTIONS_DISABLEAUTOREDIRECTS = 0x40000000,

    /// <include file='BINDINFO_OPTIONS.xml' path='doc/member[@name="BINDINFO_OPTIONS.BINDINFO_OPTIONS_SHDOCVW_NAVIGATE"]/*' />
    BINDINFO_OPTIONS_SHDOCVW_NAVIGATE = unchecked((int)(0x80000000)),
}
