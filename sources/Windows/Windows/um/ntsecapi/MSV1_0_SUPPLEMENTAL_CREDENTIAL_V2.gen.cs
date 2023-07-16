// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2"]/*'/>
public unsafe partial struct MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2
{
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.Version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Version;
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.NtPassword"]/*'/>
    [NativeTypeName("UCHAR[16]")]
    public fixed byte NtPassword[16];
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V2.CredentialKey"]/*'/>
    public MSV1_0_CREDENTIAL_KEY CredentialKey;
}