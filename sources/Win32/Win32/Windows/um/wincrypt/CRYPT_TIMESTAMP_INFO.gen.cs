// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_TIMESTAMP_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("LPSTR")]
    public sbyte* pszTSAPolicyId;
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB HashedMessage;

    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SerialNumber;
    public FILETIME ftTime;

    [NativeTypeName("PCRYPT_TIMESTAMP_ACCURACY")]
    public CRYPT_TIMESTAMP_ACCURACY* pvAccuracy;
    public BOOL fOrdering;

    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB Nonce;

    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB Tsa;

    [NativeTypeName("DWORD")]
    public uint cExtension;

    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
