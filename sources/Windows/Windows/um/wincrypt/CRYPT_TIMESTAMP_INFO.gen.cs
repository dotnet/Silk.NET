// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO"]/*' />
public unsafe partial struct CRYPT_TIMESTAMP_INFO
{
    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.pszTSAPolicyId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszTSAPolicyId;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.HashAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.HashedMessage"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB HashedMessage;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.SerialNumber"]/*' />
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SerialNumber;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.ftTime"]/*' />
    public FILETIME ftTime;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.pvAccuracy"]/*' />
    [NativeTypeName("PCRYPT_TIMESTAMP_ACCURACY")]
    public CRYPT_TIMESTAMP_ACCURACY* pvAccuracy;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.fOrdering"]/*' />
    public BOOL fOrdering;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.Nonce"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB Nonce;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.Tsa"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB Tsa;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.cExtension"]/*' />
    [NativeTypeName("DWORD")]
    public uint cExtension;

    /// <include file='CRYPT_TIMESTAMP_INFO.xml' path='doc/member[@name="CRYPT_TIMESTAMP_INFO.rgExtension"]/*' />
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
