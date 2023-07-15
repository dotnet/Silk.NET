// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA"]/*'/>
public unsafe partial struct WNDCLASSEXA
{
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.style"]/*'/>
    public uint style;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.lpfnWndProc"]/*'/>
    [NativeTypeName("WNDPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpfnWndProc;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.cbClsExtra"]/*'/>
    public int cbClsExtra;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.cbWndExtra"]/*'/>
    public int cbWndExtra;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hIcon"]/*'/>
    public HICON hIcon;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hCursor"]/*'/>
    public HCURSOR hCursor;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hbrBackground"]/*'/>
    public HBRUSH hbrBackground;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.lpszMenuName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszMenuName;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.lpszClassName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszClassName;
    /// <include file='WNDCLASSEXA.xml' path='doc/member[@name="WNDCLASSEXA.hIconSm"]/*'/>
    public HICON hIconSm;
}