// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_SECURITY_TOKEN_REFERENCE_MODE
{
    WS_SECURITY_TOKEN_REFERENCE_MODE_LOCAL_ID = 1,
    WS_SECURITY_TOKEN_REFERENCE_MODE_XML_BUFFER = 2,
    WS_SECURITY_TOKEN_REFERENCE_MODE_CERT_THUMBPRINT = 3,
    WS_SECURITY_TOKEN_REFERENCE_MODE_SECURITY_CONTEXT_ID = 4,
    WS_SECURITY_TOKEN_REFERENCE_MODE_SAML_ASSERTION_ID = 5,
}
