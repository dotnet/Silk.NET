// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO"]/*' />
public unsafe partial struct CERT_PHYSICAL_STORE_INFO
{
    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.pszOpenStoreProvider"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszOpenStoreProvider;

    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.dwOpenEncodingType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOpenEncodingType;

    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.dwOpenFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOpenFlags;

    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.OpenParameters"]/*' />
    public CRYPT_DATA_BLOB OpenParameters;

    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='CERT_PHYSICAL_STORE_INFO.xml' path='doc/member[@name="CERT_PHYSICAL_STORE_INFO.dwPriority"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPriority;
}
