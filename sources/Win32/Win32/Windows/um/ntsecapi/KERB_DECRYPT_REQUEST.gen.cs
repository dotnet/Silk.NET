// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct KERB_DECRYPT_REQUEST
{
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    public LUID LogonId;

    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("LONG")]
    public int CryptoType;

    [NativeTypeName("LONG")]
    public int KeyUsage;
    public KERB_CRYPTO_KEY Key;

    [NativeTypeName("ULONG")]
    public uint EncryptedDataSize;

    [NativeTypeName("ULONG")]
    public uint InitialVectorSize;

    [NativeTypeName("PUCHAR")]
    public byte* InitialVector;

    [NativeTypeName("PUCHAR")]
    public byte* EncryptedData;
}
