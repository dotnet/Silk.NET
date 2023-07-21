// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_THUMBPRINT_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_THUMBPRINT_CERT_CREDENTIAL"]/*' />
public partial struct WS_THUMBPRINT_CERT_CREDENTIAL
{
    /// <include file='WS_THUMBPRINT_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_THUMBPRINT_CERT_CREDENTIAL.credential"]/*' />
    public WS_CERT_CREDENTIAL credential;

    /// <include file='WS_THUMBPRINT_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_THUMBPRINT_CERT_CREDENTIAL.storeLocation"]/*' />
    [NativeTypeName("ULONG")]
    public uint storeLocation;

    /// <include file='WS_THUMBPRINT_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_THUMBPRINT_CERT_CREDENTIAL.storeName"]/*' />
    public WS_STRING storeName;

    /// <include file='WS_THUMBPRINT_CERT_CREDENTIAL.xml' path='doc/member[@name="WS_THUMBPRINT_CERT_CREDENTIAL.thumbprint"]/*' />
    public WS_STRING thumbprint;
}
