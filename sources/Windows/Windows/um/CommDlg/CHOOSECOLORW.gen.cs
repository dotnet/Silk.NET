// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW"]/*'/>
public unsafe partial struct CHOOSECOLORW
{
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.hInstance"]/*'/>
    public HWND hInstance;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.rgbResult"]/*'/>
    public COLORREF rgbResult;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.lpCustColors"]/*'/>
    public COLORREF* lpCustColors;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.lpfnHook"]/*'/>
    [NativeTypeName("LPCCHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='CHOOSECOLORW.xml' path='doc/member[@name="CHOOSECOLORW.lpTemplateName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpTemplateName;
}