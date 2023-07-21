// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE"]/*' />
public enum WS_ENDPOINT_IDENTITY_TYPE
{
    /// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE.WS_DNS_ENDPOINT_IDENTITY_TYPE"]/*' />
    WS_DNS_ENDPOINT_IDENTITY_TYPE = 1,

    /// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE.WS_UPN_ENDPOINT_IDENTITY_TYPE"]/*' />
    WS_UPN_ENDPOINT_IDENTITY_TYPE = 2,

    /// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE.WS_SPN_ENDPOINT_IDENTITY_TYPE"]/*' />
    WS_SPN_ENDPOINT_IDENTITY_TYPE = 3,

    /// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE.WS_RSA_ENDPOINT_IDENTITY_TYPE"]/*' />
    WS_RSA_ENDPOINT_IDENTITY_TYPE = 4,

    /// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE.WS_CERT_ENDPOINT_IDENTITY_TYPE"]/*' />
    WS_CERT_ENDPOINT_IDENTITY_TYPE = 5,

    /// <include file='WS_ENDPOINT_IDENTITY_TYPE.xml' path='doc/member[@name="WS_ENDPOINT_IDENTITY_TYPE.WS_UNKNOWN_ENDPOINT_IDENTITY_TYPE"]/*' />
    WS_UNKNOWN_ENDPOINT_IDENTITY_TYPE = 6,
}
