// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_REQUEST_SECURITY_TOKEN_ACTION.xml' path='doc/member[@name="WS_REQUEST_SECURITY_TOKEN_ACTION"]/*'/>
public enum WS_REQUEST_SECURITY_TOKEN_ACTION
{
    /// <include file='WS_REQUEST_SECURITY_TOKEN_ACTION.xml' path='doc/member[@name="WS_REQUEST_SECURITY_TOKEN_ACTION.WS_REQUEST_SECURITY_TOKEN_ACTION_ISSUE"]/*'/>
    WS_REQUEST_SECURITY_TOKEN_ACTION_ISSUE = 1,
    /// <include file='WS_REQUEST_SECURITY_TOKEN_ACTION.xml' path='doc/member[@name="WS_REQUEST_SECURITY_TOKEN_ACTION.WS_REQUEST_SECURITY_TOKEN_ACTION_NEW_CONTEXT"]/*'/>
    WS_REQUEST_SECURITY_TOKEN_ACTION_NEW_CONTEXT = 2,
    /// <include file='WS_REQUEST_SECURITY_TOKEN_ACTION.xml' path='doc/member[@name="WS_REQUEST_SECURITY_TOKEN_ACTION.WS_REQUEST_SECURITY_TOKEN_ACTION_RENEW_CONTEXT"]/*'/>
    WS_REQUEST_SECURITY_TOKEN_ACTION_RENEW_CONTEXT = 3,
}