// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CMSG_ENCRYPTED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_ENCRYPTED_ENCODE_INFO"]/*'/>
public unsafe partial struct CMSG_ENCRYPTED_ENCODE_INFO
{
    /// <include file='CMSG_ENCRYPTED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_ENCRYPTED_ENCODE_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_ENCRYPTED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_ENCRYPTED_ENCODE_INFO.ContentEncryptionAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;
    /// <include file='CMSG_ENCRYPTED_ENCODE_INFO.xml' path='doc/member[@name="CMSG_ENCRYPTED_ENCODE_INFO.pvEncryptionAuxInfo"]/*'/>
    public void* pvEncryptionAuxInfo;
}