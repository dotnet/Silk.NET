// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL"]/*'/>
public unsafe partial struct MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL
{
    /// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.Version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Version;
    /// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.EncryptedCredsSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint EncryptedCredsSize;
    /// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.EncryptedCreds"]/*'/>
    [NativeTypeName("UCHAR[1]")]
    public fixed byte EncryptedCreds[1];
}