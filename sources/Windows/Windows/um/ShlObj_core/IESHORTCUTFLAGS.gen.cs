// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IESHORTCUTFLAGS.xml' path='doc/member[@name="IESHORTCUTFLAGS"]/*'/>
public enum IESHORTCUTFLAGS
{
    /// <include file='IESHORTCUTFLAGS.xml' path='doc/member[@name="IESHORTCUTFLAGS.IESHORTCUT_NEWBROWSER"]/*'/>
    IESHORTCUT_NEWBROWSER = 0x01,
    /// <include file='IESHORTCUTFLAGS.xml' path='doc/member[@name="IESHORTCUTFLAGS.IESHORTCUT_OPENNEWTAB"]/*'/>
    IESHORTCUT_OPENNEWTAB = 0x02,
    /// <include file='IESHORTCUTFLAGS.xml' path='doc/member[@name="IESHORTCUTFLAGS.IESHORTCUT_FORCENAVIGATE"]/*'/>
    IESHORTCUT_FORCENAVIGATE = 0x04,
    /// <include file='IESHORTCUTFLAGS.xml' path='doc/member[@name="IESHORTCUTFLAGS.IESHORTCUT_BACKGROUNDTAB"]/*'/>
    IESHORTCUT_BACKGROUNDTAB = 0x08,
}