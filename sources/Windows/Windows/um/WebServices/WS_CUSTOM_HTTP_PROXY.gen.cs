// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_CUSTOM_HTTP_PROXY.xml' path='doc/member[@name="WS_CUSTOM_HTTP_PROXY"]/*' />
public partial struct WS_CUSTOM_HTTP_PROXY
{
    /// <include file='WS_CUSTOM_HTTP_PROXY.xml' path='doc/member[@name="WS_CUSTOM_HTTP_PROXY.servers"]/*' />
    public WS_STRING servers;

    /// <include file='WS_CUSTOM_HTTP_PROXY.xml' path='doc/member[@name="WS_CUSTOM_HTTP_PROXY.bypass"]/*' />
    public WS_STRING bypass;
}
