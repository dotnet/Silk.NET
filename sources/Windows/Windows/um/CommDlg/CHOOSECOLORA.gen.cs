// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA"]/*'/>
public unsafe partial struct CHOOSECOLORA
{
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.hInstance"]/*'/>
    public HWND hInstance;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.rgbResult"]/*'/>
    public COLORREF rgbResult;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.lpCustColors"]/*'/>
    public COLORREF* lpCustColors;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.lpfnHook"]/*'/>
    [NativeTypeName("LPCCHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='CHOOSECOLORA.xml' path='doc/member[@name="CHOOSECOLORA.lpTemplateName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
}