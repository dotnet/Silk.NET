// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SECURITY_TOKEN_REFERENCE_MODE.xml' path='doc/member[@name="WS_SECURITY_TOKEN_REFERENCE_MODE"]/*'/>
public enum WS_SECURITY_TOKEN_REFERENCE_MODE
{
    /// <include file='WS_SECURITY_TOKEN_REFERENCE_MODE.xml' path='doc/member[@name="WS_SECURITY_TOKEN_REFERENCE_MODE.WS_SECURITY_TOKEN_REFERENCE_MODE_LOCAL_ID"]/*'/>
    WS_SECURITY_TOKEN_REFERENCE_MODE_LOCAL_ID = 1,
    /// <include file='WS_SECURITY_TOKEN_REFERENCE_MODE.xml' path='doc/member[@name="WS_SECURITY_TOKEN_REFERENCE_MODE.WS_SECURITY_TOKEN_REFERENCE_MODE_XML_BUFFER"]/*'/>
    WS_SECURITY_TOKEN_REFERENCE_MODE_XML_BUFFER = 2,
    /// <include file='WS_SECURITY_TOKEN_REFERENCE_MODE.xml' path='doc/member[@name="WS_SECURITY_TOKEN_REFERENCE_MODE.WS_SECURITY_TOKEN_REFERENCE_MODE_CERT_THUMBPRINT"]/*'/>
    WS_SECURITY_TOKEN_REFERENCE_MODE_CERT_THUMBPRINT = 3,
    /// <include file='WS_SECURITY_TOKEN_REFERENCE_MODE.xml' path='doc/member[@name="WS_SECURITY_TOKEN_REFERENCE_MODE.WS_SECURITY_TOKEN_REFERENCE_MODE_SECURITY_CONTEXT_ID"]/*'/>
    WS_SECURITY_TOKEN_REFERENCE_MODE_SECURITY_CONTEXT_ID = 4,
    /// <include file='WS_SECURITY_TOKEN_REFERENCE_MODE.xml' path='doc/member[@name="WS_SECURITY_TOKEN_REFERENCE_MODE.WS_SECURITY_TOKEN_REFERENCE_MODE_SAML_ASSERTION_ID"]/*'/>
    WS_SECURITY_TOKEN_REFERENCE_MODE_SAML_ASSERTION_ID = 5,
}