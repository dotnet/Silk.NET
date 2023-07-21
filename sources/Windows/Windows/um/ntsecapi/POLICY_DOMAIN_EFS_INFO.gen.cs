// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_DOMAIN_EFS_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_EFS_INFO"]/*' />
public unsafe partial struct POLICY_DOMAIN_EFS_INFO
{
    /// <include file='POLICY_DOMAIN_EFS_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_EFS_INFO.InfoLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint InfoLength;

    /// <include file='POLICY_DOMAIN_EFS_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_EFS_INFO.EfsBlob"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* EfsBlob;
}
