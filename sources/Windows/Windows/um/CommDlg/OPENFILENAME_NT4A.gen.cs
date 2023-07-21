// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A"]/*' />
public unsafe partial struct OPENFILENAME_NT4A
{
    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrFilter"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrFilter;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrCustomFilter"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrCustomFilter;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.nMaxCustFilter"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxCustFilter;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.nFilterIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFilterIndex;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrFile"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFile;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.nMaxFile"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxFile;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrFileTitle"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpstrFileTitle;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.nMaxFileTitle"]/*' />
    [NativeTypeName("DWORD")]
    public uint nMaxFileTitle;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrInitialDir"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrInitialDir;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrTitle;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.nFileOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFileOffset;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.nFileExtension"]/*' />
    [NativeTypeName("WORD")]
    public ushort nFileExtension;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpstrDefExt"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstrDefExt;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lCustData"]/*' />
    public LPARAM lCustData;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpfnHook"]/*' />
    [NativeTypeName("LPOFNHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    /// <include file='OPENFILENAME_NT4A.xml' path='doc/member[@name="OPENFILENAME_NT4A.lpTemplateName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
}
