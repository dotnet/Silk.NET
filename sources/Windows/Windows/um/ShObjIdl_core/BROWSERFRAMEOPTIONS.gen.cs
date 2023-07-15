// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS"]/*'/>
[Flags]
public enum BROWSERFRAMEOPTIONS
{
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_NONE"]/*'/>
    BFO_NONE = 0,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_BROWSER_PERSIST_SETTINGS"]/*'/>
    BFO_BROWSER_PERSIST_SETTINGS = 0x1,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_RENAME_FOLDER_OPTIONS_TOINTERNET"]/*'/>
    BFO_RENAME_FOLDER_OPTIONS_TOINTERNET = 0x2,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_BOTH_OPTIONS"]/*'/>
    BFO_BOTH_OPTIONS = 0x4,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BIF_PREFER_INTERNET_SHORTCUT"]/*'/>
    BIF_PREFER_INTERNET_SHORTCUT = 0x8,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_BROWSE_NO_IN_NEW_PROCESS"]/*'/>
    BFO_BROWSE_NO_IN_NEW_PROCESS = 0x10,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_ENABLE_HYPERLINK_TRACKING"]/*'/>
    BFO_ENABLE_HYPERLINK_TRACKING = 0x20,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_USE_IE_OFFLINE_SUPPORT"]/*'/>
    BFO_USE_IE_OFFLINE_SUPPORT = 0x40,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_SUBSTITUE_INTERNET_START_PAGE"]/*'/>
    BFO_SUBSTITUE_INTERNET_START_PAGE = 0x80,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_USE_IE_LOGOBANDING"]/*'/>
    BFO_USE_IE_LOGOBANDING = 0x100,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_ADD_IE_TOCAPTIONBAR"]/*'/>
    BFO_ADD_IE_TOCAPTIONBAR = 0x200,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_USE_DIALUP_REF"]/*'/>
    BFO_USE_DIALUP_REF = 0x400,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_USE_IE_TOOLBAR"]/*'/>
    BFO_USE_IE_TOOLBAR = 0x800,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_NO_PARENT_FOLDER_SUPPORT"]/*'/>
    BFO_NO_PARENT_FOLDER_SUPPORT = 0x1000,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_NO_REOPEN_NEXT_RESTART"]/*'/>
    BFO_NO_REOPEN_NEXT_RESTART = 0x2000,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_GO_HOME_PAGE"]/*'/>
    BFO_GO_HOME_PAGE = 0x4000,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_PREFER_IEPROCESS"]/*'/>
    BFO_PREFER_IEPROCESS = 0x8000,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_SHOW_NAVIGATION_CANCELLED"]/*'/>
    BFO_SHOW_NAVIGATION_CANCELLED = 0x10000,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_USE_IE_STATUSBAR"]/*'/>
    BFO_USE_IE_STATUSBAR = 0x20000,
    /// <include file='BROWSERFRAMEOPTIONS.xml' path='doc/member[@name="BROWSERFRAMEOPTIONS.BFO_QUERY_ALL"]/*'/>
    BFO_QUERY_ALL = unchecked((int)(0xffffffff)),
}