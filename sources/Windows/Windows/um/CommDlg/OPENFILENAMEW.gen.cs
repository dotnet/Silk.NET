// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW"]/*'/>
public unsafe partial struct OPENFILENAMEW
{
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrFilter"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrFilter;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrCustomFilter"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrCustomFilter;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.nMaxCustFilter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxCustFilter;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.nFilterIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFilterIndex;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrFile"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFile;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.nMaxFile"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxFile;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrFileTitle"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFileTitle;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.nMaxFileTitle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxFileTitle;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrInitialDir"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrInitialDir;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrTitle"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrTitle;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.nFileOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nFileOffset;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.nFileExtension"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nFileExtension;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpstrDefExt"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrDefExt;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpfnHook"]/*'/>
    [NativeTypeName("LPOFNHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.lpTemplateName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpTemplateName;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.pvReserved"]/*'/>
    public void* pvReserved;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='OPENFILENAMEW.xml' path='doc/member[@name="OPENFILENAMEW.FlagsEx"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FlagsEx;
}