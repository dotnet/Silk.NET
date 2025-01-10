// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_CERT_SIGNED_SAML_AUTHENTICATOR
{
    public WS_SAML_AUTHENTICATOR authenticator;

    [NativeTypeName("const struct _CERT_CONTEXT **")]
    public CERT_CONTEXT** trustedIssuerCerts;

    [NativeTypeName("ULONG")]
    public uint trustedIssuerCertCount;

    [NativeTypeName("const struct _CERT_CONTEXT *")]
    public CERT_CONTEXT* decryptionCert;

    [NativeTypeName("WS_VALIDATE_SAML_CALLBACK")]
    public delegate* unmanaged<void*, void*, void*, HRESULT> samlValidator;
    public void* samlValidatorCallbackState;
}
