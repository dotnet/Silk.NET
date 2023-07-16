// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_CUSTOM_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_CUSTOM_CERT_CREDENTIAL"]/*'/>
public unsafe partial struct WS_CUSTOM_CERT_CREDENTIAL
{
    /// <include file='WS_CUSTOM_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_CUSTOM_CERT_CREDENTIAL.credential"]/*'/>
    public WS_CERT_CREDENTIAL credential;
    /// <include file='WS_CUSTOM_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_CUSTOM_CERT_CREDENTIAL.getCertCallback"]/*'/>
    [NativeTypeName("WS_GET_CERT_CALLBACK")]
    public delegate* unmanaged<void*, WS_ENDPOINT_ADDRESS*, WS_STRING*, CERT_CONTEXT**, IntPtr, HRESULT> getCertCallback;
    /// <include file='WS_CUSTOM_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_CUSTOM_CERT_CREDENTIAL.getCertCallbackState"]/*'/>
    public void* getCertCallbackState;
    /// <include file='WS_CUSTOM_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_CUSTOM_CERT_CREDENTIAL.certIssuerListNotificationCallback"]/*'/>
    [NativeTypeName("WS_CERT_ISSUER_LIST_NOTIFICATION_CALLBACK")]
    public delegate* unmanaged<void*, SecPkgContext_IssuerListInfoEx*, IntPtr, HRESULT> certIssuerListNotificationCallback;
    /// <include file='WS_CUSTOM_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_CUSTOM_CERT_CREDENTIAL.certIssuerListNotificationCallbackState"]/*'/>
    public void* certIssuerListNotificationCallbackState;
}