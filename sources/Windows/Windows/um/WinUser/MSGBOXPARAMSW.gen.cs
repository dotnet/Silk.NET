// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW"]/*' />
public unsafe partial struct MSGBOXPARAMSW
{
    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.cbSize"]/*' />
    public uint cbSize;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpszText"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszText;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpszCaption"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszCaption;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpszIcon"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszIcon;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.dwContextHelpId"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwContextHelpId;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.lpfnMsgBoxCallback"]/*' />
    [NativeTypeName("MSGBOXCALLBACK")]
    public delegate* unmanaged<HELPINFO*, void> lpfnMsgBoxCallback;

    /// <include file='MSGBOXPARAMSW.xml' path='doc/member[@name="MSGBOXPARAMSW.dwLanguageId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLanguageId;
}
