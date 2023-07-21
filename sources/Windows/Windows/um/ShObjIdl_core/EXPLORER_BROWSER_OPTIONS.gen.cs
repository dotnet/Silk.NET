// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS"]/*' />
[Flags]
public enum EXPLORER_BROWSER_OPTIONS
{
    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_NONE"]/*' />
    EBO_NONE = 0,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_NAVIGATEONCE"]/*' />
    EBO_NAVIGATEONCE = 0x1,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_SHOWFRAMES"]/*' />
    EBO_SHOWFRAMES = 0x2,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_ALWAYSNAVIGATE"]/*' />
    EBO_ALWAYSNAVIGATE = 0x4,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_NOTRAVELLOG"]/*' />
    EBO_NOTRAVELLOG = 0x8,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_NOWRAPPERWINDOW"]/*' />
    EBO_NOWRAPPERWINDOW = 0x10,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_HTMLSHAREPOINTVIEW"]/*' />
    EBO_HTMLSHAREPOINTVIEW = 0x20,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_NOBORDER"]/*' />
    EBO_NOBORDER = 0x40,

    /// <include file='EXPLORER_BROWSER_OPTIONS.xml' path='doc/member[@name="EXPLORER_BROWSER_OPTIONS.EBO_NOPERSISTVIEWSTATE"]/*' />
    EBO_NOPERSISTVIEWSTATE = 0x80,
}
