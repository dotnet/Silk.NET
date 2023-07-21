// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO"]/*' />
public unsafe partial struct CERT_REVOCATION_INFO
{
    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.dwRevocationResult"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRevocationResult;

    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.pszRevocationOid"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszRevocationOid;

    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.pvOidSpecificInfo"]/*' />
    [NativeTypeName("LPVOID")]
    public void* pvOidSpecificInfo;

    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.fHasFreshnessTime"]/*' />
    public BOOL fHasFreshnessTime;

    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.dwFreshnessTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFreshnessTime;

    /// <include file='CERT_REVOCATION_INFO.xml' path='doc/member[@name="CERT_REVOCATION_INFO.pCrlInfo"]/*' />
    [NativeTypeName("PCERT_REVOCATION_CRL_INFO")]
    public CERT_REVOCATION_CRL_INFO* pCrlInfo;
}
