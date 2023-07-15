// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PUAF.xml' path='doc/member[@name="PUAF"]/*'/>
[Flags]
public enum PUAF
{
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_DEFAULT"]/*'/>
    PUAF_DEFAULT = 0,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_NOUI"]/*'/>
    PUAF_NOUI = 0x1,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_ISFILE"]/*'/>
    PUAF_ISFILE = 0x2,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_WARN_IF_DENIED"]/*'/>
    PUAF_WARN_IF_DENIED = 0x4,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_FORCEUI_FOREGROUND"]/*'/>
    PUAF_FORCEUI_FOREGROUND = 0x8,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_CHECK_TIFS"]/*'/>
    PUAF_CHECK_TIFS = 0x10,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_DONTCHECKBOXINDIALOG"]/*'/>
    PUAF_DONTCHECKBOXINDIALOG = 0x20,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_TRUSTED"]/*'/>
    PUAF_TRUSTED = 0x40,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_ACCEPT_WILDCARD_SCHEME"]/*'/>
    PUAF_ACCEPT_WILDCARD_SCHEME = 0x80,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_ENFORCERESTRICTED"]/*'/>
    PUAF_ENFORCERESTRICTED = 0x100,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_NOSAVEDFILECHECK"]/*'/>
    PUAF_NOSAVEDFILECHECK = 0x200,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_REQUIRESAVEDFILECHECK"]/*'/>
    PUAF_REQUIRESAVEDFILECHECK = 0x400,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_DONT_USE_CACHE"]/*'/>
    PUAF_DONT_USE_CACHE = 0x1000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_RESERVED1"]/*'/>
    PUAF_RESERVED1 = 0x2000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_RESERVED2"]/*'/>
    PUAF_RESERVED2 = 0x4000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_LMZ_UNLOCKED"]/*'/>
    PUAF_LMZ_UNLOCKED = 0x10000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_LMZ_LOCKED"]/*'/>
    PUAF_LMZ_LOCKED = 0x20000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_DEFAULTZONEPOL"]/*'/>
    PUAF_DEFAULTZONEPOL = 0x40000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_NPL_USE_LOCKED_IF_RESTRICTED"]/*'/>
    PUAF_NPL_USE_LOCKED_IF_RESTRICTED = 0x80000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_NOUIIFLOCKED"]/*'/>
    PUAF_NOUIIFLOCKED = 0x100000,
    /// <include file='PUAF.xml' path='doc/member[@name="PUAF.PUAF_DRAGPROTOCOLCHECK"]/*'/>
    PUAF_DRAGPROTOCOLCHECK = 0x200000,
}