// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_ECC_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ECC_PRIVATE_KEY_INFO"]/*' />
public unsafe partial struct CRYPT_ECC_PRIVATE_KEY_INFO
{
    /// <include file='CRYPT_ECC_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ECC_PRIVATE_KEY_INFO.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='CRYPT_ECC_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ECC_PRIVATE_KEY_INFO.PrivateKey"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB PrivateKey;

    /// <include file='CRYPT_ECC_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ECC_PRIVATE_KEY_INFO.szCurveOid"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* szCurveOid;

    /// <include file='CRYPT_ECC_PRIVATE_KEY_INFO.xml' path='doc/member[@name="CRYPT_ECC_PRIVATE_KEY_INFO.PublicKey"]/*' />
    public CRYPT_BIT_BLOB PublicKey;
}
