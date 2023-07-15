// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW"]/*'/>
public unsafe partial struct WNDCLASSW
{
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.style"]/*'/>
    public uint style;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.lpfnWndProc"]/*'/>
    [NativeTypeName("WNDPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpfnWndProc;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.cbClsExtra"]/*'/>
    public int cbClsExtra;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.cbWndExtra"]/*'/>
    public int cbWndExtra;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hIcon"]/*'/>
    public HICON hIcon;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hCursor"]/*'/>
    public HCURSOR hCursor;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.hbrBackground"]/*'/>
    public HBRUSH hbrBackground;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.lpszMenuName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszMenuName;
    /// <include file='WNDCLASSW.xml' path='doc/member[@name="WNDCLASSW.lpszClassName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszClassName;
}