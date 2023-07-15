// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE"]/*'/>
public unsafe partial struct WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE
{
    /// <include file='WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.securityBindingProperties"]/*'/>
    public WS_SECURITY_BINDING_PROPERTIES securityBindingProperties;
    /// <include file='WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.clientCredential"]/*'/>
    public WS_USERNAME_CREDENTIAL* clientCredential;
    /// <include file='WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.passwordValidator"]/*'/>
    [NativeTypeName("WS_VALIDATE_PASSWORD_CALLBACK")]
    public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> passwordValidator;
    /// <include file='WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE.passwordValidatorCallbackState"]/*'/>
    public void* passwordValidatorCallbackState;
}