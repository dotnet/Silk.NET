// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_MESSAGE_STATE.xml' path='doc/member[@name="WS_MESSAGE_STATE"]/*' />
public enum WS_MESSAGE_STATE
{
    /// <include file='WS_MESSAGE_STATE.xml' path='doc/member[@name="WS_MESSAGE_STATE.WS_MESSAGE_STATE_EMPTY"]/*' />
    WS_MESSAGE_STATE_EMPTY = 1,

    /// <include file='WS_MESSAGE_STATE.xml' path='doc/member[@name="WS_MESSAGE_STATE.WS_MESSAGE_STATE_INITIALIZED"]/*' />
    WS_MESSAGE_STATE_INITIALIZED = 2,

    /// <include file='WS_MESSAGE_STATE.xml' path='doc/member[@name="WS_MESSAGE_STATE.WS_MESSAGE_STATE_READING"]/*' />
    WS_MESSAGE_STATE_READING = 3,

    /// <include file='WS_MESSAGE_STATE.xml' path='doc/member[@name="WS_MESSAGE_STATE.WS_MESSAGE_STATE_WRITING"]/*' />
    WS_MESSAGE_STATE_WRITING = 4,

    /// <include file='WS_MESSAGE_STATE.xml' path='doc/member[@name="WS_MESSAGE_STATE.WS_MESSAGE_STATE_DONE"]/*' />
    WS_MESSAGE_STATE_DONE = 5,
}
