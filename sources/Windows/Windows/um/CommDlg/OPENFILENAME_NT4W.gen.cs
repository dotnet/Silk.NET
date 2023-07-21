// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W"]/*' />
public unsafe partial struct OPENFILENAME_NT4W
{
    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrFilter"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrFilter;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrCustomFilter"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrCustomFilter;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.nMaxCustFilter"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxCustFilter;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.nFilterIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFilterIndex;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrFile"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFile;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.nMaxFile"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxFile;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrFileTitle"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFileTitle;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.nMaxFileTitle"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxFileTitle;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrInitialDir"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrInitialDir;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrTitle"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrTitle;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.nFileOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFileOffset;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.nFileExtension"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFileExtension;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpstrDefExt"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrDefExt;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lCustData"]/*' />
    public LPARAM lCustData;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpfnHook"]/*' />
    [NativeTypeName("LPOFNHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    /// <include file='OPENFILENAME_NT4W.xml' path='doc/member[@name="OPENFILENAME_NT4W.lpTemplateName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpTemplateName;
}
