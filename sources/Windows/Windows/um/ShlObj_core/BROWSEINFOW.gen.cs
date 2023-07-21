// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW"]/*' />
public unsafe partial struct BROWSEINFOW
{
    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.pidlRoot"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidlRoot;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.pszDisplayName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszDisplayName;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.lpszTitle"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* lpszTitle;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.ulFlags"]/*' />
    public uint ulFlags;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.lpfn"]/*' />
    [NativeTypeName("BFFCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, LPARAM, int> lpfn;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='BROWSEINFOW.xml' path='doc/member[@name="BROWSEINFOW.iImage"]/*' />
    public int iImage;
}
