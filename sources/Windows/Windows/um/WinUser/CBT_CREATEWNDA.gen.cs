// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CBT_CREATEWNDA.xml' path='doc/member[@name="CBT_CREATEWNDA"]/*' />
public unsafe partial struct CBT_CREATEWNDA
{
    /// <include file='CBT_CREATEWNDA.xml' path='doc/member[@name="CBT_CREATEWNDA.lpcs"]/*' />
    [NativeTypeName("struct tagCREATESTRUCTA *")]
    public CREATESTRUCTA* lpcs;

    /// <include file='CBT_CREATEWNDA.xml' path='doc/member[@name="CBT_CREATEWNDA.hwndInsertAfter"]/*' />
    public HWND hwndInsertAfter;
}
