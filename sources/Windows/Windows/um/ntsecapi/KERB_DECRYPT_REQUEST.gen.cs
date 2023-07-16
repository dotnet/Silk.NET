// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST"]/*'/>
public unsafe partial struct KERB_DECRYPT_REQUEST
{
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.LogonId"]/*'/>
    public LUID LogonId;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.CryptoType"]/*'/>
    [NativeTypeName("LONG")]
    public int CryptoType;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.KeyUsage"]/*'/>
    [NativeTypeName("LONG")]
    public int KeyUsage;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.Key"]/*'/>
    public KERB_CRYPTO_KEY Key;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.EncryptedDataSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint EncryptedDataSize;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.InitialVectorSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint InitialVectorSize;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.InitialVector"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* InitialVector;
    /// <include file='KERB_DECRYPT_REQUEST.xml' path='doc/member[@name="KERB_DECRYPT_REQUEST.EncryptedData"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* EncryptedData;
}