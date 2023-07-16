// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST"]/*'/>
public unsafe partial struct CRYPT_TIMESTAMP_REQUEST
{
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.HashedMessage"]/*'/>
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB HashedMessage;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.pszTSAPolicyId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszTSAPolicyId;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.Nonce"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB Nonce;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.fCertReq"]/*'/>
    public BOOL fCertReq;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='CRYPT_TIMESTAMP_REQUEST.xml' path='doc/member[@name="CRYPT_TIMESTAMP_REQUEST.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}