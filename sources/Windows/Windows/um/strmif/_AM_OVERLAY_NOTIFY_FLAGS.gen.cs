// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='_AM_OVERLAY_NOTIFY_FLAGS.xml' path='doc/member[@name="_AM_OVERLAY_NOTIFY_FLAGS"]/*' />
public enum _AM_OVERLAY_NOTIFY_FLAGS
{
    /// <include file='_AM_OVERLAY_NOTIFY_FLAGS.xml' path='doc/member[@name="_AM_OVERLAY_NOTIFY_FLAGS.AM_OVERLAY_NOTIFY_VISIBLE_CHANGE"]/*' />
    AM_OVERLAY_NOTIFY_VISIBLE_CHANGE = 0x1,

    /// <include file='_AM_OVERLAY_NOTIFY_FLAGS.xml' path='doc/member[@name="_AM_OVERLAY_NOTIFY_FLAGS.AM_OVERLAY_NOTIFY_SOURCE_CHANGE"]/*' />
    AM_OVERLAY_NOTIFY_SOURCE_CHANGE = 0x2,

    /// <include file='_AM_OVERLAY_NOTIFY_FLAGS.xml' path='doc/member[@name="_AM_OVERLAY_NOTIFY_FLAGS.AM_OVERLAY_NOTIFY_DEST_CHANGE"]/*' />
    AM_OVERLAY_NOTIFY_DEST_CHANGE = 0x4,
}
