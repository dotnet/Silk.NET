// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW"]/*' />
public unsafe partial struct PARSEDURLW
{
    /// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW.pszProtocol"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszProtocol;

    /// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW.cchProtocol"]/*' />
    public uint cchProtocol;

    /// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW.pszSuffix"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszSuffix;

    /// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW.cchSuffix"]/*' />
    public uint cchSuffix;

    /// <include file='PARSEDURLW.xml' path='doc/member[@name="PARSEDURLW.nScheme"]/*' />
    public uint nScheme;
}
