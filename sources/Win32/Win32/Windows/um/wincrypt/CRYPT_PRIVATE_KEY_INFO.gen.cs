// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_PRIVATE_KEY_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;
    public CRYPT_ALGORITHM_IDENTIFIER Algorithm;

    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB PrivateKey;

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* pAttributes;
}
