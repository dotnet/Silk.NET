// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_PKCS8_IMPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_IMPORT_PARAMS"]/*'/>
public unsafe partial struct CRYPT_PKCS8_IMPORT_PARAMS
{
    /// <include file='CRYPT_PKCS8_IMPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_IMPORT_PARAMS.PrivateKey"]/*'/>
    [NativeTypeName("CRYPT_DIGEST_BLOB")]
    public CRYPT_DATA_BLOB PrivateKey;
    /// <include file='CRYPT_PKCS8_IMPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_IMPORT_PARAMS.pResolvehCryptProvFunc"]/*'/>
    [NativeTypeName("PCRYPT_RESOLVE_HCRYPTPROV_FUNC")]
    public delegate* unmanaged<CRYPT_PRIVATE_KEY_INFO*, HCRYPTPROV*, void*, BOOL> pResolvehCryptProvFunc;
    /// <include file='CRYPT_PKCS8_IMPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_IMPORT_PARAMS.pVoidResolveFunc"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pVoidResolveFunc;
    /// <include file='CRYPT_PKCS8_IMPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_IMPORT_PARAMS.pDecryptPrivateKeyFunc"]/*'/>
    [NativeTypeName("PCRYPT_DECRYPT_PRIVATE_KEY_FUNC")]
    public delegate* unmanaged<CRYPT_ALGORITHM_IDENTIFIER, CRYPT_DATA_BLOB, byte*, uint*, void*, BOOL> pDecryptPrivateKeyFunc;
    /// <include file='CRYPT_PKCS8_IMPORT_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS8_IMPORT_PARAMS.pVoidDecryptFunc"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pVoidDecryptFunc;
}