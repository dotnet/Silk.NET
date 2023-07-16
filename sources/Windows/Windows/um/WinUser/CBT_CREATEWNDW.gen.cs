// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CBT_CREATEWNDW.xml' path='doc/member[@name="CBT_CREATEWNDW"]/*'/>
public unsafe partial struct CBT_CREATEWNDW
{
    /// <include file='CBT_CREATEWNDW.xml' path='doc/member[@name="CBT_CREATEWNDW.lpcs"]/*'/>
    [NativeTypeName("struct tagCREATESTRUCTW *")]
    public CREATESTRUCTW* lpcs;
    /// <include file='CBT_CREATEWNDW.xml' path='doc/member[@name="CBT_CREATEWNDW.hwndInsertAfter"]/*'/>
    public HWND hwndInsertAfter;
}