// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA"]/*' />
public unsafe partial struct WNDCLASSA
{
    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.style"]/*' />
    public uint style;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.lpfnWndProc"]/*' />
    [NativeTypeName("WNDPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpfnWndProc;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.cbClsExtra"]/*' />
    public int cbClsExtra;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.cbWndExtra"]/*' />
    public int cbWndExtra;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.hCursor"]/*' />
    public HCURSOR hCursor;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.hbrBackground"]/*' />
    public HBRUSH hbrBackground;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.lpszMenuName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszMenuName;

    /// <include file='WNDCLASSA.xml' path='doc/member[@name="WNDCLASSA.lpszClassName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszClassName;
}
