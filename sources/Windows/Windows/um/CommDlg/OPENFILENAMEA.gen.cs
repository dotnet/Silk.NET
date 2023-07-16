// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA"]/*'/>
public unsafe partial struct OPENFILENAMEA
{
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.hwndOwner"]/*'/>
    public HWND hwndOwner;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.hInstance"]/*'/>
    public HINSTANCE hInstance;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrFilter"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrFilter;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrCustomFilter"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrCustomFilter;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.nMaxCustFilter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxCustFilter;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.nFilterIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFilterIndex;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrFile"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFile;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.nMaxFile"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxFile;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrFileTitle"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFileTitle;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.nMaxFileTitle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nMaxFileTitle;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrInitialDir"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrInitialDir;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrTitle"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrTitle;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.nFileOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nFileOffset;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.nFileExtension"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nFileExtension;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpstrDefExt"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrDefExt;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lCustData"]/*'/>
    public LPARAM lCustData;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpfnHook"]/*'/>
    [NativeTypeName("LPOFNHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.lpTemplateName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.pvReserved"]/*'/>
    public void* pvReserved;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='OPENFILENAMEA.xml' path='doc/member[@name="OPENFILENAMEA.FlagsEx"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FlagsEx;
}