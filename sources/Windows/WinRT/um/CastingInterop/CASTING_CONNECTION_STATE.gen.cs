// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.WinRT;

/// <include file='CASTING_CONNECTION_STATE.xml' path='doc/member[@name="CASTING_CONNECTION_STATE"]/*' />
public enum CASTING_CONNECTION_STATE
{
    /// <include file='CASTING_CONNECTION_STATE.xml' path='doc/member[@name="CASTING_CONNECTION_STATE.CASTING_CONNECTION_STATE_DISCONNECTED"]/*' />
    CASTING_CONNECTION_STATE_DISCONNECTED = 0,

    /// <include file='CASTING_CONNECTION_STATE.xml' path='doc/member[@name="CASTING_CONNECTION_STATE.CASTING_CONNECTION_STATE_CONNECTED"]/*' />
    CASTING_CONNECTION_STATE_CONNECTED = 1,

    /// <include file='CASTING_CONNECTION_STATE.xml' path='doc/member[@name="CASTING_CONNECTION_STATE.CASTING_CONNECTION_STATE_RENDERING"]/*' />
    CASTING_CONNECTION_STATE_RENDERING = 2,

    /// <include file='CASTING_CONNECTION_STATE.xml' path='doc/member[@name="CASTING_CONNECTION_STATE.CASTING_CONNECTION_STATE_DISCONNECTING"]/*' />
    CASTING_CONNECTION_STATE_DISCONNECTING = 3,

    /// <include file='CASTING_CONNECTION_STATE.xml' path='doc/member[@name="CASTING_CONNECTION_STATE.CASTING_CONNECTION_STATE_CONNECTING"]/*' />
    CASTING_CONNECTION_STATE_CONNECTING = 4,
}
