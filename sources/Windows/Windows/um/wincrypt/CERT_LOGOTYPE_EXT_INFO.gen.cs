// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO"]/*' />
public unsafe partial struct CERT_LOGOTYPE_EXT_INFO
{
    /// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO.cCommunityLogo"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCommunityLogo;

    /// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO.rgCommunityLogo"]/*' />
    [NativeTypeName("PCERT_LOGOTYPE_INFO")]
    public CERT_LOGOTYPE_INFO* rgCommunityLogo;

    /// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO.pIssuerLogo"]/*' />
    [NativeTypeName("PCERT_LOGOTYPE_INFO")]
    public CERT_LOGOTYPE_INFO* pIssuerLogo;

    /// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO.pSubjectLogo"]/*' />
    [NativeTypeName("PCERT_LOGOTYPE_INFO")]
    public CERT_LOGOTYPE_INFO* pSubjectLogo;

    /// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO.cOtherLogo"]/*' />
    [NativeTypeName("DWORD")]
    public uint cOtherLogo;

    /// <include file='CERT_LOGOTYPE_EXT_INFO.xml' path='doc/member[@name="CERT_LOGOTYPE_EXT_INFO.rgOtherLogo"]/*' />
    [NativeTypeName("PCERT_OTHER_LOGOTYPE_INFO")]
    public CERT_OTHER_LOGOTYPE_INFO* rgOtherLogo;
}
