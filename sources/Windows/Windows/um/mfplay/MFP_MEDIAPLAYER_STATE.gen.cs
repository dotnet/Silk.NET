// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFP_MEDIAPLAYER_STATE.xml' path='doc/member[@name="MFP_MEDIAPLAYER_STATE"]/*' />
public enum MFP_MEDIAPLAYER_STATE
{
    /// <include file='MFP_MEDIAPLAYER_STATE.xml' path='doc/member[@name="MFP_MEDIAPLAYER_STATE.MFP_MEDIAPLAYER_STATE_EMPTY"]/*' />
    MFP_MEDIAPLAYER_STATE_EMPTY = 0,

    /// <include file='MFP_MEDIAPLAYER_STATE.xml' path='doc/member[@name="MFP_MEDIAPLAYER_STATE.MFP_MEDIAPLAYER_STATE_STOPPED"]/*' />
    MFP_MEDIAPLAYER_STATE_STOPPED = 0x1,

    /// <include file='MFP_MEDIAPLAYER_STATE.xml' path='doc/member[@name="MFP_MEDIAPLAYER_STATE.MFP_MEDIAPLAYER_STATE_PLAYING"]/*' />
    MFP_MEDIAPLAYER_STATE_PLAYING = 0x2,

    /// <include file='MFP_MEDIAPLAYER_STATE.xml' path='doc/member[@name="MFP_MEDIAPLAYER_STATE.MFP_MEDIAPLAYER_STATE_PAUSED"]/*' />
    MFP_MEDIAPLAYER_STATE_PAUSED = 0x3,

    /// <include file='MFP_MEDIAPLAYER_STATE.xml' path='doc/member[@name="MFP_MEDIAPLAYER_STATE.MFP_MEDIAPLAYER_STATE_SHUTDOWN"]/*' />
    MFP_MEDIAPLAYER_STATE_SHUTDOWN = 0x4,
}
