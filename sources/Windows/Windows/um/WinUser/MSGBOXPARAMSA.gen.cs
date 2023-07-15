// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA"]/*'/>
public unsafe partial struct MSGBOXPARAMSA
{
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpszText"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszText;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpszCaption"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszCaption;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpszIcon"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszIcon;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.dwContextHelpId"]/*'/>
    [NativeTypeName("DWORD_PTR")]
    public nuint dwContextHelpId;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.lpfnMsgBoxCallback"]/*'/>
    [NativeTypeName("MSGBOXCALLBACK")]
    public delegate* unmanaged<HELPINFO*, void> lpfnMsgBoxCallback;
    /// <include file='MSGBOXPARAMSA.xml' path='doc/member[@name="MSGBOXPARAMSA.dwLanguageId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLanguageId;
}