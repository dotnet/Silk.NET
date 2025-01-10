// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_CUSTOM_CERT_CREDENTIAL
{
    public WS_CERT_CREDENTIAL credential;

    [NativeTypeName("WS_GET_CERT_CALLBACK")]
    public delegate* unmanaged<
        void*,
        WS_ENDPOINT_ADDRESS*,
        WS_STRING*,
        CERT_CONTEXT**,
        void*,
        HRESULT> getCertCallback;
    public void* getCertCallbackState;

    [NativeTypeName("WS_CERT_ISSUER_LIST_NOTIFICATION_CALLBACK")]
    public delegate* unmanaged<
        void*,
        SecPkgContext_IssuerListInfoEx*,
        void*,
        HRESULT> certIssuerListNotificationCallback;
    public void* certIssuerListNotificationCallbackState;
}
