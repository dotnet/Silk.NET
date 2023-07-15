// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent"]/*'/>
public enum DISPID_SpeechVoiceEvent
{
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEStreamStart"]/*'/>
    DISPID_SVEStreamStart = 1,
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEStreamEnd"]/*'/>
    DISPID_SVEStreamEnd = (DISPID_SVEStreamStart + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEVoiceChange"]/*'/>
    DISPID_SVEVoiceChange = (DISPID_SVEStreamEnd + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEBookmark"]/*'/>
    DISPID_SVEBookmark = (DISPID_SVEVoiceChange + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEWord"]/*'/>
    DISPID_SVEWord = (DISPID_SVEBookmark + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEPhoneme"]/*'/>
    DISPID_SVEPhoneme = (DISPID_SVEWord + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVESentenceBoundary"]/*'/>
    DISPID_SVESentenceBoundary = (DISPID_SVEPhoneme + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEViseme"]/*'/>
    DISPID_SVEViseme = (DISPID_SVESentenceBoundary + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEAudioLevel"]/*'/>
    DISPID_SVEAudioLevel = (DISPID_SVEViseme + 1),
    /// <include file='DISPID_SpeechVoiceEvent.xml' path='doc/member[@name="DISPID_SpeechVoiceEvent.DISPID_SVEEnginePrivate"]/*'/>
    DISPID_SVEEnginePrivate = (DISPID_SVEAudioLevel + 1),
}