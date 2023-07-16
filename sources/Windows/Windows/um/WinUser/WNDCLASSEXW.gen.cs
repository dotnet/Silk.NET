// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW"]/*'/>
public unsafe partial struct WNDCLASSEXW
{
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.style"]/*'/>
    public uint style;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.lpfnWndProc"]/*'/>
    [NativeTypeName("WNDPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpfnWndProc;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.cbClsExtra"]/*'/>
    public int cbClsExtra;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.cbWndExtra"]/*'/>
    public int cbWndExtra;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.hIcon"]/*'/>
    public HICON hIcon;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.hCursor"]/*'/>
    public HCURSOR hCursor;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.hbrBackground"]/*'/>
    public HBRUSH hbrBackground;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.lpszMenuName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszMenuName;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.lpszClassName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszClassName;
    /// <include file='WNDCLASSEXW.xml' path='doc/member[@name="WNDCLASSEXW.hIconSm"]/*'/>
    public HICON hIconSm;
}