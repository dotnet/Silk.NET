// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_AUDIO_APPMODE.xml' path='doc/member[@name="DVD_AUDIO_APPMODE"]/*'/>
public enum DVD_AUDIO_APPMODE
{
    /// <include file='DVD_AUDIO_APPMODE.xml' path='doc/member[@name="DVD_AUDIO_APPMODE.DVD_AudioMode_None"]/*'/>
    DVD_AudioMode_None = 0,
    /// <include file='DVD_AUDIO_APPMODE.xml' path='doc/member[@name="DVD_AUDIO_APPMODE.DVD_AudioMode_Karaoke"]/*'/>
    DVD_AudioMode_Karaoke = 1,
    /// <include file='DVD_AUDIO_APPMODE.xml' path='doc/member[@name="DVD_AUDIO_APPMODE.DVD_AudioMode_Surround"]/*'/>
    DVD_AudioMode_Surround = 2,
    /// <include file='DVD_AUDIO_APPMODE.xml' path='doc/member[@name="DVD_AUDIO_APPMODE.DVD_AudioMode_Other"]/*'/>
    DVD_AudioMode_Other = 3,
}