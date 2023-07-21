// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice"]/*' />
public enum DISPID_SpeechVoice
{
    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVStatus"]/*' />
    DISPID_SVStatus = 1,

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVVoice"]/*' />
    DISPID_SVVoice = (DISPID_SVStatus + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVAudioOutput"]/*' />
    DISPID_SVAudioOutput = (DISPID_SVVoice + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVAudioOutputStream"]/*' />
    DISPID_SVAudioOutputStream = (DISPID_SVAudioOutput + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVRate"]/*' />
    DISPID_SVRate = (DISPID_SVAudioOutputStream + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVVolume"]/*' />
    DISPID_SVVolume = (DISPID_SVRate + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVAllowAudioOuputFormatChangesOnNextSet"]/*' />
    DISPID_SVAllowAudioOuputFormatChangesOnNextSet = (DISPID_SVVolume + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVEventInterests"]/*' />
    DISPID_SVEventInterests = (DISPID_SVAllowAudioOuputFormatChangesOnNextSet + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVPriority"]/*' />
    DISPID_SVPriority = (DISPID_SVEventInterests + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVAlertBoundary"]/*' />
    DISPID_SVAlertBoundary = (DISPID_SVPriority + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVSyncronousSpeakTimeout"]/*' />
    DISPID_SVSyncronousSpeakTimeout = (DISPID_SVAlertBoundary + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVSpeak"]/*' />
    DISPID_SVSpeak = (DISPID_SVSyncronousSpeakTimeout + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVSpeakStream"]/*' />
    DISPID_SVSpeakStream = (DISPID_SVSpeak + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVPause"]/*' />
    DISPID_SVPause = (DISPID_SVSpeakStream + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVResume"]/*' />
    DISPID_SVResume = (DISPID_SVPause + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVSkip"]/*' />
    DISPID_SVSkip = (DISPID_SVResume + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVGetVoices"]/*' />
    DISPID_SVGetVoices = (DISPID_SVSkip + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVGetAudioOutputs"]/*' />
    DISPID_SVGetAudioOutputs = (DISPID_SVGetVoices + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVWaitUntilDone"]/*' />
    DISPID_SVWaitUntilDone = (DISPID_SVGetAudioOutputs + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVSpeakCompleteEvent"]/*' />
    DISPID_SVSpeakCompleteEvent = (DISPID_SVWaitUntilDone + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVIsUISupported"]/*' />
    DISPID_SVIsUISupported = (DISPID_SVSpeakCompleteEvent + 1),

    /// <include file='DISPID_SpeechVoice.xml' path='doc/member[@name="DISPID_SpeechVoice.DISPID_SVDisplayUI"]/*' />
    DISPID_SVDisplayUI = (DISPID_SVIsUISupported + 1),
}
