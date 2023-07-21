// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_IP_VERSION.xml' path='doc/member[@name="WS_IP_VERSION"]/*' />
public enum WS_IP_VERSION
{
    /// <include file='WS_IP_VERSION.xml' path='doc/member[@name="WS_IP_VERSION.WS_IP_VERSION_4"]/*' />
    WS_IP_VERSION_4 = 1,

    /// <include file='WS_IP_VERSION.xml' path='doc/member[@name="WS_IP_VERSION.WS_IP_VERSION_6"]/*' />
    WS_IP_VERSION_6 = 2,

    /// <include file='WS_IP_VERSION.xml' path='doc/member[@name="WS_IP_VERSION.WS_IP_VERSION_AUTO"]/*' />
    WS_IP_VERSION_AUTO = 3,
}
