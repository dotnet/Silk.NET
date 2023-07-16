// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_TIMECODE_FLAGS.xml' path='doc/member[@name="DVD_TIMECODE_FLAGS"]/*'/>
public enum DVD_TIMECODE_FLAGS
{
    /// <include file='DVD_TIMECODE_FLAGS.xml' path='doc/member[@name="DVD_TIMECODE_FLAGS.DVD_TC_FLAG_25fps"]/*'/>
    DVD_TC_FLAG_25fps = 0x1,
    /// <include file='DVD_TIMECODE_FLAGS.xml' path='doc/member[@name="DVD_TIMECODE_FLAGS.DVD_TC_FLAG_30fps"]/*'/>
    DVD_TC_FLAG_30fps = 0x2,
    /// <include file='DVD_TIMECODE_FLAGS.xml' path='doc/member[@name="DVD_TIMECODE_FLAGS.DVD_TC_FLAG_DropFrame"]/*'/>
    DVD_TC_FLAG_DropFrame = 0x4,
    /// <include file='DVD_TIMECODE_FLAGS.xml' path='doc/member[@name="DVD_TIMECODE_FLAGS.DVD_TC_FLAG_Interpolated"]/*'/>
    DVD_TC_FLAG_Interpolated = 0x8,
}