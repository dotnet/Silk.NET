// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public CRYPT_BIT_BLOB RecipientPublicKey;
    public CERT_ID RecipientId;
    public FILETIME Date;

    [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
    public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;
}
