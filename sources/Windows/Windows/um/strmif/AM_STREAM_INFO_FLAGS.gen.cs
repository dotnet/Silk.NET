// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_STREAM_INFO_FLAGS.xml' path='doc/member[@name="AM_STREAM_INFO_FLAGS"]/*'/>
public enum AM_STREAM_INFO_FLAGS
{
    /// <include file='AM_STREAM_INFO_FLAGS.xml' path='doc/member[@name="AM_STREAM_INFO_FLAGS.AM_STREAM_INFO_START_DEFINED"]/*'/>
    AM_STREAM_INFO_START_DEFINED = 0x1,
    /// <include file='AM_STREAM_INFO_FLAGS.xml' path='doc/member[@name="AM_STREAM_INFO_FLAGS.AM_STREAM_INFO_STOP_DEFINED"]/*'/>
    AM_STREAM_INFO_STOP_DEFINED = 0x2,
    /// <include file='AM_STREAM_INFO_FLAGS.xml' path='doc/member[@name="AM_STREAM_INFO_FLAGS.AM_STREAM_INFO_DISCARDING"]/*'/>
    AM_STREAM_INFO_DISCARDING = 0x4,
    /// <include file='AM_STREAM_INFO_FLAGS.xml' path='doc/member[@name="AM_STREAM_INFO_FLAGS.AM_STREAM_INFO_STOP_SEND_EXTRA"]/*'/>
    AM_STREAM_INFO_STOP_SEND_EXTRA = 0x10,
}