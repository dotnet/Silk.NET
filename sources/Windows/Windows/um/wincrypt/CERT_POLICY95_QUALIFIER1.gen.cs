// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_POLICY95_QUALIFIER1.xml' path='doc/member[@name="CERT_POLICY95_QUALIFIER1"]/*' />
public unsafe partial struct CERT_POLICY95_QUALIFIER1
{
    /// <include file='CERT_POLICY95_QUALIFIER1.xml' path='doc/member[@name="CERT_POLICY95_QUALIFIER1.pszPracticesReference"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszPracticesReference;

    /// <include file='CERT_POLICY95_QUALIFIER1.xml' path='doc/member[@name="CERT_POLICY95_QUALIFIER1.pszNoticeIdentifier"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszNoticeIdentifier;

    /// <include file='CERT_POLICY95_QUALIFIER1.xml' path='doc/member[@name="CERT_POLICY95_QUALIFIER1.pszNSINoticeIdentifier"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszNSINoticeIdentifier;

    /// <include file='CERT_POLICY95_QUALIFIER1.xml' path='doc/member[@name="CERT_POLICY95_QUALIFIER1.cCPSURLs"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCPSURLs;

    /// <include file='CERT_POLICY95_QUALIFIER1.xml' path='doc/member[@name="CERT_POLICY95_QUALIFIER1.rgCPSURLs"]/*' />
    public CPS_URLS* rgCPSURLs;
}
