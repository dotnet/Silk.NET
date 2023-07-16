// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR"]/*'/>
public unsafe partial struct WS_CERT_SIGNED_SAML_AUTHENTICATOR
{
    /// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR.authenticator"]/*'/>
    public WS_SAML_AUTHENTICATOR authenticator;
    /// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR.trustedIssuerCerts"]/*'/>
    [NativeTypeName("const struct _CERT_CONTEXT **")]
    public CERT_CONTEXT** trustedIssuerCerts;
    /// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR.trustedIssuerCertCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint trustedIssuerCertCount;
    /// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR.decryptionCert"]/*'/>
    [NativeTypeName("const struct _CERT_CONTEXT *")]
    public CERT_CONTEXT* decryptionCert;
    /// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR.samlValidator"]/*'/>
    [NativeTypeName("WS_VALIDATE_SAML_CALLBACK")]
    public delegate* unmanaged<void*, IntPtr, IntPtr, HRESULT> samlValidator;
    /// <include file='WS_CERT_SIGNED_SAML_AUTHENTICATOR.xml' path='doc/member[@name="WS_CERT_SIGNED_SAML_AUTHENTICATOR.samlValidatorCallbackState"]/*'/>
    public void* samlValidatorCallbackState;
}