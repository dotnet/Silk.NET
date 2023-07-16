// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_DVD_STREAM_FLAGS.xml' path='doc/member[@name="AM_DVD_STREAM_FLAGS"]/*'/>
public enum AM_DVD_STREAM_FLAGS
{
    /// <include file='AM_DVD_STREAM_FLAGS.xml' path='doc/member[@name="AM_DVD_STREAM_FLAGS.AM_DVD_STREAM_VIDEO"]/*'/>
    AM_DVD_STREAM_VIDEO = 0x1,
    /// <include file='AM_DVD_STREAM_FLAGS.xml' path='doc/member[@name="AM_DVD_STREAM_FLAGS.AM_DVD_STREAM_AUDIO"]/*'/>
    AM_DVD_STREAM_AUDIO = 0x2,
    /// <include file='AM_DVD_STREAM_FLAGS.xml' path='doc/member[@name="AM_DVD_STREAM_FLAGS.AM_DVD_STREAM_SUBPIC"]/*'/>
    AM_DVD_STREAM_SUBPIC = 0x4,
}