// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_HASHED_URL.xml' path='doc/member[@name="CERT_HASHED_URL"]/*' />
public unsafe partial struct CERT_HASHED_URL
{
    /// <include file='CERT_HASHED_URL.xml' path='doc/member[@name="CERT_HASHED_URL.HashAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

    /// <include file='CERT_HASHED_URL.xml' path='doc/member[@name="CERT_HASHED_URL.Hash"]/*' />
    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB Hash;

    /// <include file='CERT_HASHED_URL.xml' path='doc/member[@name="CERT_HASHED_URL.pwszUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszUrl;
}
