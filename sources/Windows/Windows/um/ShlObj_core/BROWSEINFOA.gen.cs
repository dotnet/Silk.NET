// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA"]/*' />
public unsafe partial struct BROWSEINFOA
{
    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.pidlRoot"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidlRoot;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.pszDisplayName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszDisplayName;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.lpszTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpszTitle;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.ulFlags"]/*' />
    public uint ulFlags;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.lpfn"]/*' />
    [NativeTypeName("BFFCALLBACK")]
    public delegate* unmanaged<HWND, uint, LPARAM, LPARAM, int> lpfn;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='BROWSEINFOA.xml' path='doc/member[@name="BROWSEINFOA.iImage"]/*' />
    public int iImage;
}
