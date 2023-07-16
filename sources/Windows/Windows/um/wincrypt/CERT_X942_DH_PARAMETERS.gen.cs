// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_X942_DH_PARAMETERS.xml' path='doc/member[@name="CERT_X942_DH_PARAMETERS"]/*'/>
public unsafe partial struct CERT_X942_DH_PARAMETERS
{
    /// <include file='CERT_X942_DH_PARAMETERS.xml' path='doc/member[@name="CERT_X942_DH_PARAMETERS.p"]/*'/>
    [NativeTypeName("CRYPT_UINT_BLOB")]
    public CRYPT_DATA_BLOB p;
    /// <include file='CERT_X942_DH_PARAMETERS.xml' path='doc/member[@name="CERT_X942_DH_PARAMETERS.g"]/*'/>
    [NativeTypeName("CRYPT_UINT_BLOB")]
    public CRYPT_DATA_BLOB g;
    /// <include file='CERT_X942_DH_PARAMETERS.xml' path='doc/member[@name="CERT_X942_DH_PARAMETERS.q"]/*'/>
    [NativeTypeName("CRYPT_UINT_BLOB")]
    public CRYPT_DATA_BLOB q;
    /// <include file='CERT_X942_DH_PARAMETERS.xml' path='doc/member[@name="CERT_X942_DH_PARAMETERS.j"]/*'/>
    [NativeTypeName("CRYPT_UINT_BLOB")]
    public CRYPT_DATA_BLOB j;
    /// <include file='CERT_X942_DH_PARAMETERS.xml' path='doc/member[@name="CERT_X942_DH_PARAMETERS.pValidationParams"]/*'/>
    [NativeTypeName("PCERT_X942_DH_VALIDATION_PARAMS")]
    public CERT_X942_DH_VALIDATION_PARAMS* pValidationParams;
}