// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ShellFolderViewOptions
{
    SFVVO_SHOWALLOBJECTS = 0x1,
    SFVVO_SHOWEXTENSIONS = 0x2,
    SFVVO_SHOWCOMPCOLOR = 0x8,
    SFVVO_SHOWSYSFILES = 0x20,
    SFVVO_WIN95CLASSIC = 0x40,
    SFVVO_DOUBLECLICKINWEBVIEW = 0x80,
    SFVVO_DESKTOPHTML = 0x200,
}
