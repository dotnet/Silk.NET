// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_AUTHORITY_KEY_ID_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID_INFO"]/*' />
public partial struct CERT_AUTHORITY_KEY_ID_INFO
{
    /// <include file='CERT_AUTHORITY_KEY_ID_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID_INFO.KeyId"]/*' />
    public CRYPT_DATA_BLOB KeyId;

    /// <include file='CERT_AUTHORITY_KEY_ID_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID_INFO.CertIssuer"]/*' />
    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB CertIssuer;

    /// <include file='CERT_AUTHORITY_KEY_ID_INFO.xml' path='doc/member[@name="CERT_AUTHORITY_KEY_ID_INFO.CertSerialNumber"]/*' />
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB CertSerialNumber;
}
