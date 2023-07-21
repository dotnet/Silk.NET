// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions"]/*' />
public enum ShellFolderViewOptions
{
    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_SHOWALLOBJECTS"]/*' />
    SFVVO_SHOWALLOBJECTS = 0x1,

    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_SHOWEXTENSIONS"]/*' />
    SFVVO_SHOWEXTENSIONS = 0x2,

    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_SHOWCOMPCOLOR"]/*' />
    SFVVO_SHOWCOMPCOLOR = 0x8,

    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_SHOWSYSFILES"]/*' />
    SFVVO_SHOWSYSFILES = 0x20,

    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_WIN95CLASSIC"]/*' />
    SFVVO_WIN95CLASSIC = 0x40,

    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_DOUBLECLICKINWEBVIEW"]/*' />
    SFVVO_DOUBLECLICKINWEBVIEW = 0x80,

    /// <include file='ShellFolderViewOptions.xml' path='doc/member[@name="ShellFolderViewOptions.SFVVO_DESKTOPHTML"]/*' />
    SFVVO_DESKTOPHTML = 0x200,
}
