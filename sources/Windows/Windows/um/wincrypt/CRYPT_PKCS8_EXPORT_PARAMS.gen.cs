// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_PKCS8_EXPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_EXPORT_PARAMS"]/*' />
public unsafe partial struct CRYPT_PKCS8_EXPORT_PARAMS
{
    /// <include file='CRYPT_PKCS8_EXPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_EXPORT_PARAMS.hCryptProv"]/*' />
    public HCRYPTPROV hCryptProv;

    /// <include file='CRYPT_PKCS8_EXPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_EXPORT_PARAMS.dwKeySpec"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;

    /// <include file='CRYPT_PKCS8_EXPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_EXPORT_PARAMS.pszPrivateKeyObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszPrivateKeyObjId;

    /// <include file='CRYPT_PKCS8_EXPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_EXPORT_PARAMS.pEncryptPrivateKeyFunc"]/*' />
    [NativeTypeName("PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC")]
    public delegate* unmanaged<CRYPT_ALGORITHM_IDENTIFIER*, CRYPT_DATA_BLOB*, byte*, uint*, void*, BOOL> pEncryptPrivateKeyFunc;

    /// <include file='CRYPT_PKCS8_EXPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_EXPORT_PARAMS.pVoidEncryptFunc"]/*' />
    [NativeTypeName("LPVOID")]
    public void* pVoidEncryptFunc;
}
