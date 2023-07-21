// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION"]/*' />
public unsafe partial struct TRUSTED_DOMAIN_AUTH_INFORMATION
{
    /// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION.IncomingAuthInfos"]/*' />
    [NativeTypeName("ULONG")]
    public uint IncomingAuthInfos;

    /// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION.IncomingAuthenticationInformation"]/*' />
    [NativeTypeName("PLSA_AUTH_INFORMATION")]
    public LSA_AUTH_INFORMATION* IncomingAuthenticationInformation;

    /// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION.IncomingPreviousAuthenticationInformation"]/*' />
    [NativeTypeName("PLSA_AUTH_INFORMATION")]
    public LSA_AUTH_INFORMATION* IncomingPreviousAuthenticationInformation;

    /// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION.OutgoingAuthInfos"]/*' />
    [NativeTypeName("ULONG")]
    public uint OutgoingAuthInfos;

    /// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION.OutgoingAuthenticationInformation"]/*' />
    [NativeTypeName("PLSA_AUTH_INFORMATION")]
    public LSA_AUTH_INFORMATION* OutgoingAuthenticationInformation;

    /// <include file='TRUSTED_DOMAIN_AUTH_INFORMATION.xml' path='doc/member[@name="TRUSTED_DOMAIN_AUTH_INFORMATION.OutgoingPreviousAuthenticationInformation"]/*' />
    [NativeTypeName("PLSA_AUTH_INFORMATION")]
    public LSA_AUTH_INFORMATION* OutgoingPreviousAuthenticationInformation;
}
