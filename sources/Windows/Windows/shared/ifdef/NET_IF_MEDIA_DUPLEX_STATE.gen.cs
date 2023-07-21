// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NET_IF_MEDIA_DUPLEX_STATE.xml' path='doc/member[@name="NET_IF_MEDIA_DUPLEX_STATE"]/*' />
public enum NET_IF_MEDIA_DUPLEX_STATE
{
    /// <include file='NET_IF_MEDIA_DUPLEX_STATE.xml' path='doc/member[@name="NET_IF_MEDIA_DUPLEX_STATE.MediaDuplexStateUnknown"]/*' />
    MediaDuplexStateUnknown,

    /// <include file='NET_IF_MEDIA_DUPLEX_STATE.xml' path='doc/member[@name="NET_IF_MEDIA_DUPLEX_STATE.MediaDuplexStateHalf"]/*' />
    MediaDuplexStateHalf,

    /// <include file='NET_IF_MEDIA_DUPLEX_STATE.xml' path='doc/member[@name="NET_IF_MEDIA_DUPLEX_STATE.MediaDuplexStateFull"]/*' />
    MediaDuplexStateFull,
}
