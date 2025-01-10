// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_PKCS8_EXPORT_PARAMS
{
    public HCRYPTPROV hCryptProv;

    [NativeTypeName("DWORD")]
    public uint dwKeySpec;

    [NativeTypeName("LPSTR")]
    public sbyte* pszPrivateKeyObjId;

    [NativeTypeName("PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC")]
    public delegate* unmanaged<
        CRYPT_ALGORITHM_IDENTIFIER*,
        CRYPT_DATA_BLOB*,
        byte*,
        uint*,
        void*,
        BOOL> pEncryptPrivateKeyFunc;

    [NativeTypeName("LPVOID")]
    public void* pVoidEncryptFunc;
}
