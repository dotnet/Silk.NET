// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TTGETTITLE.xml' path='doc/member[@name="TTGETTITLE"]/*' />
public unsafe partial struct TTGETTITLE
{
    /// <include file='TTGETTITLE.xml' path='doc/member[@name="TTGETTITLE.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='TTGETTITLE.xml' path='doc/member[@name="TTGETTITLE.uTitleBitmap"]/*' />
    public uint uTitleBitmap;

    /// <include file='TTGETTITLE.xml' path='doc/member[@name="TTGETTITLE.cch"]/*' />
    public uint cch;

    /// <include file='TTGETTITLE.xml' path='doc/member[@name="TTGETTITLE.pszTitle"]/*' />
    [NativeTypeName("WCHAR *")]
    public ushort* pszTitle;
}
