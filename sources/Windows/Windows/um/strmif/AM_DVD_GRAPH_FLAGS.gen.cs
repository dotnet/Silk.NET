// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS"]/*' />
public enum AM_DVD_GRAPH_FLAGS
{
    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_HWDEC_PREFER"]/*' />
    AM_DVD_HWDEC_PREFER = 0x1,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_HWDEC_ONLY"]/*' />
    AM_DVD_HWDEC_ONLY = 0x2,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_SWDEC_PREFER"]/*' />
    AM_DVD_SWDEC_PREFER = 0x4,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_SWDEC_ONLY"]/*' />
    AM_DVD_SWDEC_ONLY = 0x8,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_NOVPE"]/*' />
    AM_DVD_NOVPE = 0x100,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_DO_NOT_CLEAR"]/*' />
    AM_DVD_DO_NOT_CLEAR = 0x200,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_VMR9_ONLY"]/*' />
    AM_DVD_VMR9_ONLY = 0x800,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_EVR_ONLY"]/*' />
    AM_DVD_EVR_ONLY = 0x1000,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_EVR_QOS"]/*' />
    AM_DVD_EVR_QOS = 0x2000,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_ADAPT_GRAPH"]/*' />
    AM_DVD_ADAPT_GRAPH = 0x4000,

    /// <include file='AM_DVD_GRAPH_FLAGS.xml' path='doc/member[@name="AM_DVD_GRAPH_FLAGS.AM_DVD_MASK"]/*' />
    AM_DVD_MASK = 0xffff,
}
