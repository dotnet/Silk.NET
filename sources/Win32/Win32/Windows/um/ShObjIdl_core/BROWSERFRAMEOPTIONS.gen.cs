// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum BROWSERFRAMEOPTIONS
{
    BFO_NONE = 0,
    BFO_BROWSER_PERSIST_SETTINGS = 0x1,
    BFO_RENAME_FOLDER_OPTIONS_TOINTERNET = 0x2,
    BFO_BOTH_OPTIONS = 0x4,
    BIF_PREFER_INTERNET_SHORTCUT = 0x8,
    BFO_BROWSE_NO_IN_NEW_PROCESS = 0x10,
    BFO_ENABLE_HYPERLINK_TRACKING = 0x20,
    BFO_USE_IE_OFFLINE_SUPPORT = 0x40,
    BFO_SUBSTITUE_INTERNET_START_PAGE = 0x80,
    BFO_USE_IE_LOGOBANDING = 0x100,
    BFO_ADD_IE_TOCAPTIONBAR = 0x200,
    BFO_USE_DIALUP_REF = 0x400,
    BFO_USE_IE_TOOLBAR = 0x800,
    BFO_NO_PARENT_FOLDER_SUPPORT = 0x1000,
    BFO_NO_REOPEN_NEXT_RESTART = 0x2000,
    BFO_GO_HOME_PAGE = 0x4000,
    BFO_PREFER_IEPROCESS = 0x8000,
    BFO_SHOW_NAVIGATION_CANCELLED = 0x10000,
    BFO_USE_IE_STATUSBAR = 0x20000,
    BFO_QUERY_ALL = unchecked((int)(0xffffffff)),
}
