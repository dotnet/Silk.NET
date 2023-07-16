// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA"]/*'/>
public unsafe partial struct CREATESTRUCTA
{
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.lpCreateParams"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpCreateParams;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.hMenu"]/*'/>
    public HMENU hMenu;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.hwndParent"]/*'/>
    public HWND hwndParent;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.cy"]/*'/>
    public int cy;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.cx"]/*'/>
    public int cx;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.y"]/*'/>
    public int y;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.x"]/*'/>
    public int x;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.style"]/*'/>
    [NativeTypeName("LONG")]
    public int style;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.lpszName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszName;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.lpszClass"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszClass;
    /// <include file='CREATESTRUCTA.xml' path='doc/member[@name="CREATESTRUCTA.dwExStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExStyle;
}