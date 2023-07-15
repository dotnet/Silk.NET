// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_TIMESTAMP_PARA.xml' path='doc/member[@name="CRYPT_TIMESTAMP_PARA"]/*'/>
public unsafe partial struct CRYPT_TIMESTAMP_PARA
{
    /// <include file='CRYPT_TIMESTAMP_PARA.xml' path='doc/member[@name="CRYPT_TIMESTAMP_PARA.pszTSAPolicyId"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszTSAPolicyId;
    /// <include file='CRYPT_TIMESTAMP_PARA.xml' path='doc/member[@name="CRYPT_TIMESTAMP_PARA.fRequestCerts"]/*'/>
    public BOOL fRequestCerts;
    /// <include file='CRYPT_TIMESTAMP_PARA.xml' path='doc/member[@name="CRYPT_TIMESTAMP_PARA.Nonce"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB Nonce;
    /// <include file='CRYPT_TIMESTAMP_PARA.xml' path='doc/member[@name="CRYPT_TIMESTAMP_PARA.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='CRYPT_TIMESTAMP_PARA.xml' path='doc/member[@name="CRYPT_TIMESTAMP_PARA.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}