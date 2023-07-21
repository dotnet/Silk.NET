// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION"]/*' />
public unsafe partial struct CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION
{
    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.ulAuthenticationPackage"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAuthenticationPackage;

    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.clsidCredentialProvider"]/*' />
    public Guid clsidCredentialProvider;

    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.cbSerialization"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSerialization;

    /// <include file='CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION.rgbSerialization"]/*' />
    public byte* rgbSerialization;
}
