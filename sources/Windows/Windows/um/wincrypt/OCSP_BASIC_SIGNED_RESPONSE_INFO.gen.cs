// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OCSP_BASIC_SIGNED_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_SIGNED_RESPONSE_INFO"]/*'/>
public partial struct OCSP_BASIC_SIGNED_RESPONSE_INFO
{
    /// <include file='OCSP_BASIC_SIGNED_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_SIGNED_RESPONSE_INFO.ToBeSigned"]/*'/>
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB ToBeSigned;
    /// <include file='OCSP_BASIC_SIGNED_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_SIGNED_RESPONSE_INFO.SignatureInfo"]/*'/>
    public OCSP_SIGNATURE_INFO SignatureInfo;
}