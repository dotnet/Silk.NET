// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3"]/*' />
public unsafe partial struct MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3
{
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.CredentialKeyType"]/*' />
    public MSV1_0_CREDENTIAL_KEY_TYPE CredentialKeyType;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.NtPassword"]/*' />
    [NativeTypeName("UCHAR[16]")]
    public fixed byte NtPassword[16];

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.CredentialKey"]/*' />
    public MSV1_0_CREDENTIAL_KEY CredentialKey;

    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3.ShaPassword"]/*' />
    [NativeTypeName("UCHAR[20]")]
    public fixed byte ShaPassword[20];
}
