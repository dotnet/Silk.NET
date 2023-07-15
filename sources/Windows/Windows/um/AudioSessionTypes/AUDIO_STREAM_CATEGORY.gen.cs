// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AudioSessionTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum AUDIO_STREAM_CATEGORY
{
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_Other"]/*'/>
    AudioCategory_Other = 0,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_ForegroundOnlyMedia"]/*'/>
    AudioCategory_ForegroundOnlyMedia = 1,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_Communications"]/*'/>
    AudioCategory_Communications = 3,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_Alerts"]/*'/>
    AudioCategory_Alerts = 4,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_SoundEffects"]/*'/>
    AudioCategory_SoundEffects = 5,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_GameEffects"]/*'/>
    AudioCategory_GameEffects = 6,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_GameMedia"]/*'/>
    AudioCategory_GameMedia = 7,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_GameChat"]/*'/>
    AudioCategory_GameChat = 8,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_Speech"]/*'/>
    AudioCategory_Speech = 9,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_Movie"]/*'/>
    AudioCategory_Movie = 10,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_Media"]/*'/>
    AudioCategory_Media = 11,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_FarFieldSpeech"]/*'/>
    AudioCategory_FarFieldSpeech = 12,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_UniformSpeech"]/*'/>
    AudioCategory_UniformSpeech = 13,
    /// <include file='AUDIO_STREAM_CATEGORY.xml' path='doc/member[@name="AUDIO_STREAM_CATEGORY.AudioCategory_VoiceTyping"]/*'/>
    AudioCategory_VoiceTyping = 14,
}