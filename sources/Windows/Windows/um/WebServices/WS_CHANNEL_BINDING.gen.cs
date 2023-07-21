// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_CHANNEL_BINDING.xml' path='doc/member[@name="WS_CHANNEL_BINDING"]/*' />
public enum WS_CHANNEL_BINDING
{
    /// <include file='WS_CHANNEL_BINDING.xml' path='doc/member[@name="WS_CHANNEL_BINDING.WS_HTTP_CHANNEL_BINDING"]/*' />
    WS_HTTP_CHANNEL_BINDING = 0,

    /// <include file='WS_CHANNEL_BINDING.xml' path='doc/member[@name="WS_CHANNEL_BINDING.WS_TCP_CHANNEL_BINDING"]/*' />
    WS_TCP_CHANNEL_BINDING = 1,

    /// <include file='WS_CHANNEL_BINDING.xml' path='doc/member[@name="WS_CHANNEL_BINDING.WS_UDP_CHANNEL_BINDING"]/*' />
    WS_UDP_CHANNEL_BINDING = 2,

    /// <include file='WS_CHANNEL_BINDING.xml' path='doc/member[@name="WS_CHANNEL_BINDING.WS_CUSTOM_CHANNEL_BINDING"]/*' />
    WS_CUSTOM_CHANNEL_BINDING = 3,

    /// <include file='WS_CHANNEL_BINDING.xml' path='doc/member[@name="WS_CHANNEL_BINDING.WS_NAMEDPIPE_CHANNEL_BINDING"]/*' />
    WS_NAMEDPIPE_CHANNEL_BINDING = 4,
}
