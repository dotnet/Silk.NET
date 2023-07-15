// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SSL_CREDENTIAL_CERTIFICATE.xml' path='doc/member[@name="SSL_CREDENTIAL_CERTIFICATE"]/*'/>
public unsafe partial struct SSL_CREDENTIAL_CERTIFICATE
{
    /// <include file='SSL_CREDENTIAL_CERTIFICATE.xml' path='doc/member[@name="SSL_CREDENTIAL_CERTIFICATE.cbPrivateKey"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbPrivateKey;
    /// <include file='SSL_CREDENTIAL_CERTIFICATE.xml' path='doc/member[@name="SSL_CREDENTIAL_CERTIFICATE.pPrivateKey"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pPrivateKey;
    /// <include file='SSL_CREDENTIAL_CERTIFICATE.xml' path='doc/member[@name="SSL_CREDENTIAL_CERTIFICATE.cbCertificate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCertificate;
    /// <include file='SSL_CREDENTIAL_CERTIFICATE.xml' path='doc/member[@name="SSL_CREDENTIAL_CERTIFICATE.pCertificate"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pCertificate;
    /// <include file='SSL_CREDENTIAL_CERTIFICATE.xml' path='doc/member[@name="SSL_CREDENTIAL_CERTIFICATE.pszPassword"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* pszPassword;
}