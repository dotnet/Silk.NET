// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CMSG_MAIL_LIST_ENCRYPT_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;
    public CRYPT_DATA_BLOB EncryptedKey;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
