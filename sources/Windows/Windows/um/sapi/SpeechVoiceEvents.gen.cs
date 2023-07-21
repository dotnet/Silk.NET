// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents"]/*' />
public enum SpeechVoiceEvents
{
    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEStartInputStream"]/*' />
    SVEStartInputStream = (1 << 1),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEEndInputStream"]/*' />
    SVEEndInputStream = (1 << 2),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEVoiceChange"]/*' />
    SVEVoiceChange = (1 << 3),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEBookmark"]/*' />
    SVEBookmark = (1 << 4),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEWordBoundary"]/*' />
    SVEWordBoundary = (1 << 5),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEPhoneme"]/*' />
    SVEPhoneme = (1 << 6),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVESentenceBoundary"]/*' />
    SVESentenceBoundary = (1 << 7),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEViseme"]/*' />
    SVEViseme = (1 << 8),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEAudioLevel"]/*' />
    SVEAudioLevel = (1 << 9),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEPrivate"]/*' />
    SVEPrivate = (1 << 15),

    /// <include file='SpeechVoiceEvents.xml' path='doc/member[@name="SpeechVoiceEvents.SVEAllEvents"]/*' />
    SVEAllEvents = 0x83fe,
}
