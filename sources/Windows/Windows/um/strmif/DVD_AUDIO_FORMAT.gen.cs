// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT"]/*'/>
public enum DVD_AUDIO_FORMAT
{
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_AC3"]/*'/>
    DVD_AudioFormat_AC3 = 0,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_MPEG1"]/*'/>
    DVD_AudioFormat_MPEG1 = 1,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_MPEG1_DRC"]/*'/>
    DVD_AudioFormat_MPEG1_DRC = 2,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_MPEG2"]/*'/>
    DVD_AudioFormat_MPEG2 = 3,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_MPEG2_DRC"]/*'/>
    DVD_AudioFormat_MPEG2_DRC = 4,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_LPCM"]/*'/>
    DVD_AudioFormat_LPCM = 5,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_DTS"]/*'/>
    DVD_AudioFormat_DTS = 6,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_SDDS"]/*'/>
    DVD_AudioFormat_SDDS = 7,
    /// <include file='DVD_AUDIO_FORMAT.xml' path='doc/member[@name="DVD_AUDIO_FORMAT.DVD_AudioFormat_Other"]/*'/>
    DVD_AudioFormat_Other = 8,
}