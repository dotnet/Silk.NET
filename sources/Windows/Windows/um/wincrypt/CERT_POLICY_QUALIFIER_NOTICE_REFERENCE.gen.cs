// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_NOTICE_REFERENCE"]/*' />
public unsafe partial struct CERT_POLICY_QUALIFIER_NOTICE_REFERENCE
{
    /// <include file='CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.pszOrganization"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszOrganization;

    /// <include file='CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.cNoticeNumbers"]/*' />
    [NativeTypeName("DWORD")]
    public uint cNoticeNumbers;

    /// <include file='CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_NOTICE_REFERENCE.rgNoticeNumbers"]/*' />
    public int* rgNoticeNumbers;
}
