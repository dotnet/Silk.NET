// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR"]/*' />
public unsafe partial struct CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR
{
    /// <include file='CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.dwFieldID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFieldID;

    /// <include file='CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.cpft"]/*' />
    public CREDENTIAL_PROVIDER_FIELD_TYPE cpft;

    /// <include file='CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.pszLabel"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszLabel;

    /// <include file='CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR.guidFieldType"]/*' />
    public Guid guidFieldType;
}
