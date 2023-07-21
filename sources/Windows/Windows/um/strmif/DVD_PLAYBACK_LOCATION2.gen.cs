// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_PLAYBACK_LOCATION2.xml' path='doc/member[@name="DVD_PLAYBACK_LOCATION2"]/*' />
public partial struct DVD_PLAYBACK_LOCATION2
{
    /// <include file='DVD_PLAYBACK_LOCATION2.xml' path='doc/member[@name="DVD_PLAYBACK_LOCATION2.TitleNum"]/*' />
    [NativeTypeName("ULONG")]
    public uint TitleNum;

    /// <include file='DVD_PLAYBACK_LOCATION2.xml' path='doc/member[@name="DVD_PLAYBACK_LOCATION2.ChapterNum"]/*' />
    [NativeTypeName("ULONG")]
    public uint ChapterNum;

    /// <include file='DVD_PLAYBACK_LOCATION2.xml' path='doc/member[@name="DVD_PLAYBACK_LOCATION2.TimeCode"]/*' />
    public DVD_HMSF_TIMECODE TimeCode;

    /// <include file='DVD_PLAYBACK_LOCATION2.xml' path='doc/member[@name="DVD_PLAYBACK_LOCATION2.TimeCodeFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint TimeCodeFlags;
}
