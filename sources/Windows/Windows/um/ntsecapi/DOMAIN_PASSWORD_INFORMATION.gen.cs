// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DOMAIN_PASSWORD_INFORMATION.xml' path='doc/member[@name="DOMAIN_PASSWORD_INFORMATION"]/*' />
public partial struct DOMAIN_PASSWORD_INFORMATION
{
    /// <include file='DOMAIN_PASSWORD_INFORMATION.xml' path='doc/member[@name="DOMAIN_PASSWORD_INFORMATION.MinPasswordLength"]/*' />
    public ushort MinPasswordLength;

    /// <include file='DOMAIN_PASSWORD_INFORMATION.xml' path='doc/member[@name="DOMAIN_PASSWORD_INFORMATION.PasswordHistoryLength"]/*' />
    public ushort PasswordHistoryLength;

    /// <include file='DOMAIN_PASSWORD_INFORMATION.xml' path='doc/member[@name="DOMAIN_PASSWORD_INFORMATION.PasswordProperties"]/*' />
    [NativeTypeName("ULONG")]
    public uint PasswordProperties;

    /// <include file='DOMAIN_PASSWORD_INFORMATION.xml' path='doc/member[@name="DOMAIN_PASSWORD_INFORMATION.MaxPasswordAge"]/*' />
    public LARGE_INTEGER MaxPasswordAge;

    /// <include file='DOMAIN_PASSWORD_INFORMATION.xml' path='doc/member[@name="DOMAIN_PASSWORD_INFORMATION.MinPasswordAge"]/*' />
    public LARGE_INTEGER MinPasswordAge;
}
