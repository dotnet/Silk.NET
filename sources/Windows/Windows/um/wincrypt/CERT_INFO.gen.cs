// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO"]/*' />
public unsafe partial struct CERT_INFO
{
    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.SerialNumber"]/*' />
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SerialNumber;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.SignatureAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.Issuer"]/*' />
    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB Issuer;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.NotBefore"]/*' />
    public FILETIME NotBefore;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.NotAfter"]/*' />
    public FILETIME NotAfter;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.Subject"]/*' />
    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB Subject;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.SubjectPublicKeyInfo"]/*' />
    public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.IssuerUniqueId"]/*' />
    public CRYPT_BIT_BLOB IssuerUniqueId;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.SubjectUniqueId"]/*' />
    public CRYPT_BIT_BLOB SubjectUniqueId;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.cExtension"]/*' />
    [NativeTypeName("DWORD")]
    public uint cExtension;

    /// <include file='CERT_INFO.xml' path='doc/member[@name="CERT_INFO.rgExtension"]/*' />
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
